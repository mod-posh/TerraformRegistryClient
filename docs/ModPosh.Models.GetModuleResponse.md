#### [TerraformRegistryClient](index.md 'index')
### [ModPosh.Models](ModPosh.Models.md 'ModPosh.Models')

## GetModuleResponse Class

Represents the detailed response from the Terraform Registry API when retrieving information about a specific module.

```csharp
public class GetModuleResponse : ModPosh.Models.ListModule
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [BaseModule](ModPosh.Models.BaseModule.md 'ModPosh.Models.BaseModule') &#129106; [ListModule](ModPosh.Models.ListModule.md 'ModPosh.Models.ListModule') &#129106; GetModuleResponse

| Properties | |
| :--- | :--- |
| [Providers](ModPosh.Models.GetModuleResponse.Providers.md 'ModPosh.Models.GetModuleResponse.Providers') | Gets or sets the list of providers required by the module. |
| [Root](ModPosh.Models.GetModuleResponse.Root.md 'ModPosh.Models.GetModuleResponse.Root') | Gets or sets the root module containing the main configuration details. |
| [Submodules](ModPosh.Models.GetModuleResponse.Submodules.md 'ModPosh.Models.GetModuleResponse.Submodules') | Gets or sets the list of submodules included in the module. |
| [Versions](ModPosh.Models.GetModuleResponse.Versions.md 'ModPosh.Models.GetModuleResponse.Versions') | Gets or sets the list of available versions for the module. |
