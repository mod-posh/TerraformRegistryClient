# v2.3.0

This milestone focuses on enhancing the usability and robustness of the `TerraformRegistryConnectionInfo` class by addressing a bug related to handling null or empty strings and adding a default constructor for easier usage, particularly in PowerShell environments.

#### Key Changes:

1. **Bug Fix: Handling Null or Empty Strings in ConnectionInfo**
   - **Issue:** The constructor for `TerraformRegistryConnectionInfo` allowed null or empty strings to be passed, which could lead to an unclear or unintended state for the `BaseAddress`.
   - **Resolution:** The constructor now checks if the provided `baseAddress` is null or an empty string and defaults to `"https://registry.terraform.io/v1/"` in such cases. This ensures that the `BaseAddress` is always set to a valid URL.

2. **Feature: Addition of a Default Constructor**
   - **Issue:** PowerShell users often prefer to create instances of objects without passing parameters. The absence of a default constructor made this less intuitive.
   - **Resolution:** A default constructor has been added to the `TerraformRegistryConnectionInfo` class, which automatically sets the `BaseAddress` to `"https://registry.terraform.io/v1/"` without requiring any parameters.

3. **Updates to Unit Tests**
   - **Modification of Existing Tests:**
     - The existing tests have been updated to reflect the changes in how the `baseAddress` is handled, ensuring that null or empty strings are correctly processed.
     - Tests that verify the behavior of the new default constructor have also been added.

#### Summary:

- **Bug Fix:** Proper handling of null or empty strings in `TerraformRegistryConnectionInfo`.
- **New Feature:** Addition of a default constructor for easier instantiation.
- **Test Updates:** Enhanced tests to cover new functionality and ensure robustness.

This milestone provides important quality-of-life improvements for developers, especially those working with PowerShell, and ensures that the `TerraformRegistryClient` remains robust and user-friendly.

## BUG

* issue-16: Bug Fix: Handling Null or Empty Strings in ConnectionInfo

## ENHANCEMENT

* issue-18: Updates to Unit Tests
* issue-17: Addition of a Default Constructor

## NO LABEL

* issue-19: V2.3.0

