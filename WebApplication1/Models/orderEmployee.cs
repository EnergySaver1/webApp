namespace WebApplication1.Models
{
    public class OrderEmployee
    {
        private int _order_id;
        private int _employee_id;

        public OrderEmployee()
        {
        }

        public OrderEmployee(int order_id, int employee_id)
        {
            Order_id = order_id;
            Employee_id = employee_id;
        }

        public int Order_id { get => _order_id; set => _order_id = value; }
        public int Employee_id { get => _employee_id; set => _employee_id = value; }
    }
}
