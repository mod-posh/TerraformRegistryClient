#### [TerraformRegistryClient](index.md 'index')
### [ModPosh.TerraformRegistryClient](ModPosh.TerraformRegistryClient.md 'ModPosh.TerraformRegistryClient').[Client](ModPosh.TerraformRegistryClient.Client.md 'ModPosh.TerraformRegistryClient.Client')

## Client.ListLatestVersionModuleProviderAsync(string, string, Nullable<int>) Method

Lists the latest version of a module provider.

```csharp
public System.Threading.Tasks.Task<ModPosh.TerraformRegistryClient.Models.ListModulesResponse> ListLatestVersionModuleProviderAsync(string moduleNamespace, string moduleName, System.Nullable<int> offset=null);
```
#### Parameters

<a name='ModPosh.TerraformRegistryClient.Client.ListLatestVersionModuleProviderAsync(string,string,System.Nullable_int_).moduleNamespace'></a>

`moduleNamespace` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The namespace of the module.

<a name='ModPosh.TerraformRegistryClient.Client.ListLatestVersionModuleProviderAsync(string,string,System.Nullable_int_).moduleName'></a>

`moduleName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the module.

<a name='ModPosh.TerraformRegistryClient.Client.ListLatestVersionModuleProviderAsync(string,string,System.Nullable_int_).offset'></a>

`offset` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The offset for pagination.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[ListModulesResponse](ModPosh.TerraformRegistryClient.Models.ListModulesResponse.md 'ModPosh.TerraformRegistryClient.Models.ListModulesResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A [ListModulesResponse](ModPosh.TerraformRegistryClient.Models.ListModulesResponse.md 'ModPosh.TerraformRegistryClient.Models.ListModulesResponse') containing the latest version of the module provider.