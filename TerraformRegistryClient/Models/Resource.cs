namespace ModPosh.Models
{
    /// <summary>
    /// Represents a resource used in a Terraform module.
    /// </summary>
    public class Resource
    {
        /// <summary>
        /// Gets or sets the name of the resource.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the type of the resource.
        /// </summary>
        public string Type { get; set; } = string.Empty;
    }
}
