namespace Catalog.Service.DTO
{
    public class BookFilterDTO
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }
        public string? Ordering { get; set; }
        public SpecificationDTO? Specifications { get; set; }
    }
}
