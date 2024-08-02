namespace ModPosh.Models
{
    public class Meta
    {
        public int Limit { get; set; }
        public int CurrentOffset { get; set; }
        public int NextOffset { get; set; }
        public string NextUrl { get; set; } = string.Empty;
    }
}