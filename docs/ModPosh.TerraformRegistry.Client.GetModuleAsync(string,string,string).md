#### [TerraformRegistryClient](index.md 'index')
### [ModPosh.TerraformRegistry](ModPosh.TerraformRegistry.md 'ModPosh.TerraformRegistry').[Client](ModPosh.TerraformRegistry.Client.md 'ModPosh.TerraformRegistry.Client')

## Client.GetModuleAsync(string, string, string) Method

Retrieves detailed information about a specific module.

```csharp
public System.Threading.Tasks.Task<ModPosh.Models.GetModuleResponse> GetModuleAsync(string moduleNamespace, string moduleName, string moduleProvider);
```
#### Parameters

<a name='ModPosh.TerraformRegistry.Client.GetModuleAsync(string,string,string).moduleNamespace'></a>

`moduleNamespace` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The namespace of the module.

<a name='ModPosh.TerraformRegistry.Client.GetModuleAsync(string,string,string).moduleName'></a>

`moduleName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the module.

<a name='ModPosh.TerraformRegistry.Client.GetModuleAsync(string,string,string).moduleProvider'></a>

`moduleProvider` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The provider of the module.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[GetModuleResponse](ModPosh.Models.GetModuleResponse.md 'ModPosh.Models.GetModuleResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A [GetModuleResponse](ModPosh.Models.GetModuleResponse.md 'ModPosh.Models.GetModuleResponse') containing the module details.