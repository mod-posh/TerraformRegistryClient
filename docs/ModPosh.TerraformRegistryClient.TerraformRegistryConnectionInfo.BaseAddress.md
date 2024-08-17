#### [TerraformRegistryClient](index.md 'index')
### [ModPosh.TerraformRegistryClient](ModPosh.TerraformRegistryClient.md 'ModPosh.TerraformRegistryClient').[TerraformRegistryConnectionInfo](ModPosh.TerraformRegistryClient.TerraformRegistryConnectionInfo.md 'ModPosh.TerraformRegistryClient.TerraformRegistryConnectionInfo')

## TerraformRegistryConnectionInfo.BaseAddress Property

Gets or sets the base address of the Terraform Registry API.

```csharp
public string BaseAddress { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The base address as a string, typically in the format of a URL.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Thrown when an attempt is made to set the base address to null.