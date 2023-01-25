namespace WebApplication1.Models
{
    public class RepairType
    {
        private int _id;
        private string _name;
        private decimal _price;

        public RepairType()
        {
        }

        public RepairType(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public decimal Price { get => _price; set => _price = value; }
    }
}
