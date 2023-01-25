namespace WebApplication1.Models
{
    public class Warehouse
    {
        private int? _id;
        private string? _address;
        private string? _email;
        private int? _phone;

        public Warehouse()
        {
        }

        public Warehouse(int? id, string? address, string? email, int? phone)
        {
            Id = id;
            Address = address;
            Email = email;
            Phone = phone;
        }

        public int? Id { get => _id; set => _id = value; }
        public string? Address { get => _address; set => _address = value; }
        public string? Email { get => _email; set => _email = value; }
        public int? Phone { get => _phone; set => _phone = value; }
    }
}
