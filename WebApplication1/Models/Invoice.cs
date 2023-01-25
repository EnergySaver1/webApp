namespace WebApplication1.Models
{
    public class Invoice
    {
        private int _Id;
        private DateTime? _date;
        private int? _order_id;
        private decimal? _price;
        private string? _description;

        public Invoice()
        {
        }

        public Invoice(int id, DateTime date, int order_id, decimal price, string description)
        {
            Id = id;
            Date = date;
            Order_id = order_id;
            Price = price;
            Description = description;
        }

        public int Id { get => _Id; set => _Id = value; }
        public DateTime? Date { get => _date; set => _date = value; }
        public int? Order_id { get => _order_id; set => _order_id = value; }
        public decimal? Price { get => _price; set => _price = value; }
        public string? Description { get => _description; set => _description = value; }

    }
}
