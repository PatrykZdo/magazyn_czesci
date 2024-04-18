using CarScrapyardWarehouse.Shared.Models;

namespace CarScrapyardWarehouse.Client.Interfaces
{
    public class PartsData
    {
        public int Id { get; set; }
        public string Part { get; set; }
        public string Magazine { get; set; }
        public string Area { get; set; }
        public string Position { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int? Rocznik { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
