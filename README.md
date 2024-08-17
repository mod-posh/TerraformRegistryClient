| Latest Version | Nuget.org | Issues | License | Discord |
|-----------------|----------------|----------------|----------------|----------------|
| [![Latest Version](https://img.shields.io/github/v/tag/mod-posh/TerraformRegistryClient)](https://github.com/mod-posh/TerraformRegistryClient/tags) | [![Nuget.org](https://img.shields.io/nuget/dt/ModPosh.TerraformRegistry)](https://www.nuget.org/packages/ModPosh.TerraformRegistry) | [![GitHub issues](https://img.shields.io/github/issues/mod-posh/TerraformRegistryClient)](https://github.com/mod-posh/TerraformRegistryClient/issues) | [![GitHub license](https://img.shields.io/github/license/mod-posh/TerraformRegistryClient)](https://github.com/mod-posh/TerraformRegistryClient/blob/master/LICENSE) | [![Discord Server](https://assets-global.website-files.com/6257adef93867e50d84d30e2/636e0b5493894cf60b300587_full_logo_white_RGB.svg)](https://discord.com/channels/) |
# TerraformRegistryClient

The `TerraformRegistryClient` is a C# library designed to interact with the Terraform Registry API. It allows you to list modules, search for modules, retrieve module versions, and fetch detailed module information. This client can be used in both C# and PowerShell projects.

## Features

- List Terraform modules available in the registry.
- Search for specific modules using a search query.
- Retrieve detailed information about specific modules.

## Using the Client in C-Sharp

Below is an example of how to use the `TerraformRegistryClient` in your C# projects.

```csharp
using ModPosh.TerraformRegistryClient;
using ModPosh.TerraformRegistryClient.Models;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Create a ConnectionInfo object
        var connectionInfo = new TerraformRegistryConnectionInfo("https://registry.terraform.io/v1/");

        // Create an instance of the client with the connection info
        var client = new Client(connectionInfo);

        // Example: List all modules in a specific namespace
        var modulesResponse = await client.ListModulesAsync(moduleNamespace: "hashicorp");
        foreach (var module in modulesResponse.Modules)
        {
            Console.WriteLine($"Module: {module.Name}, Provider: {module.Provider}, Version: {module.Version}");
        }

        // Example: Search for modules with a specific query
        var searchResponse = await client.SearchModulesAsync("consul");
        foreach (var module in searchResponse.Modules)
        {
            Console.WriteLine($"Found module: {module.Name}, Provider: {module.Provider}");
        }

        // Example: Get detailed information about a specific module version
        var moduleDetails = await client.GetModuleAsync("hashicorp", "consul", "aws", "0.0.1");
        Console.WriteLine($"Module Description: {moduleDetails.Description}");
    }
}
```

## Using the Client in PowerShell

Below is an example of how to use the `TerraformRegistryClient` in your PowerShell scripts.

1. Load the assembly:

    ```powershell
    # Adjust the path to where your DLL is located
    Add-Type -Path "C:\path\to\ModPosh.TerraformRegistry.dll"
    ```

2. Create an instance of the client and use its methods:

    ```powershell
    # Create a ConnectionInfo object
    $connectionInfo = New-Object ModPosh.TerraformRegistryClient.TerraformRegistryConnectionInfo("https://registry.terraform.io/v1/")

    # Create an instance of the Client class with the connection info
    $client = New-Object ModPosh.TerraformRegistryClient.Client($connectionInfo)

    # Example: List all modules in a specific namespace
    $modulesResponse = $client.ListModulesAsync("hashicorp").Result
    foreach ($module in $modulesResponse.Modules) {
        Write-Host "Module: $($module.Name), Provider: $($module.Provider), Version: $($module.Version)"
    }

    # Example: Search for modules with a specific query
    $searchResponse = $client.SearchModulesAsync("consul").Result
    foreach ($module in $searchResponse.Modules) {
        Write-Host "Found module: $($module.Name), Provider: $($module.Provider)"
    }

    # Example: Get detailed information about a specific module version
    $moduleDetails = $client.GetModuleAsync("hashicorp", "consul", "aws", "0.0.1").Result
    Write-Host "Module Description: $($moduleDetails.Description)"
    ```

## API Documentation

### ListModulesAsync

```csharp
public Task<ListModulesResponse> ListModulesAsync(string? moduleNamespace = null, int? offset = null, string? provider = null, bool? verified = null)
```

Lists Terraform modules available in the registry, optionally filtering by namespace, provider, and verification status.

### SearchModulesAsync

```csharp
public Task<ListModulesResponse> SearchModulesAsync(string searchString, int? offset = null, string? provider = null, bool? verified = null)
```

Searches for Terraform modules using a search query, with optional filters for provider and verification status.

### ListModuleVersionAsync

```csharp
public Task<ListModuleVersionResponse> ListModuleVersionAsync(string moduleNamespace, string moduleName, string moduleProvider)
```

Lists the versions of a specific module available in the Terraform Registry.

### GetModuleAsync

```csharp
public Task<GetModuleResponse> GetModuleAsync(string moduleNamespace, string moduleName, string moduleProvider, string moduleVersion)
```

Retrieves detailed information about a specific version of a Terraform module.
