#### [TerraformRegistryClient](index.md 'index')
### [ModPosh.TerraformRegistryClient](ModPosh.TerraformRegistryClient.md 'ModPosh.TerraformRegistryClient').[Client](ModPosh.TerraformRegistryClient.Client.md 'ModPosh.TerraformRegistryClient.Client')

## Client.GetModuleAsync(string, string, string, string) Method

Retrieves detailed information about a specific version of a module.

```csharp
public System.Threading.Tasks.Task<ModPosh.TerraformRegistryClient.Models.GetModuleResponse> GetModuleAsync(string moduleNamespace, string moduleName, string moduleProvider, string moduleVersion);
```
#### Parameters

<a name='ModPosh.TerraformRegistryClient.Client.GetModuleAsync(string,string,string,string).moduleNamespace'></a>

`moduleNamespace` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The namespace of the module.

<a name='ModPosh.TerraformRegistryClient.Client.GetModuleAsync(string,string,string,string).moduleName'></a>

`moduleName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the module.

<a name='ModPosh.TerraformRegistryClient.Client.GetModuleAsync(string,string,string,string).moduleProvider'></a>

`moduleProvider` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The provider of the module.

<a name='ModPosh.TerraformRegistryClient.Client.GetModuleAsync(string,string,string,string).moduleVersion'></a>

`moduleVersion` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The version of the module to retrieve details for.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[GetModuleResponse](ModPosh.TerraformRegistryClient.Models.GetModuleResponse.md 'ModPosh.TerraformRegistryClient.Models.GetModuleResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A [GetModuleResponse](ModPosh.TerraformRegistryClient.Models.GetModuleResponse.md 'ModPosh.TerraformRegistryClient.Models.GetModuleResponse') containing the module details for the specified version.