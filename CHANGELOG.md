# Changelog

All changes to this project should be reflected in this document.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/), and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [[1.0.0.0]](https://github.com/mod-posh/TerraformRegistryClient/releases/tag/v1.0.0.0) - 2024-08-02

The `TerraformRegistryClient` is a C# library designed to interact with the Terraform Registry API. It provides an easy-to-use interface for accessing various resources within the Terraform Registry, allowing developers to automate and manage their Terraform modules efficiently.

### Key Features

- **Module Listing**: Retrieve a list of Terraform modules available in the registry.
- **Module Searching**: Search for specific modules using keywords.
- **Version Listing**: Fetch a list of available versions for a specific module.
- **Module Details**: Retrieve detailed information about a specific module, including its inputs, outputs, and dependencies.

### Supported Endpoints

- **List Modules**:
  - Fetch a list of Terraform modules, optionally filtered by namespace, provider, or verification status.

- **Search Modules**:
  - Search for modules in the Terraform Registry using a query string.

- **List Module Versions**:
  - Retrieve all versions available for a specific Terraform module.

- **Get Module Details**:
  - Obtain detailed information about a specific module, including its root configuration, submodules, and provider details.

- **Get Specific Module Version Details**:
  - Retrieve detailed information for a specific version of a Terraform module.

### Use Cases

- Automating the retrieval and management of Terraform modules.
- Integrating Terraform Registry data into CI/CD pipelines.
- Enhancing infrastructure as code (IaC) workflows by programmatically interacting with the Terraform Registry.

---
