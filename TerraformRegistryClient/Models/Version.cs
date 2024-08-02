using System.Text.Json.Serialization;

namespace ModPosh.Models
{
    public class Version
    {
        [JsonPropertyName("version")]
        [JsonConverter(typeof(VersionJsonConverter))]
        public System.Version VersionNumber { get; set; } = new System.Version();
        public List<SearchSubmodule> Submodules { get; set; } = new List<SearchSubmodule>();
        public SearchRoot Root { get; set; } = new SearchRoot();
        public string Deprecation { get; set; } = string.Empty;
    }
}