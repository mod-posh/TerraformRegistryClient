namespace ModPosh.TerraformRegistryClient.Models
{
    /// <summary>
    /// Represents a provider used in a Terraform module.
    /// </summary>
    public class Provider
    {
        /// <summary>
        /// Gets or sets the name of the provider.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the namespace of the provider.
        /// </summary>
        public string NameSpace { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the source URL or location of the provider.
        /// </summary>
        public string Source { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the version of the provider.
        /// </summary>
        public string Version { get; set; } = string.Empty;
    }
}
