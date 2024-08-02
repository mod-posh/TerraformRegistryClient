namespace ModPosh.Models
{
    /// <summary>
    /// Represents the base structure of a root module, containing dependencies and providers.
    /// </summary>
    public class BaseRoot
    {
        /// <summary>
        /// Gets or sets the list of dependencies for the root module.
        /// </summary>
        public List<object> Dependencies { get; set; } = new List<object>();

        /// <summary>
        /// Gets or sets the list of providers required by the root module.
        /// </summary>
        public List<Provider> Providers { get; set; } = new List<Provider>();
    }

    /// <summary>
    /// Represents the root structure in a search result, extending <see cref="BaseRoot"/> and including submodules.
    /// </summary>
    public class SearchRoot : BaseRoot
    {
        /// <summary>
        /// Gets or sets the list of submodules included in the search result.
        /// </summary>
        public List<SearchSubmodule> Submodules { get; set; } = new List<SearchSubmodule>();
    }

    /// <summary>
    /// Represents the detailed root module structure, extending <see cref="BaseRoot"/> and including inputs, outputs, resources, and other details.
    /// </summary>
    public class RootModule : BaseRoot
    {
        /// <summary>
        /// Gets or sets the path of the root module.
        /// </summary>
        public string Path { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the README content for the root module.
        /// </summary>
        public string Readme { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether the root module is empty.
        /// </summary>
        public bool Empty { get; set; }

        /// <summary>
        /// Gets or sets the list of input variables for the root module.
        /// </summary>
        public List<InputVariable> Inputs { get; set; } = new List<InputVariable>();

        /// <summary>
        /// Gets or sets the list of output variables for the root module.
        /// </summary>
        public List<OutputVariable> Outputs { get; set; } = new List<OutputVariable>();

        /// <summary>
        /// Gets or sets the list of resources associated with the root module.
        /// </summary>
        public List<Resource> Resources { get; set; } = new List<Resource>();
    }
}
