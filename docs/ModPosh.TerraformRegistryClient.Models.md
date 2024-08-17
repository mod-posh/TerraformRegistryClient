#### [TerraformRegistryClient](index.md 'index')

## ModPosh.TerraformRegistryClient.Models Namespace

| Classes | |
| :--- | :--- |
| [BaseModule](ModPosh.TerraformRegistryClient.Models.BaseModule.md 'ModPosh.TerraformRegistryClient.Models.BaseModule') | Represents the base structure of a module, containing the source URL. |
| [BaseRoot](ModPosh.TerraformRegistryClient.Models.BaseRoot.md 'ModPosh.TerraformRegistryClient.Models.BaseRoot') | Represents the base structure of a root module, containing dependencies and providers. |
| [BaseSubmodule](ModPosh.TerraformRegistryClient.Models.BaseSubmodule.md 'ModPosh.TerraformRegistryClient.Models.BaseSubmodule') | Represents the base structure of a submodule, containing the path and dependencies. |
| [BaseVariable](ModPosh.TerraformRegistryClient.Models.BaseVariable.md 'ModPosh.TerraformRegistryClient.Models.BaseVariable') | Represents the base structure of a variable in a Terraform module, including common properties such as name and description. |
| [GetModuleResponse](ModPosh.TerraformRegistryClient.Models.GetModuleResponse.md 'ModPosh.TerraformRegistryClient.Models.GetModuleResponse') | Represents the detailed response from the Terraform Registry API when retrieving information about a specific module. |
| [InputVariable](ModPosh.TerraformRegistryClient.Models.InputVariable.md 'ModPosh.TerraformRegistryClient.Models.InputVariable') | Represents an input variable in a Terraform module, extending [BaseVariable](ModPosh.TerraformRegistryClient.Models.BaseVariable.md 'ModPosh.TerraformRegistryClient.Models.BaseVariable') and including a default value. |
| [ListModule](ModPosh.TerraformRegistryClient.Models.ListModule.md 'ModPosh.TerraformRegistryClient.Models.ListModule') | Represents a module in the list of modules, including metadata such as ID, owner, namespace, and more. |
| [ListModulesResponse](ModPosh.TerraformRegistryClient.Models.ListModulesResponse.md 'ModPosh.TerraformRegistryClient.Models.ListModulesResponse') | Represents the response from the Terraform Registry API when listing modules. |
| [ListModuleVersionResponse](ModPosh.TerraformRegistryClient.Models.ListModuleVersionResponse.md 'ModPosh.TerraformRegistryClient.Models.ListModuleVersionResponse') | Represents the response from the Terraform Registry API when listing module versions. |
| [Meta](ModPosh.TerraformRegistryClient.Models.Meta.md 'ModPosh.TerraformRegistryClient.Models.Meta') | Represents metadata for pagination and navigation in API responses. |
| [OutputVariable](ModPosh.TerraformRegistryClient.Models.OutputVariable.md 'ModPosh.TerraformRegistryClient.Models.OutputVariable') | Represents an output variable in a Terraform module, extending [BaseVariable](ModPosh.TerraformRegistryClient.Models.BaseVariable.md 'ModPosh.TerraformRegistryClient.Models.BaseVariable'). |
| [Provider](ModPosh.TerraformRegistryClient.Models.Provider.md 'ModPosh.TerraformRegistryClient.Models.Provider') | Represents a provider used in a Terraform module. |
| [Resource](ModPosh.TerraformRegistryClient.Models.Resource.md 'ModPosh.TerraformRegistryClient.Models.Resource') | Represents a resource used in a Terraform module. |
| [RootModule](ModPosh.TerraformRegistryClient.Models.RootModule.md 'ModPosh.TerraformRegistryClient.Models.RootModule') | Represents the detailed root module structure, extending [BaseRoot](ModPosh.TerraformRegistryClient.Models.BaseRoot.md 'ModPosh.TerraformRegistryClient.Models.BaseRoot') and including inputs, outputs, resources, and other details. |
| [SearchRoot](ModPosh.TerraformRegistryClient.Models.SearchRoot.md 'ModPosh.TerraformRegistryClient.Models.SearchRoot') | Represents the root structure in a search result, extending [BaseRoot](ModPosh.TerraformRegistryClient.Models.BaseRoot.md 'ModPosh.TerraformRegistryClient.Models.BaseRoot') and including submodules. |
| [SearchSubmodule](ModPosh.TerraformRegistryClient.Models.SearchSubmodule.md 'ModPosh.TerraformRegistryClient.Models.SearchSubmodule') | Represents a submodule that includes providers and extends [BaseSubmodule](ModPosh.TerraformRegistryClient.Models.BaseSubmodule.md 'ModPosh.TerraformRegistryClient.Models.BaseSubmodule'). |
| [Submodule](ModPosh.TerraformRegistryClient.Models.Submodule.md 'ModPosh.TerraformRegistryClient.Models.Submodule') | Represents a detailed submodule, including inputs, outputs, resources, and other details. |
| [Version](ModPosh.TerraformRegistryClient.Models.Version.md 'ModPosh.TerraformRegistryClient.Models.Version') | Represents a version of a Terraform module, including its version number, submodules, root module, and deprecation status. |
| [VersionModule](ModPosh.TerraformRegistryClient.Models.VersionModule.md 'ModPosh.TerraformRegistryClient.Models.VersionModule') | Represents a module version, including the source URL and available versions. |
