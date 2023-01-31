namespace WebApplication1.Models
{
    public class Order
    {
        private int? _Id;
        private DateTime? _start_date;
        private DateTime? _end_date;
        private string? _state;
        private string? _description;
        private int? _customer_id;
        private int? _employee_id;
        private int? _repair_type_id;
        private decimal? _price;
        

        public Order()
        {
        }

        public Order(int id, DateTime start_date, DateTime end_date, string state, string description, int customer_id, int employee_id, int repair_type_id, decimal price)
        {
            Id = id;
            Start_date = start_date;
            End_date = end_date;
            State = state;
            Description = description;
            Customer_id = customer_id;
            Employee_id = employee_id;
            Repair_type_id = repair_type_id;
            Price = price;
        }

        public int? Id { get => _Id; set => _Id = value; }
        public DateTime? Start_date { get => _start_date; set => _start_date = value; }
        public DateTime? End_date { get => _end_date; set => _end_date = value; }
        public string? State { get => _state; set => _state = value; }
        public string? Description { get => _description; set => _description = value; }
        public int? Customer_id { get => _customer_id; set => _customer_id = value; }
        public int? Employee_id { get => _employee_id; set => _employee_id = value; }
        public decimal? Price { get => _price; set => _price = value; }
        public int? Repair_type_id { get => _repair_type_id; set => _repair_type_id = value; }

        public string ToString()
        {
            return $"Id: {Id}, Start_date: {Start_date}, End_date: {End_date}, State: {State}, Description: {Description}, Customer_id: {Customer_id}, Employee_id: {Employee_id}, Repair_type_id: {Repair_type_id}, Price: {Price}";
        }
    }
}
