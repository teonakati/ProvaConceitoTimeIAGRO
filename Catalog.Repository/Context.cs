using Catalog.Domain.Helper;
using Catalog.Domain.Models;
using System.Text.Json;

namespace Catalog.Repository
{
    public class Context
    {
        public List<Book> Books { get; private set; }

        public Context()
        {
            MapJson(string.Format("{0}/Json/books.json", Directory.GetCurrentDirectory()));
        }

        public Context(string jsonPath)
        {
            MapJson(jsonPath);
        }

        void MapJson(string jsonPath)
        {
            var json = File.ReadAllText(jsonPath);

            var settings = new JsonSerializerOptions();
            settings.Converters.Add(new DateTimeConverter());
            settings.Converters.Add(new ArrayStringConverter());

            Books = JsonSerializer.Deserialize<List<Book>>(json, settings);
        }
    }
}
