#### [TerraformRegistryClient](index.md 'index')
### [ModPosh.TerraformRegistryClient](ModPosh.TerraformRegistryClient.md 'ModPosh.TerraformRegistryClient').[Client](ModPosh.TerraformRegistryClient.Client.md 'ModPosh.TerraformRegistryClient.Client')

## Client.ListModulesAsync(string, Nullable<int>, string, Nullable<bool>) Method

Lists modules available in the Terraform Registry.

```csharp
public System.Threading.Tasks.Task<ModPosh.TerraformRegistryClient.Models.ListModulesResponse> ListModulesAsync(string? moduleNamespace=null, System.Nullable<int> offset=null, string? provider=null, System.Nullable<bool> verified=null);
```
#### Parameters

<a name='ModPosh.TerraformRegistryClient.Client.ListModulesAsync(string,System.Nullable_int_,string,System.Nullable_bool_).moduleNamespace'></a>

`moduleNamespace` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The namespace of the modules to list. If null, lists all modules.

<a name='ModPosh.TerraformRegistryClient.Client.ListModulesAsync(string,System.Nullable_int_,string,System.Nullable_bool_).offset'></a>

`offset` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The offset for pagination.

<a name='ModPosh.TerraformRegistryClient.Client.ListModulesAsync(string,System.Nullable_int_,string,System.Nullable_bool_).provider'></a>

`provider` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The provider to filter modules by.

<a name='ModPosh.TerraformRegistryClient.Client.ListModulesAsync(string,System.Nullable_int_,string,System.Nullable_bool_).verified'></a>

`verified` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

Whether to filter by verified modules.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[ListModulesResponse](ModPosh.TerraformRegistryClient.Models.ListModulesResponse.md 'ModPosh.TerraformRegistryClient.Models.ListModulesResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A [ListModulesResponse](ModPosh.TerraformRegistryClient.Models.ListModulesResponse.md 'ModPosh.TerraformRegistryClient.Models.ListModulesResponse') containing the list of modules.