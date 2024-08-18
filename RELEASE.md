# Version 2.1.0

### Version 2.1.0 Milestone: Enhanced Functionality and Improved Testing Support

This release focuses on further refining the library's capabilities, improving testability, and ensuring better compliance with modern C# practices. The changes in version 2.1.0 build on the foundation established in the previous release, adding new features and resolving issues to enhance the overall user experience.

### Key Updates:

#### 1. **Integration of `IHttpClientFactory`:**
   - **Enhanced Testability:** Introduced `IHttpClientFactory` support within the `Client` class constructors. This change allows for more flexible `HttpClient` management, particularly in unit tests, where mocking the `HttpClient` instance is now straightforward.
   - **Constructor Overload:** Added a new constructor that accepts both `TerraformRegistryConnectionInfo` and `IHttpClientFactory`, providing developers with more control over `HttpClient` creation and lifetime management.

#### 2. **Internal `HttpClient` Property Exposure:**
   - **Internal Access with `[InternalsVisibleTo]`:** Marked the `HttpClient` property as internal, allowing access within the test project while maintaining encapsulation within the library. The `[InternalsVisibleTo("TerraformRegistryClient.Tests")]` attribute was added to facilitate this.
   - **Test Project Improvements:** This change enables comprehensive testing of the `Client` class's internal workings, ensuring that the `HttpClient` is correctly initialized and behaves as expected.

#### 3. **Nullable Reference Types and Improved Null Handling:**
   - **Nullable Annotations:** Applied nullable reference types (`string?`) in the `TerraformRegistryConnectionInfo` class to ensure safer handling of null values, aligning with modern C# practices.
   - **Enhanced Error Handling:** Improved constructors and methods to handle potential null values more gracefully, preventing runtime errors and enhancing overall stability.

### Bug Fixes and Issue Resolutions:

#### 4. **Assertion Method Corrections:**
   - **Resolved NUnit Assertion Errors:** Addressed issues where certain NUnit assertion methods (`IsNotNull`, `AreEqual`) were not recognized due to incorrect casing or usage. Updated tests to use correct assertion methods, ensuring they execute as intended.

#### 5. **Improved Error Messaging:**
   - **Deserialization Error Handling:** Enhanced the `GetAsync<T>` method's error handling by providing more informative exception messages, particularly in cases where JSON deserialization fails or the API response is not as expected.

### Documentation Updates:

#### 6. **Enhanced XML Documentation:**
   - **Comprehensive Coverage:** Expanded XML documentation across the `Client` and `TerraformRegistryConnectionInfo` classes, providing clearer guidance on usage and expected behavior. This documentation supports both developers and consumers of the library, ensuring better understanding and easier integration.

#### 7. **Updated README:**
   - **Reflecting New Features:** The README was updated to reflect the changes introduced in this version, including the new constructor options and the shift to nullable reference types. This ensures that users are aware of the new capabilities and how to leverage them effectively.

### Conclusion:

Version 2.1.0 represents a significant enhancement of the `TerraformRegistryClient` library, focusing on improving testability, stability, and developer experience. These updates lay the groundwork for more robust applications and provide a solid foundation for future enhancements.


## BUG

* issue-10: Improve Error Handling in GetAsync Method
* issue-9: Fix NUnit Assertion Method Issues

## ENHANCEMENT

* issue-8: Add Unit Tests
* issue-7: Implement Nullable Reference Types in TerraformRegistryConnectionInfo
* issue-6: Expose Internal HttpClient Property for Testing
* issue-5: Enhance Testability with IHttpClientFactory Integration

## DOCUMENTATION

* issue-11: Update Documentation

## NO LABEL

* issue-12: V2.1.0

