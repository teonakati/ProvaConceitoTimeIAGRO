using System.Text.Json;
using System.Text.Json.Serialization;

namespace Catalog.Domain.Helper
{
    public class DateTimeConverter : JsonConverter<DateTime>
    {
        private Dictionary<string, int> _monthNumber = new Dictionary<string, int>
        {
            {"January" , 1},
            {"February" , 2},
            {"March" , 3},
            {"April" , 4},
            {"May" , 5},
            {"June" , 6},
            {"July" , 7},
            {"August" , 8},
            {"September", 9},
            {"October" , 10},
            {"November" , 11},
            {"December" , 12}
        };
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert == typeof(DateTime);
        }

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var stringDate = reader.GetString()?.Replace(",", string.Empty);
            var dateInfo = stringDate?.Split(" ");
            try
            {
                var month = Convert.ToInt32(_monthNumber[dateInfo[0]]);
                var day = Convert.ToInt32(dateInfo[1]);
                var year = Convert.ToInt32(dateInfo[2]);

                return new DateTime(year, month, day);
            }
            catch (Exception)
            {

                throw new Exception("Formato de data inválido.");
            }
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
