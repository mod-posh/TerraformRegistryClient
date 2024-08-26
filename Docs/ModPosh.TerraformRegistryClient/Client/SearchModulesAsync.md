# Client.SearchModulesAsync method

Searches for modules in the Terraform Registry.

```csharp
public Task<ListModulesResponse> SearchModulesAsync(string searchString, int? offset = null, 
    string? provider = null, bool? verified = null)
```

| parameter | description |
| --- | --- |
| searchString | The search string to query modules. |
| offset | The offset for pagination. |
| provider | The provider to filter modules by. |
| verified | Whether to filter by verified modules. |

## Return Value

A [`ListModulesResponse`](../../ModPosh.TerraformRegistryClient.Models/ListModulesResponse.md) containing the search results.

## See Also

* class [ListModulesResponse](../../ModPosh.TerraformRegistryClient.Models/ListModulesResponse.md)
* class [Client](../Client.md)
* namespace [ModPosh.TerraformRegistryClient](../Client.md.md)
* assembly [TerraformRegistryClient](../../TerraformRegistryClient.md)

<!-- DO NOT EDIT: generated by xmldocmd for TerraformRegistryClient.dll -->