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
        public async Task<ListModulesResponse> ListModulesAsync(string? moduleNamespace = null, int? offset = null, string? provider = null, bool? verified = null)
        {
            try
            {
                var queryParams = new List<string>();

                if (offset.HasValue)
                {
                    queryParams.Add($"offset={offset.Value}");
                }

                if (!string.IsNullOrEmpty(provider))
                {
                    queryParams.Add($"provider={provider}");
                }

                if (verified.HasValue)
                {
                    queryParams.Add($"verified={verified.Value.ToString().ToLower()}");
                }

                var queryString = string.Join("&", queryParams);
                var url = string.IsNullOrEmpty(moduleNamespace) ? "modules" : $"modules/{moduleNamespace}";

                if (!string.IsNullOrEmpty(queryString))
                {
                    url += $"?{queryString}";
                }

                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    return JsonSerializer.Deserialize<ListModulesResponse>(jsonResponse, options)
                        ?? throw new InvalidOperationException("Deserialization returned null.");
                }

                throw new HttpRequestException($"Error fetching modules: {response.StatusCode}");
            }
            catch (HttpRequestException ex)
            {
                // Handle HTTP-specific errors
                Console.WriteLine($"HTTP error occurred: {ex.Message}");
                throw;
            }
            catch (JsonException ex)
            {
                // Handle JSON deserialization errors
                Console.WriteLine($"JSON deserialization error: {ex.Message}");
                throw new InvalidOperationException("Failed to deserialize the response.", ex);
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }
        public async Task<ListModulesResponse> SearchModulesAsync(string searchString, int? offset = null, string? provider = null, bool? verified = null)
        {
            try
            {
                var queryParams = new List<string>();

                if (offset.HasValue)
                {
                    queryParams.Add($"offset={offset.Value}");
                }

                if (!string.IsNullOrEmpty(provider))
                {
                    queryParams.Add($"provider={provider}");
                }

                if (verified.HasValue)
                {
                    queryParams.Add($"verified={verified.Value.ToString().ToLower()}");
                }

                var queryString = string.Join("&", queryParams);
                var url = $"modules/search?q={searchString}";

                if (!string.IsNullOrEmpty(queryString))
                {
                    url += $"?{queryString}";
                }

                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    return JsonSerializer.Deserialize<ListModulesResponse>(jsonResponse, options)
                        ?? throw new InvalidOperationException("Deserialization returned null.");
                }

                throw new HttpRequestException($"Error searching modules: {response.StatusCode}");
            }
            catch (HttpRequestException ex)
            {
                // Handle HTTP-specific errors
                Console.WriteLine($"HTTP error occurred: {ex.Message}");
                throw;
            }
            catch (JsonException ex)
            {
                // Handle JSON deserialization errors
                Console.WriteLine($"JSON deserialization error: {ex.Message}");
                throw new InvalidOperationException("Failed to deserialize the response.", ex);
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }
        public async Task<ListModuleVersionResponse> ListModuleVersionAsync(string moduleNamespace, string moduleName, string moduleProvider)
        {
            try
            {
                var url = $"modules/{moduleNamespace}/{moduleName}/{moduleProvider}/versions";

                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    options.Converters.Add(new VersionJsonConverter());

                    return JsonSerializer.Deserialize<ListModuleVersionResponse>(jsonResponse, options)
                        ?? throw new InvalidOperationException("Deserialization returned null.");
                }

                throw new HttpRequestException($"Error fetching module versions: {response.StatusCode}");
            }
            catch (HttpRequestException ex)
            {
                // Handle HTTP-specific errors
                Console.WriteLine($"HTTP error occurred: {ex.Message}");
                throw;
            }
            catch (JsonException ex)
            {
                // Handle JSON deserialization errors
                Console.WriteLine($"JSON deserialization error: {ex.Message}");
                throw new InvalidOperationException("Failed to deserialize the response.", ex);
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }
        public async Task<ListModulesResponse> ListLatestVersionModuleProviderAsync(string moduleNamespace, string moduleName, int? offset = null)
        {
            try
            {
                var queryParams = new List<string>();

                if (offset.HasValue)
                {
                    queryParams.Add($"offset={offset.Value}");
                }

                var queryString = string.Join("&", queryParams);
                var url = $"modules/{moduleNamespace}/{moduleName}";

                if (!string.IsNullOrEmpty(queryString))
                {
                    url += $"?{queryString}";
                }
                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    options.Converters.Add(new VersionJsonConverter());

                    return JsonSerializer.Deserialize<ListModulesResponse>(jsonResponse, options)
                        ?? throw new InvalidOperationException("Deserialization returned null.");
                }

                throw new HttpRequestException($"Error fetching module versions: {response.StatusCode}");
            }
            catch (HttpRequestException ex)
            {
                // Handle HTTP-specific errors
                Console.WriteLine($"HTTP error occurred: {ex.Message}");
                throw;
            }
            catch (JsonException ex)
            {
                // Handle JSON deserialization errors
                Console.WriteLine($"JSON deserialization error: {ex.Message}");
                throw new InvalidOperationException("Failed to deserialize the response.", ex);
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }
        public async Task<GetModuleResponse> GetModuleAsync(string moduleNamespace, string moduleName, string moduleProvider)
        {
            try
            {
                var url = $"modules/{moduleNamespace}/{moduleName}/{moduleProvider}";

                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    options.Converters.Add(new VersionJsonConverter());

                    return JsonSerializer.Deserialize<GetModuleResponse>(jsonResponse, options)
                        ?? throw new InvalidOperationException("Deserialization returned null.");
                }

                throw new HttpRequestException($"Error fetching module versions: {response.StatusCode}");
            }
            catch (HttpRequestException ex)
            {
                // Handle HTTP-specific errors
                Console.WriteLine($"HTTP error occurred: {ex.Message}");
                throw;
            }
            catch (JsonException ex)
            {
                // Handle JSON deserialization errors
                Console.WriteLine($"JSON deserialization error: {ex.Message}");
                throw new InvalidOperationException("Failed to deserialize the response.", ex);
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }
        public async Task<GetModuleResponse> GetModuleAsync(string moduleNamespace, string moduleName, string moduleProvider, string moduleVersion)
        {
            try
            {
                var url = $"modules/{moduleNamespace}/{moduleName}/{moduleProvider}/{moduleVersion}";

                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    options.Converters.Add(new VersionJsonConverter());

                    return JsonSerializer.Deserialize<GetModuleResponse>(jsonResponse, options)
                        ?? throw new InvalidOperationException("Deserialization returned null.");
                }

                throw new HttpRequestException($"Error fetching module versions: {response.StatusCode}");
            }
            catch (HttpRequestException ex)
            {
                // Handle HTTP-specific errors
                Console.WriteLine($"HTTP error occurred: {ex.Message}");
                throw;
            }
            catch (JsonException ex)
            {
                // Handle JSON deserialization errors
                Console.WriteLine($"JSON deserialization error: {ex.Message}");
                throw new InvalidOperationException("Failed to deserialize the response.", ex);
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }
    }
}