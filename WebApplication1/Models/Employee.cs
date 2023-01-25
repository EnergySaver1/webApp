using System;

namespace WebApplication1.Models
{
    public class Employee: Client
    {
        private string? _position;
        private decimal? _salary;
        private DateTime? _dateOfEmployment;
        private string? _birthNumber;

        public Employee()
        {
        }

        public Employee(int id, string firstname, string lastname, string email, int phone, string address, string position, decimal salary, DateTime dateOfEmployment, string birthNumber)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Phone = phone;
            Address = address;
            Position = position;
            Salary = salary;
            DateOfEmployment = dateOfEmployment;
            BirthNumber = birthNumber;
        }

        public string? Position { get => _position; set => _position = value; }
        public decimal? Salary { get => _salary; set => _salary = value; }
        public DateTime? DateOfEmployment { get => _dateOfEmployment; set => _dateOfEmployment = value; }
        public string? BirthNumber { get => _birthNumber; set => _birthNumber = value; }
    }
}
