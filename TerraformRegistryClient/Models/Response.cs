namespace ModPosh.Models
{
    /// <summary>
    /// Represents the response from the Terraform Registry API when listing modules.
    /// </summary>
    public class ListModulesResponse
    {
        /// <summary>
        /// Gets or sets the list of modules returned in the response.
        /// </summary>
        public List<ListModule> Modules { get; set; } = new List<ListModule>();

        /// <summary>
        /// Gets or sets the metadata associated with the response, including pagination details.
        /// </summary>
        public Meta Meta { get; set; } = new Meta();
    }

    /// <summary>
    /// Represents the response from the Terraform Registry API when listing module versions.
    /// </summary>
    public class ListModuleVersionResponse
    {
        /// <summary>
        /// Gets or sets the list of modules with their versions returned in the response.
        /// </summary>
        public List<VersionModule> Modules { get; set; } = new List<VersionModule>();
    }

    /// <summary>
    /// Represents the detailed response from the Terraform Registry API when retrieving information about a specific module.
    /// </summary>
    public class GetModuleResponse : ListModule
    {
        /// <summary>
        /// Gets or sets the root module containing the main configuration details.
        /// </summary>
        public RootModule Root { get; set; } = new RootModule();

        /// <summary>
        /// Gets or sets the list of submodules included in the module.
        /// </summary>
        public List<Submodule> Submodules { get; set; } = new List<Submodule>();

        /// <summary>
        /// Gets or sets the list of providers required by the module.
        /// </summary>
        public List<string> Providers { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the list of available versions for the module.
        /// </summary>
        public List<string> Versions { get; set; } = new List<string>();
    }
}
