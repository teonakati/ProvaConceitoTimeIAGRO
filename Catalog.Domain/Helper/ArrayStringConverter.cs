using System.Text.Json;
using System.Text.Json.Serialization;

namespace Catalog.Domain.Helper
{
    public class ArrayStringConverter : JsonConverter<string[]>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert == typeof(string[]);
        }

        public override string[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
                return new string[] { reader.GetString() };

            var stringList = new List<string>();
            while(reader.Read() && reader.TokenType != JsonTokenType.EndArray)
            {
                stringList.Add(reader.GetString());
            }

            return stringList.ToArray();
        }

        public override void Write(Utf8JsonWriter writer, string[] value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
