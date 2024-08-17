#### [TerraformRegistryClient](index.md 'index')
### [ModPosh.TerraformRegistryClient](ModPosh.TerraformRegistryClient.md 'ModPosh.TerraformRegistryClient').[Client](ModPosh.TerraformRegistryClient.Client.md 'ModPosh.TerraformRegistryClient.Client')

## Client.ListModuleVersionAsync(string, string, string) Method

Lists the versions of a specific module available in the Terraform Registry.

```csharp
public System.Threading.Tasks.Task<ModPosh.TerraformRegistryClient.Models.ListModuleVersionResponse> ListModuleVersionAsync(string moduleNamespace, string moduleName, string moduleProvider);
```
#### Parameters

<a name='ModPosh.TerraformRegistryClient.Client.ListModuleVersionAsync(string,string,string).moduleNamespace'></a>

`moduleNamespace` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The namespace of the module.

<a name='ModPosh.TerraformRegistryClient.Client.ListModuleVersionAsync(string,string,string).moduleName'></a>

`moduleName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the module.

<a name='ModPosh.TerraformRegistryClient.Client.ListModuleVersionAsync(string,string,string).moduleProvider'></a>

`moduleProvider` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The provider of the module.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[ListModuleVersionResponse](ModPosh.TerraformRegistryClient.Models.ListModuleVersionResponse.md 'ModPosh.TerraformRegistryClient.Models.ListModuleVersionResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A [ListModuleVersionResponse](ModPosh.TerraformRegistryClient.Models.ListModuleVersionResponse.md 'ModPosh.TerraformRegistryClient.Models.ListModuleVersionResponse') containing the list of versions.