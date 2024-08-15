namespace ModPosh.TerraformRegistryClient.Models
{
    /// <summary>
    /// Represents the base structure of a module, containing the source URL.
    /// </summary>
    public class BaseModule
    {
        /// <summary>
        /// Gets or sets the source URL of the module.
        /// </summary>
        public string Source { get; set; } = string.Empty;
    }

    /// <summary>
    /// Represents the base structure of a submodule, containing the path and dependencies.
    /// </summary>
    public class BaseSubmodule
    {
        /// <summary>
        /// Gets or sets the path of the submodule.
        /// </summary>
        public string Path { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the list of dependencies for the submodule.
        /// </summary>
        public List<object> Dependencies { get; set; } = new List<object>();
    }

    /// <summary>
    /// Represents a submodule that includes providers and extends <see cref="BaseSubmodule"/>.
    /// </summary>
    public class SearchSubmodule : BaseSubmodule
    {
        /// <summary>
        /// Gets or sets the list of providers required by the submodule.
        /// </summary>
        public List<Provider> Providers { get; set; } = new List<Provider>();
    }

    /// <summary>
    /// Represents a detailed submodule, including inputs, outputs, resources, and other details.
    /// </summary>
    public class Submodule : BaseSubmodule
    {
        /// <summary>
        /// Gets or sets the README content for the submodule.
        /// </summary>
        public string Readme { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether the submodule is empty.
        /// </summary>
        public bool Empty { get; set; }

        /// <summary>
        /// Gets or sets the list of input variables for the submodule.
        /// </summary>
        public List<InputVariable> Inputs { get; set; } = new List<InputVariable>();

        /// <summary>
        /// Gets or sets the list of output variables for the submodule.
        /// </summary>
        public List<OutputVariable> Outputs { get; set; } = new List<OutputVariable>();

        /// <summary>
        /// Gets or sets the list of resources associated with the submodule.
        /// </summary>
        public List<Resource> Resources { get; set; } = new List<Resource>();
    }

    /// <summary>
    /// Represents a module version, including the source URL and available versions.
    /// </summary>
    public class VersionModule
    {
        /// <summary>
        /// Gets or sets the source URL of the module version.
        /// </summary>
        public string Source { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the list of available versions for the module.
        /// </summary>
        public List<Version> Versions { get; set; } = new List<Version>();
    }

    /// <summary>
    /// Represents a module in the list of modules, including metadata such as ID, owner, namespace, and more.
    /// </summary>
    public class ListModule : BaseModule
    {
        /// <summary>
        /// Gets or sets the unique identifier of the module.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the owner of the module.
        /// </summary>
        public string Owner { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the namespace of the module.
        /// </summary>
        public string Namespace { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of the module.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the version of the module.
        /// </summary>
        public string Version { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the provider of the module.
        /// </summary>
        public string Provider { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the module.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the publication date and time of the module.
        /// </summary>
        public DateTime PublishedAt { get; set; }

        /// <summary>
        /// Gets or sets the number of downloads of the module.
        /// </summary>
        public int Downloads { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the module is verified.
        /// </summary>
        public bool Verified { get; set; }
    }
}
