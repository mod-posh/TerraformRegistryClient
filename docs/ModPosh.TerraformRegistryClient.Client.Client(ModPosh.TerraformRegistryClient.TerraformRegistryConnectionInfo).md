#### [TerraformRegistryClient](index.md 'index')
### [ModPosh.TerraformRegistryClient](ModPosh.TerraformRegistryClient.md 'ModPosh.TerraformRegistryClient').[Client](ModPosh.TerraformRegistryClient.Client.md 'ModPosh.TerraformRegistryClient.Client')

## Client(TerraformRegistryConnectionInfo) Constructor

Initializes a new instance of the [Client](ModPosh.TerraformRegistryClient.Client.md 'ModPosh.TerraformRegistryClient.Client') class with the default base address.

```csharp
public Client(ModPosh.TerraformRegistryClient.TerraformRegistryConnectionInfo connectionInfo);
```
#### Parameters

<a name='ModPosh.TerraformRegistryClient.Client.Client(ModPosh.TerraformRegistryClient.TerraformRegistryConnectionInfo).connectionInfo'></a>

`connectionInfo` [TerraformRegistryConnectionInfo](ModPosh.TerraformRegistryClient.TerraformRegistryConnectionInfo.md 'ModPosh.TerraformRegistryClient.TerraformRegistryConnectionInfo')

The connection information required to connect to the Terraform Registry API.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Thrown when [connectionInfo](ModPosh.TerraformRegistryClient.Client.Client(ModPosh.TerraformRegistryClient.TerraformRegistryConnectionInfo).md#ModPosh.TerraformRegistryClient.Client.Client(ModPosh.TerraformRegistryClient.TerraformRegistryConnectionInfo).connectionInfo 'ModPosh.TerraformRegistryClient.Client.Client(ModPosh.TerraformRegistryClient.TerraformRegistryConnectionInfo).connectionInfo') is null.