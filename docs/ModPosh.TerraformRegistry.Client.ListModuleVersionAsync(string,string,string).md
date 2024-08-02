#### [TerraformRegistryClient](index.md 'index')
### [ModPosh.TerraformRegistry](ModPosh.TerraformRegistry.md 'ModPosh.TerraformRegistry').[Client](ModPosh.TerraformRegistry.Client.md 'ModPosh.TerraformRegistry.Client')

## Client.ListModuleVersionAsync(string, string, string) Method

Lists the versions of a specific module available in the Terraform Registry.

```csharp
public System.Threading.Tasks.Task<ModPosh.Models.ListModuleVersionResponse> ListModuleVersionAsync(string moduleNamespace, string moduleName, string moduleProvider);
```
#### Parameters

<a name='ModPosh.TerraformRegistry.Client.ListModuleVersionAsync(string,string,string).moduleNamespace'></a>

`moduleNamespace` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The namespace of the module.

<a name='ModPosh.TerraformRegistry.Client.ListModuleVersionAsync(string,string,string).moduleName'></a>

`moduleName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the module.

<a name='ModPosh.TerraformRegistry.Client.ListModuleVersionAsync(string,string,string).moduleProvider'></a>

`moduleProvider` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The provider of the module.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[ListModuleVersionResponse](ModPosh.Models.ListModuleVersionResponse.md 'ModPosh.Models.ListModuleVersionResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A [ListModuleVersionResponse](ModPosh.Models.ListModuleVersionResponse.md 'ModPosh.Models.ListModuleVersionResponse') containing the list of versions.