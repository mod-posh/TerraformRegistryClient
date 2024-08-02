namespace ModPosh.Models
{
    public class BaseRoot
    {
        public List<object> Dependencies { get; set; } = new List<object>();
        public List<Provider> Providers { get; set; } = new List<Provider>();
    }
    public class SearchRoot : BaseRoot
    {
        public List<SearchSubmodule> Submodules { get; set; } = new List<SearchSubmodule>();
    }
    public class RootModule : BaseRoot
    {
        public string Path { get; set; } = string.Empty;
        public string Readme { get; set; } = string.Empty;
        public bool Empty { get; set; }
        public List<InputVariable> Inputs { get; set; } = new List<InputVariable>();
        public List<OutputVariable> Outputs { get; set; } = new List<OutputVariable>();
        public List<Resource> Resources { get; set; } = new List<Resource>();
    }
}