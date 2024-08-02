#### [TerraformRegistryClient](index.md 'index')

## ModPosh.Models Namespace

| Classes | |
| :--- | :--- |
| [BaseModule](ModPosh.Models.BaseModule.md 'ModPosh.Models.BaseModule') | Represents the base structure of a module, containing the source URL. |
| [BaseRoot](ModPosh.Models.BaseRoot.md 'ModPosh.Models.BaseRoot') | Represents the base structure of a root module, containing dependencies and providers. |
| [BaseSubmodule](ModPosh.Models.BaseSubmodule.md 'ModPosh.Models.BaseSubmodule') | Represents the base structure of a submodule, containing the path and dependencies. |
| [BaseVariable](ModPosh.Models.BaseVariable.md 'ModPosh.Models.BaseVariable') | Represents the base structure of a variable in a Terraform module, including common properties such as name and description. |
| [GetModuleResponse](ModPosh.Models.GetModuleResponse.md 'ModPosh.Models.GetModuleResponse') | Represents the detailed response from the Terraform Registry API when retrieving information about a specific module. |
| [InputVariable](ModPosh.Models.InputVariable.md 'ModPosh.Models.InputVariable') | Represents an input variable in a Terraform module, extending [BaseVariable](ModPosh.Models.BaseVariable.md 'ModPosh.Models.BaseVariable') and including a default value. |
| [ListModule](ModPosh.Models.ListModule.md 'ModPosh.Models.ListModule') | Represents a module in the list of modules, including metadata such as ID, owner, namespace, and more. |
| [ListModulesResponse](ModPosh.Models.ListModulesResponse.md 'ModPosh.Models.ListModulesResponse') | Represents the response from the Terraform Registry API when listing modules. |
| [ListModuleVersionResponse](ModPosh.Models.ListModuleVersionResponse.md 'ModPosh.Models.ListModuleVersionResponse') | Represents the response from the Terraform Registry API when listing module versions. |
| [Meta](ModPosh.Models.Meta.md 'ModPosh.Models.Meta') | Represents metadata for pagination and navigation in API responses. |
| [OutputVariable](ModPosh.Models.OutputVariable.md 'ModPosh.Models.OutputVariable') | Represents an output variable in a Terraform module, extending [BaseVariable](ModPosh.Models.BaseVariable.md 'ModPosh.Models.BaseVariable'). |
| [Provider](ModPosh.Models.Provider.md 'ModPosh.Models.Provider') | Represents a provider used in a Terraform module. |
| [Resource](ModPosh.Models.Resource.md 'ModPosh.Models.Resource') | Represents a resource used in a Terraform module. |
| [RootModule](ModPosh.Models.RootModule.md 'ModPosh.Models.RootModule') | Represents the detailed root module structure, extending [BaseRoot](ModPosh.Models.BaseRoot.md 'ModPosh.Models.BaseRoot') and including inputs, outputs, resources, and other details. |
| [SearchRoot](ModPosh.Models.SearchRoot.md 'ModPosh.Models.SearchRoot') | Represents the root structure in a search result, extending [BaseRoot](ModPosh.Models.BaseRoot.md 'ModPosh.Models.BaseRoot') and including submodules. |
| [SearchSubmodule](ModPosh.Models.SearchSubmodule.md 'ModPosh.Models.SearchSubmodule') | Represents a submodule that includes providers and extends [BaseSubmodule](ModPosh.Models.BaseSubmodule.md 'ModPosh.Models.BaseSubmodule'). |
| [Submodule](ModPosh.Models.Submodule.md 'ModPosh.Models.Submodule') | Represents a detailed submodule, including inputs, outputs, resources, and other details. |
| [Version](ModPosh.Models.Version.md 'ModPosh.Models.Version') | Represents a version of a Terraform module, including its version number, submodules, root module, and deprecation status. |
| [VersionModule](ModPosh.Models.VersionModule.md 'ModPosh.Models.VersionModule') | Represents a module version, including the source URL and available versions. |
