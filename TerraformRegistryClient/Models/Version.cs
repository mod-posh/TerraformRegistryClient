using System.Text.Json.Serialization;

namespace ModPosh.Models
{
    /// <summary>
    /// Represents a version of a Terraform module, including its version number, submodules, root module, and deprecation status.
    /// </summary>
    public class Version
    {
        /// <summary>
        /// Gets or sets the version number of the Terraform module.
        /// </summary>
        [JsonPropertyName("version")]
        [JsonConverter(typeof(VersionJsonConverter))]
        public System.Version VersionNumber { get; set; } = new System.Version();

        /// <summary>
        /// Gets or sets the list of submodules associated with this version of the Terraform module.
        /// </summary>
        public List<SearchSubmodule> Submodules { get; set; } = new List<SearchSubmodule>();

        /// <summary>
        /// Gets or sets the root module configuration for this version of the Terraform module.
        /// </summary>
        public SearchRoot Root { get; set; } = new SearchRoot();

        /// <summary>
        /// Gets or sets the deprecation status or message for this version of the Terraform module.
        /// </summary>
        public string Deprecation { get; set; } = string.Empty;
    }
}
