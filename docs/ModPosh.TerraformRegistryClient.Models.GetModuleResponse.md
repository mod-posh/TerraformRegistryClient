#### [TerraformRegistryClient](index.md 'index')
### [ModPosh.TerraformRegistryClient.Models](ModPosh.TerraformRegistryClient.Models.md 'ModPosh.TerraformRegistryClient.Models')

## GetModuleResponse Class

Represents the detailed response from the Terraform Registry API when retrieving information about a specific module.

```csharp
public class GetModuleResponse : ModPosh.TerraformRegistryClient.Models.ListModule
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [BaseModule](ModPosh.TerraformRegistryClient.Models.BaseModule.md 'ModPosh.TerraformRegistryClient.Models.BaseModule') &#129106; [ListModule](ModPosh.TerraformRegistryClient.Models.ListModule.md 'ModPosh.TerraformRegistryClient.Models.ListModule') &#129106; GetModuleResponse

| Properties | |
| :--- | :--- |
| [Providers](ModPosh.TerraformRegistryClient.Models.GetModuleResponse.Providers.md 'ModPosh.TerraformRegistryClient.Models.GetModuleResponse.Providers') | Gets or sets the list of providers required by the module. |
| [Root](ModPosh.TerraformRegistryClient.Models.GetModuleResponse.Root.md 'ModPosh.TerraformRegistryClient.Models.GetModuleResponse.Root') | Gets or sets the root module containing the main configuration details. |
| [Submodules](ModPosh.TerraformRegistryClient.Models.GetModuleResponse.Submodules.md 'ModPosh.TerraformRegistryClient.Models.GetModuleResponse.Submodules') | Gets or sets the list of submodules included in the module. |
| [Versions](ModPosh.TerraformRegistryClient.Models.GetModuleResponse.Versions.md 'ModPosh.TerraformRegistryClient.Models.GetModuleResponse.Versions') | Gets or sets the list of available versions for the module. |
