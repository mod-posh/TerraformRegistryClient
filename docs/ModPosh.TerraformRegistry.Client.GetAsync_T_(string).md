#### [TerraformRegistryClient](index.md 'index')
### [ModPosh.TerraformRegistry](ModPosh.TerraformRegistry.md 'ModPosh.TerraformRegistry').[Client](ModPosh.TerraformRegistry.Client.md 'ModPosh.TerraformRegistry.Client')

## Client.GetAsync<T>(string) Method

Sends a GET request to the specified URL and deserializes the JSON response to a specified type.

```csharp
private System.Threading.Tasks.Task<T> GetAsync<T>(string url);
```
#### Type parameters

<a name='ModPosh.TerraformRegistry.Client.GetAsync_T_(string).T'></a>

`T`

The type to which the JSON response will be deserialized.
#### Parameters

<a name='ModPosh.TerraformRegistry.Client.GetAsync_T_(string).url'></a>

`url` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The URL to send the GET request to.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](ModPosh.TerraformRegistry.Client.GetAsync_T_(string).md#ModPosh.TerraformRegistry.Client.GetAsync_T_(string).T 'ModPosh.TerraformRegistry.Client.GetAsync<T>(string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The deserialized response of type [T](ModPosh.TerraformRegistry.Client.GetAsync_T_(string).md#ModPosh.TerraformRegistry.Client.GetAsync_T_(string).T 'ModPosh.TerraformRegistry.Client.GetAsync<T>(string).T').

#### Exceptions

[System.Net.Http.HttpRequestException](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException')  
Thrown when the HTTP request fails.

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Thrown when deserialization fails or returns null.