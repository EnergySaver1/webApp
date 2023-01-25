namespace WebApplication1.Models
{
    public class SparePartOrder
    {
        private int? _id;
        private decimal? _price;
        private string? _state;
        private DateTime? _deliveryDate;
        private DateTime? _purchaseDate;
        private int? _employee_id;
        private int? _warehouse_id;
        private int? _sparePart_id;

        public SparePartOrder()
        {
        }

        public SparePartOrder(int? id, decimal? price, string? state, DateTime? deliveryDate, DateTime? purchaseDate, int? employee_id, int? warehouse_id, int? sparePart_id)
        {
            Id = id;
            Price = price;
            State = state;
            DeliveryDate = deliveryDate;
            PurchaseDate = purchaseDate;
            Employee_id = employee_id;
            Warehouse_id = warehouse_id;
            SparePart_id = sparePart_id;
        }

        public int? Id { get => _id; set => _id = value; }
        public decimal? Price { get => _price; set => _price = value; }
        public string? State { get => _state; set => _state = value; }
        public DateTime? DeliveryDate { get => _deliveryDate; set => _deliveryDate = value; }
        public DateTime? PurchaseDate { get => _purchaseDate; set => _purchaseDate = value; }
        public int? Employee_id { get => _employee_id; set => _employee_id = value; }
        public int? Warehouse_id { get => _warehouse_id; set => _warehouse_id = value; }
        public int? SparePart_id { get => _sparePart_id; set => _sparePart_id = value; }
    }
}
