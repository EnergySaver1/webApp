namespace WebApplication1.Models
{
    public class SparePart
    {
        private int? _id;
        private string? _type;
        private string? _manufacturer;
        private decimal? _price;
        private int? _order_id;
        private bool? _available;

        public SparePart()
        {
        }

        public SparePart(int id, string type, string manufacturer, decimal price, int order_id, bool available)
        {
            Id = id;
            Type = type;
            Manufacturer = manufacturer;
            Price = price;
            Order_id = order_id;
            Available = available;
        }

        public int? Id { get => _id; set => _id = value; }
        public string? Type { get => _type; set => _type = value; }
        public string? Manufacturer { get => _manufacturer; set => _manufacturer = value; }
        public decimal? Price { get => _price; set => _price = value; }
        public int? Order_id { get => _order_id; set => _order_id = value; }
        public bool? Available { get => _available; set => _available = value; }
    }
}
