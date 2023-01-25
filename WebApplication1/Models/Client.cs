namespace WebApplication1.Models
{
    public class Client
    {
        private int _id;
        private string? _firstname;
        private string? _lastname;
        private string? _email;
        private int? _phone;
        private string? _address;

        public Client()
        {
        }

        public Client(int id, string firstname, string lastname, string email, int phone, string address)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Phone = phone;
            Address = address;
        }

        public int Id { get => _id; set => _id = value; }
        public string? Firstname { get => _firstname; set => _firstname = value; }
        public string? Lastname { get => _lastname; set => _lastname = value; }
        public string? Email { get => _email; set => _email = value; }
        public int? Phone { get => _phone; set => _phone = value; }
        public string? Address { get => _address; set => _address = value; }
    }
}
