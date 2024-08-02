namespace ModPosh.Models
{
    /// <summary>
    /// Represents metadata for pagination and navigation in API responses.
    /// </summary>
    public class Meta
    {
        /// <summary>
        /// Gets or sets the limit of items per page.
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Gets or sets the current offset of the items being fetched.
        /// </summary>
        public int CurrentOffset { get; set; }

        /// <summary>
        /// Gets or sets the offset for the next set of items to be fetched.
        /// </summary>
        public int NextOffset { get; set; }

        /// <summary>
        /// Gets or sets the URL for fetching the next set of items.
        /// </summary>
        public string NextUrl { get; set; } = string.Empty;
    }
}
