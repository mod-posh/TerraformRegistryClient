# Version 2.0.0

This release marks a significant update from previous versions, introducing several key changes that enhance both the flexibility and usability of the library.

### Namespace Change:
- **Updated Namespace:** The namespace has been changed from `ModPosh.TerraformRegistry` to `ModPosh.TerraformRegistryClient`. This update is intended to avoid potential conflicts with an upcoming PowerShell module that is currently in development. By renaming the namespace, we ensure clear separation between the core library and the PowerShell module, enabling smoother integration and usage across different projects.

### Introduction of `TerraformRegistryConnectionInfo` Object:
- **ConnectionInfo Object:** To streamline the process of establishing connections to the Terraform Registry API, this release introduces the `TerraformRegistryConnectionInfo` object. This object encapsulates connection-related details, such as the base API URL, allowing for a more modular and flexible configuration. The `TerraformRegistryConnectionInfo` object is now required when initializing the `Client` class, making it easier to manage and reuse connection settings across different instances and environments.

### Breaking Changes:
- **Impact on Existing Code:** Due to the namespace change and the introduction of the `TerraformRegistryConnectionInfo` object, existing codebases that rely on previous versions of this library will need to be updated. Specifically:
  - Update any references from `ModPosh.TerraformRegistry` to `ModPosh.TerraformRegistryClient`.
  - Modify client initialization to use the new `TerraformRegistryConnectionInfo` object.

These changes are designed to provide a more robust and maintainable foundation for future development, ensuring that the library remains flexible and easy to integrate into a wide range of applications, including the forthcoming PowerShell module.

## BUG

* issue-1: Namespace Conflict

## ENHANCEMENT, WONTFIX

* issue-3: Implement Logger

## DOCUMENTATION

* issue-4: Update Documentation

## ENHANCEMENT

* issue-2: Implement a ConnectionInfo object

