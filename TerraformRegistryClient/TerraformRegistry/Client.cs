using ModPosh.TerraformRegistryClient.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TerraformRegistryClient.Tests")]
namespace ModPosh.TerraformRegistryClient
{
    /// <summary>
    /// Encapsulates connection information required to connect to the Terraform Registry API.
    /// </summary>
    public class TerraformRegistryConnectionInfo
    {
        /// <summary>
        /// Gets or sets the base address of the Terraform Registry API.
        /// </summary>
        /// <value>
        /// The base address as a string, typically in the format of a URL.
        /// </value>
        /// <exception cref="ArgumentNullException">
        /// Thrown when an attempt is made to set the base address to null.
        /// </exception>
        public string BaseAddress { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TerraformRegistryConnectionInfo"/> class.
        /// </summary>
        /// <param name="baseAddress">The base address of the Terraform Registry API. If null or empty, the default address is used.</param>
        public TerraformRegistryConnectionInfo(string? baseAddress = null)
        {
            BaseAddress = string.IsNullOrWhiteSpace(baseAddress) ? "https://registry.terraform.io/v1/" : baseAddress;
        }
    }
    /// <summary>
    /// Client for interacting with the Terraform Registry API.
    /// </summary>
    public class Client
    {
        internal HttpClient httpClient { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class with the default base address.
        /// </summary>

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class with the specified connection information.
        /// </summary>
        /// <param name="connectionInfo">The connection information required to connect to the Terraform Registry API.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="connectionInfo"/> is null.</exception>
        public Client(TerraformRegistryConnectionInfo connectionInfo)
        {
            if (connectionInfo == null)
            {
                throw new ArgumentNullException(nameof(connectionInfo));
            }

            httpClient = new HttpClient
            {
                BaseAddress = new Uri(connectionInfo.BaseAddress)
            };
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class with a specified base address.
        /// </summary>
        /// <param name="baseAddress">The base address of the Terraform Registry API. If null, defaults to "https://registry.terraform.io/v1/".</param>
        public Client(string? baseAddress = null)
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseAddress ?? "https://registry.terraform.io/v1/")
            };
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class with the specified connection information and an <see cref="IHttpClientFactory"/>.
        /// </summary>
        /// <param name="connectionInfo">The connection information required to connect to the Terraform Registry API.</param>
        /// <param name="httpClientFactory">The factory used to create an <see cref="HttpClient"/> instance.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="connectionInfo"/> or <paramref name="httpClientFactory"/> is null.
        /// </exception>
        public Client(TerraformRegistryConnectionInfo connectionInfo, IHttpClientFactory httpClientFactory)
        {
            if (connectionInfo == null)
                throw new ArgumentNullException(nameof(connectionInfo));
            if (httpClientFactory == null)
                throw new ArgumentNullException(nameof(httpClientFactory));

            this.httpClient = httpClientFactory.CreateClient();
            this.httpClient.BaseAddress = new Uri(connectionInfo.BaseAddress);
            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Sends a GET request to the specified URL and deserializes the JSON response to a specified type.
        /// </summary>
        /// <typeparam name="T">The type to which the JSON response will be deserialized.</typeparam>
        /// <param name="url">The URL to send the GET request to.</param>
        /// <returns>The deserialized response of type <typeparamref name="T"/>.</returns>
        /// <exception cref="HttpRequestException">Thrown when the HTTP request fails.</exception>
        /// <exception cref="InvalidOperationException">Thrown when deserialization fails or returns null.</exception>
        private async Task<T> GetAsync<T>(string url)
        {
            try
            {
                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    options.Converters.Add(new VersionJsonConverter());

                    return JsonSerializer.Deserialize<T>(jsonResponse, options)
                        ?? throw new InvalidOperationException("Deserialization returned null.");
                }

                throw new HttpRequestException($"Error fetching data: {response.StatusCode}");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP error occurred: {ex.Message}");
                throw;
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"JSON deserialization error: {ex.Message}");
                throw new InvalidOperationException("Failed to deserialize the response.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Builds a query string from the provided parameters.
        /// </summary>
        /// <param name="parameters">A list of key-value pairs representing query parameters.</param>
        /// <returns>A query string starting with '?' if parameters are provided; otherwise, an empty string.</returns>
        private string BuildQueryString(params (string Key, string? Value)[] parameters)
        {
            var queryParams = parameters
                .Where(param => !string.IsNullOrEmpty(param.Value))
                .Select(param => $"{param.Key}={param.Value}")
                .ToList();

            return queryParams.Count > 0 ? $"?{string.Join("&", queryParams)}" : string.Empty;
        }

        /// <summary>
        /// Lists modules available in the Terraform Registry.
        /// </summary>
        /// <param name="moduleNamespace">The namespace of the modules to list. If null, lists all modules.</param>
        /// <param name="offset">The offset for pagination.</param>
        /// <param name="provider">The provider to filter modules by.</param>
        /// <param name="verified">Whether to filter by verified modules.</param>
        /// <returns>A <see cref="ListModulesResponse"/> containing the list of modules.</returns>
        public Task<ListModulesResponse> ListModulesAsync(string? moduleNamespace = null, int? offset = null, string? provider = null, bool? verified = null)
        {
            var queryString = BuildQueryString(
                ("offset", offset?.ToString()),
                ("provider", provider),
                ("verified", verified?.ToString().ToLower())
            );

            var url = string.IsNullOrEmpty(moduleNamespace) ? $"modules{queryString}" : $"modules/{moduleNamespace}{queryString}";

            return GetAsync<ListModulesResponse>(url);
        }

        /// <summary>
        /// Searches for modules in the Terraform Registry.
        /// </summary>
        /// <param name="searchString">The search string to query modules.</param>
        /// <param name="offset">The offset for pagination.</param>
        /// <param name="provider">The provider to filter modules by.</param>
        /// <param name="verified">Whether to filter by verified modules.</param>
        /// <returns>A <see cref="ListModulesResponse"/> containing the search results.</returns>
        public Task<ListModulesResponse> SearchModulesAsync(string searchString, int? offset = null, string? provider = null, bool? verified = null)
        {
            var queryString = BuildQueryString(
                ("offset", offset?.ToString()),
                ("provider", provider),
                ("verified", verified?.ToString().ToLower())
            );

            var url = $"modules/search?q={searchString}{queryString}";

            return GetAsync<ListModulesResponse>(url);
        }

        /// <summary>
        /// Lists the versions of a specific module available in the Terraform Registry.
        /// </summary>
        /// <param name="moduleNamespace">The namespace of the module.</param>
        /// <param name="moduleName">The name of the module.</param>
        /// <param name="moduleProvider">The provider of the module.</param>
        /// <returns>A <see cref="ListModuleVersionResponse"/> containing the list of versions.</returns>
        public Task<ListModuleVersionResponse> ListModuleVersionAsync(string moduleNamespace, string moduleName, string moduleProvider)
        {
            var url = $"modules/{moduleNamespace}/{moduleName}/{moduleProvider}/versions";
            return GetAsync<ListModuleVersionResponse>(url);
        }

        /// <summary>
        /// Lists the latest version of a module provider.
        /// </summary>
        /// <param name="moduleNamespace">The namespace of the module.</param>
        /// <param name="moduleName">The name of the module.</param>
        /// <param name="offset">The offset for pagination.</param>
        /// <returns>A <see cref="ListModulesResponse"/> containing the latest version of the module provider.</returns>
        public Task<ListModulesResponse> ListLatestVersionModuleProviderAsync(string moduleNamespace, string moduleName, int? offset = null)
        {
            var queryString = BuildQueryString(
                ("offset", offset?.ToString())
            );

            var url = $"modules/{moduleNamespace}/{moduleName}{queryString}";

            return GetAsync<ListModulesResponse>(url);
        }

        /// <summary>
        /// Retrieves detailed information about a specific module.
        /// </summary>
        /// <param name="moduleNamespace">The namespace of the module.</param>
        /// <param name="moduleName">The name of the module.</param>
        /// <param name="moduleProvider">The provider of the module.</param>
        /// <returns>A <see cref="GetModuleResponse"/> containing the module details.</returns>
        public Task<GetModuleResponse> GetModuleAsync(string moduleNamespace, string moduleName, string moduleProvider)
        {
            var url = $"modules/{moduleNamespace}/{moduleName}/{moduleProvider}";
            return GetAsync<GetModuleResponse>(url);
        }

        /// <summary>
        /// Retrieves detailed information about a specific version of a module.
        /// </summary>
        /// <param name="moduleNamespace">The namespace of the module.</param>
        /// <param name="moduleName">The name of the module.</param>
        /// <param name="moduleProvider">The provider of the module.</param>
        /// <param name="moduleVersion">The version of the module to retrieve details for.</param>
        /// <returns>A <see cref="GetModuleResponse"/> containing the module details for the specified version.</returns>
        public Task<GetModuleResponse> GetModuleAsync(string moduleNamespace, string moduleName, string moduleProvider, string moduleVersion)
        {
            var url = $"modules/{moduleNamespace}/{moduleName}/{moduleProvider}/{moduleVersion}";
            return GetAsync<GetModuleResponse>(url);
        }
    }
}
