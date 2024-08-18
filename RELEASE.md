# Version 2.2.0

This release introduces enhancements to the `TerraformRegistryConnectionInfo` class, providing greater flexibility and simplifying usage. The key changes in this version are focused on improving the initialization process of the `TerraformRegistryConnectionInfo` object and updating the related unit tests to reflect these enhancements.

### Key Changes:

### Combined Constructor Logic for `TerraformRegistryConnectionInfo`
- **Enhanced Constructor Behavior:** The `TerraformRegistryConnectionInfo` class now has a single constructor that accepts an optional `baseAddress` parameter. If the `baseAddress` is `null` or not provided, it defaults to the Terraform Registry API's default address (`https://registry.terraform.io/v1/`). This change simplifies the instantiation process and ensures a consistent default behavior without requiring multiple constructors.
  
  - **Previous Behavior:** The class had two constructors: one that required a `baseAddress` and another that provided the default base address. Passing a `null` value to the `baseAddress` parameter would have thrown an `ArgumentNullException`.
  - **Current Behavior:** The class now handles a `null` `baseAddress` gracefully by automatically defaulting to the standard Terraform Registry API base address, reducing the likelihood of errors during instantiation.

### Updated Unit Tests
- **Refactored Test Cases:** The unit tests for the `TerraformRegistryConnectionInfo` class have been updated to align with the new constructor behavior. The test that previously checked for an `ArgumentNullException` when a `null` base address was provided has been replaced with a test that verifies the use of the default base address in this scenario.
  
  - **New Test Scenarios:** 
    - **Default Base Address Usage:** A new test ensures that when `null` is passed or when the constructor is called without parameters, the `TerraformRegistryConnectionInfo` correctly defaults to `https://registry.terraform.io/v1/`.
    - **Custom Base Address:** The test for initializing the connection with a custom base address remains intact, confirming that the class correctly applies the provided value.

### Breaking Changes
- **API Usage Impact:** The changes to the `TerraformRegistryConnectionInfo` constructor are not breaking in terms of API usage, but they do alter the expected behavior when a `null` value is passed. Users who previously relied on the exception being thrown when `null` was provided should update their code to reflect the new default behavior.

### Summary
This milestone continues to build on the improvements from previous versions by simplifying the API, reducing potential points of failure, and ensuring that the `TerraformRegistryConnectionInfo` class is more robust and easier to use. The updated unit tests further ensure that these changes are thoroughly validated, maintaining the library's high standards of reliability and usability.


## ENHANCEMENT

* issue-15: V2.2.0
* issue-14: TerraformRegistryConnectionInfoTests needs to change to account for change in TerraformRegistryConnectionInfo
* issue-13: TerraformRegistryConnectionInfo should default to https://registry.terraform.io/v1/

