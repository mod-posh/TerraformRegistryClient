#### [TerraformRegistryClient](index.md 'index')
### [ModPosh.TerraformRegistryClient](ModPosh.TerraformRegistryClient.md 'ModPosh.TerraformRegistryClient').[Client](ModPosh.TerraformRegistryClient.Client.md 'ModPosh.TerraformRegistryClient.Client')

## Client(string) Constructor

Initializes a new instance of the [Client](ModPosh.TerraformRegistryClient.Client.md 'ModPosh.TerraformRegistryClient.Client') class with a specified base address.

```csharp
public Client(string? baseAddress=null);
```
#### Parameters

<a name='ModPosh.TerraformRegistryClient.Client.Client(string).baseAddress'></a>

`baseAddress` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The base address of the Terraform Registry API. If null, defaults to "https://registry.terraform.io/v1/".