namespace ModPosh.Models
{
    public class ListModulesResponse
    {
        public List<ListModule> Modules { get; set; } = new List<ListModule>();
        public Meta Meta { get; set; } = new Meta();
    }
    public class ListModuleVersionResponse
    {
        public List<VersionModule> Modules { get; set; } = new List<VersionModule>();
    }
    public class GetModuleResponse : ListModule
    {
        public RootModule Root { get; set; } = new RootModule();
        public List<Submodule> Submodules { get; set; } = new List<Submodule>();
        public List<string> Providers { get; set; } = new List<string>();
        public List<string> Versions { get; set; } = new List<string>();
    }
}