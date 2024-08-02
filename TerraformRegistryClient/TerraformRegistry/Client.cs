using ModPosh.Models;
using System.Net.Http.Headers;
using System.Text.Json;

namespace ModPosh.TerraformRegistry
{
    public class Client
    {
        private readonly HttpClient httpClient;

        public Client() : this(null) { }

        public Client(string? baseAddress = null)
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseAddress ?? "https://registry.terraform.io/v1/")
            };
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // Generalized method to handle GET requests and deserialize the response
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

        // Helper method to build query strings
        private string BuildQueryString(params (string Key, string? Value)[] parameters)
        {
            var queryParams = parameters
                .Where(param => !string.IsNullOrEmpty(param.Value))
                .Select(param => $"{param.Key}={param.Value}")
                .ToList();

            return queryParams.Count > 0 ? $"?{string.Join("&", queryParams)}" : string.Empty;
        }

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

        public Task<ListModuleVersionResponse> ListModuleVersionAsync(string moduleNamespace, string moduleName, string moduleProvider)
        {
            var url = $"modules/{moduleNamespace}/{moduleName}/{moduleProvider}/versions";
            return GetAsync<ListModuleVersionResponse>(url);
        }

        public Task<ListModulesResponse> ListLatestVersionModuleProviderAsync(string moduleNamespace, string moduleName, int? offset = null)
        {
            var queryString = BuildQueryString(
                ("offset", offset?.ToString())
            );

            var url = $"modules/{moduleNamespace}/{moduleName}{queryString}";

            return GetAsync<ListModulesResponse>(url);
        }

        public Task<GetModuleResponse> GetModuleAsync(string moduleNamespace, string moduleName, string moduleProvider)
        {
            var url = $"modules/{moduleNamespace}/{moduleName}/{moduleProvider}";
            return GetAsync<GetModuleResponse>(url);
        }

        public Task<GetModuleResponse> GetModuleAsync(string moduleNamespace, string moduleName, string moduleProvider, string moduleVersion)
        {
            var url = $"modules/{moduleNamespace}/{moduleName}/{moduleProvider}/{moduleVersion}";
            return GetAsync<GetModuleResponse>(url);
        }
    }
}
