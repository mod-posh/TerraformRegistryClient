#### [TerraformRegistryClient](index.md 'index')
### [ModPosh.TerraformRegistry](ModPosh.TerraformRegistry.md 'ModPosh.TerraformRegistry').[Client](ModPosh.TerraformRegistry.Client.md 'ModPosh.TerraformRegistry.Client')

## Client.SearchModulesAsync(string, Nullable<int>, string, Nullable<bool>) Method

Searches for modules in the Terraform Registry.

```csharp
public System.Threading.Tasks.Task<ModPosh.Models.ListModulesResponse> SearchModulesAsync(string searchString, System.Nullable<int> offset=null, string? provider=null, System.Nullable<bool> verified=null);
```
#### Parameters

<a name='ModPosh.TerraformRegistry.Client.SearchModulesAsync(string,System.Nullable_int_,string,System.Nullable_bool_).searchString'></a>

`searchString` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The search string to query modules.

<a name='ModPosh.TerraformRegistry.Client.SearchModulesAsync(string,System.Nullable_int_,string,System.Nullable_bool_).offset'></a>

`offset` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The offset for pagination.

<a name='ModPosh.TerraformRegistry.Client.SearchModulesAsync(string,System.Nullable_int_,string,System.Nullable_bool_).provider'></a>

`provider` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The provider to filter modules by.

<a name='ModPosh.TerraformRegistry.Client.SearchModulesAsync(string,System.Nullable_int_,string,System.Nullable_bool_).verified'></a>

`verified` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

Whether to filter by verified modules.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[ListModulesResponse](ModPosh.Models.ListModulesResponse.md 'ModPosh.Models.ListModulesResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A [ListModulesResponse](ModPosh.Models.ListModulesResponse.md 'ModPosh.Models.ListModulesResponse') containing the search results.