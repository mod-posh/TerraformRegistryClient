using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
/// A custom JSON converter for <see cref="System.Version"/> objects.
/// </summary>
public class VersionJsonConverter : JsonConverter<Version>
{
    /// <summary>
    /// Reads and converts the JSON to a <see cref="System.Version"/> object.
    /// </summary>
    /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
    /// <param name="typeToConvert">The type of the object to convert.</param>
    /// <param name="options">Options to control the conversion behavior.</param>
    /// <returns>A <see cref="System.Version"/> object converted from the JSON string.</returns>
    public override Version Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var versionString = reader.GetString();
        return versionString != null ? new Version(versionString) : new Version(0, 0);
    }

    /// <summary>
    /// Writes a <see cref="System.Version"/> object as a JSON string.
    /// </summary>
    /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
    /// <param name="value">The <see cref="System.Version"/> object to write.</param>
    /// <param name="options">Options to control the conversion behavior.</param>
    public override void Write(Utf8JsonWriter writer, Version value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value?.ToString());
    }
}
