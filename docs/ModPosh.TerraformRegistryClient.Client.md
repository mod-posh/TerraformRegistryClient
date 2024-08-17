#### [TerraformRegistryClient](index.md 'index')
### [ModPosh.TerraformRegistryClient](ModPosh.TerraformRegistryClient.md 'ModPosh.TerraformRegistryClient')

## Client Class

Client for interacting with the Terraform Registry API.

```csharp
public class Client
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Client

| Constructors | |
| :--- | :--- |
| [Client(TerraformRegistryConnectionInfo)](ModPosh.TerraformRegistryClient.Client.Client(ModPosh.TerraformRegistryClient.TerraformRegistryConnectionInfo).md 'ModPosh.TerraformRegistryClient.Client.Client(ModPosh.TerraformRegistryClient.TerraformRegistryConnectionInfo)') | Initializes a new instance of the [Client](ModPosh.TerraformRegistryClient.Client.md 'ModPosh.TerraformRegistryClient.Client') class with the default base address. |
| [Client(string)](ModPosh.TerraformRegistryClient.Client.Client(string).md 'ModPosh.TerraformRegistryClient.Client.Client(string)') | Initializes a new instance of the [Client](ModPosh.TerraformRegistryClient.Client.md 'ModPosh.TerraformRegistryClient.Client') class with a specified base address. |

| Methods | |
| :--- | :--- |
| [GetAsync&lt;T&gt;(string)](ModPosh.TerraformRegistryClient.Client.GetAsync_T_(string).md 'ModPosh.TerraformRegistryClient.Client.GetAsync<T>(string)') | Sends a GET request to the specified URL and deserializes the JSON response to a specified type. |
| [GetModuleAsync(string, string, string, string)](ModPosh.TerraformRegistryClient.Client.GetModuleAsync(string,string,string,string).md 'ModPosh.TerraformRegistryClient.Client.GetModuleAsync(string, string, string, string)') | Retrieves detailed information about a specific version of a module. |
| [GetModuleAsync(string, string, string)](ModPosh.TerraformRegistryClient.Client.GetModuleAsync(string,string,string).md 'ModPosh.TerraformRegistryClient.Client.GetModuleAsync(string, string, string)') | Retrieves detailed information about a specific module. |
| [ListLatestVersionModuleProviderAsync(string, string, Nullable&lt;int&gt;)](ModPosh.TerraformRegistryClient.Client.ListLatestVersionModuleProviderAsync(string,string,System.Nullable_int_).md 'ModPosh.TerraformRegistryClient.Client.ListLatestVersionModuleProviderAsync(string, string, System.Nullable<int>)') | Lists the latest version of a module provider. |
| [ListModulesAsync(string, Nullable&lt;int&gt;, string, Nullable&lt;bool&gt;)](ModPosh.TerraformRegistryClient.Client.ListModulesAsync(string,System.Nullable_int_,string,System.Nullable_bool_).md 'ModPosh.TerraformRegistryClient.Client.ListModulesAsync(string, System.Nullable<int>, string, System.Nullable<bool>)') | Lists modules available in the Terraform Registry. |
| [ListModuleVersionAsync(string, string, string)](ModPosh.TerraformRegistryClient.Client.ListModuleVersionAsync(string,string,string).md 'ModPosh.TerraformRegistryClient.Client.ListModuleVersionAsync(string, string, string)') | Lists the versions of a specific module available in the Terraform Registry. |
| [SearchModulesAsync(string, Nullable&lt;int&gt;, string, Nullable&lt;bool&gt;)](ModPosh.TerraformRegistryClient.Client.SearchModulesAsync(string,System.Nullable_int_,string,System.Nullable_bool_).md 'ModPosh.TerraformRegistryClient.Client.SearchModulesAsync(string, System.Nullable<int>, string, System.Nullable<bool>)') | Searches for modules in the Terraform Registry. |
