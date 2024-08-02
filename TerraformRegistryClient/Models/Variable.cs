namespace ModPosh.Models
{
    /// <summary>
    /// Represents the base structure of a variable in a Terraform module, including common properties such as name and description.
    /// </summary>
    public class BaseVariable
    {
        /// <summary>
        /// Gets or sets the name of the variable.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the variable.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }

    /// <summary>
    /// Represents an input variable in a Terraform module, extending <see cref="BaseVariable"/> and including a default value.
    /// </summary>
    public class InputVariable : BaseVariable
    {
        /// <summary>
        /// Gets or sets the default value of the input variable.
        /// </summary>
        public string Default { get; set; } = string.Empty;
    }

    /// <summary>
    /// Represents an output variable in a Terraform module, extending <see cref="BaseVariable"/>.
    /// </summary>
    public class OutputVariable : BaseVariable
    {
        // Output variables in Terraform typically don't have additional properties beyond those in BaseVariable.
    }
}
