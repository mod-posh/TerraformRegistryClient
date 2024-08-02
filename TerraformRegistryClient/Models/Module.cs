namespace ModPosh.Models
{
    public class BaseModule
    {
        public string Source { get; set; } = string.Empty;
    }
    public class BaseSubmodule
    {
        public string Path { get; set; } = string.Empty;
        public List<object> Dependencies { get; set; } = new List<object>();
    }
    public class SearchSubmodule : BaseSubmodule
    {
        public List<Provider> Providers { get; set; } = new List<Provider>();
    }
    public class Submodule : BaseSubmodule
    {
        public string Readme { get; set; } = string.Empty;
        public bool Empty { get; set; }
        public List<InputVariable> Inputs { get; set; } = new List<InputVariable>();
        public List<OutputVariable> Outputs { get; set; } = new List<OutputVariable>();
        public List<Resource> Resources { get; set; } = new List<Resource>();
    }
    public class VersionModule
    {
        public string Source { get; set; } = string.Empty;
        public List<Version> Versions { get; set; } = new List<Version>();
    }
    public class ListModule : BaseModule
    {
        public string Id { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
        public string Namespace { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public string Provider { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime PublishedAt { get; set; }
        public int Downloads { get; set; }
        public bool Verified { get; set; }
    }
}