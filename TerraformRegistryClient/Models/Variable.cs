namespace ModPosh.Models
{
    public class BaseVariable
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
    public class InputVariable : BaseVariable
    {
        public string Default { get; set; } = string.Empty;
    }
    public class OutputVariable : BaseVariable
    {
    }
}