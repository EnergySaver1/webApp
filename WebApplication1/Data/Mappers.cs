﻿using Microsoft.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    //create data mapper for the class client to sql server
    public class ClientDataMapper
    {
        //create a connection to the database
        private SqlConnection _connection;
        //create a constructor for the class
        public ClientDataMapper()
        {
            //create a connection string
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //create a connection
            _connection = new SqlConnection(connectionString);
        }
        //create a method to get all the clients
        public List<Client> GetAllClients()
        {
            //create a list of clients
            List<Client> clients = new List<Client>();
            //create a command
            SqlCommand command = new SqlCommand("SELECT * FROM Clients", _connection);
            //open the connection
            _connection.Open();
            //create a reader
            SqlDataReader reader = command.ExecuteReader();
            //read the data
            while (reader.Read())
            {
                //create a client
                Client client = new Client();
                //get the data from the reader
                client.Id = (int)reader["Id"];
                client.Firstname = (string)reader["FirstName"];
                client.Lastname = (string)reader["LastName"];
                client.Email = (string)reader["Email"];
                client.Phone = (int)reader["Phone"];
                client.Address = (string)reader["Address"];

                //add the client to the list
                clients.Add(client);
            }
            //close the connection
            _connection.Close();
            //return the list
            return clients;
        }
        //create a method to get a client by id
        public Client GetClientById(int id)
        {
            //create a client
            Client client = new Client();
            //create a command
            SqlCommand command = new SqlCommand("SELECT * FROM Clients WHERE Id = @Id", _connection);
            //add the parameter
            command.Parameters.AddWithValue("@Id", id);
            //open the connection
            _connection.Open();
            //create a reader
            SqlDataReader reader = command.ExecuteReader();
            //read the data
            while (reader.Read())
            {
                //get the data from the reader
                client.Id = (int)reader["Id"];
                client.Firstname = (string)reader["FirstName"];
                client.Lastname = (string)reader["LastName"];
                client.Email = (string)reader["Email"];
                client.Phone = (int)reader["Phone"];
                client.Address = (string)reader["Address"];
            }
            //close the connection
            _connection.Close();
            //return the client
            return client;
        }
        //create a method to insert a client
        public void InsertClient(Client client)
        {
            //create a command
            SqlCommand command = new SqlCommand("INSERT INTO Clients (FirstName, LastName, Email, Phone) VALUES (@FirstName, @LastName, @Email, @Phone)", _connection);
            //add the parameters
            command.Parameters.AddWithValue("@FirstName", client.Firstname);
            command.Parameters.AddWithValue("@LastName", client.Lastname);
            command.Parameters.AddWithValue("@Email", client.Email);
            command.Parameters.AddWithValue("@Phone", client.Phone);
            command.Parameters.AddWithValue("@Address", client.Address);
            //open the connection
            _connection.Open();
            //execute the command
            command.ExecuteNonQuery();
            //close the connection
            _connection.Close();
        }

        public void DeleteClient(Client client)
        {
            //create a command
            SqlCommand command = new SqlCommand("DELETE FROM Clients WHERE Id = @Id", _connection);
            //add the parameters
            command.Parameters.AddWithValue("@Id", client.Id);
            //open the connection
            _connection.Open();
            //execute the command
            command.ExecuteNonQuery();
            //close the connection
            _connection.Close();
        }
    }

    //create data mapper for the class Employee to sql server
    public class EmployeeDataMapper
    {
        //create a connection to the database
        private SqlConnection _connection;
        //create a constructor for the class
        public EmployeeDataMapper()
        {
            //create a connection string
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //create a connection
            _connection = new SqlConnection(connectionString);
        }
        //create a method to get all the employees
        public List<Employee> GetAllEmployees()
        {
            //create a list of employees
            List<Employee> employees = new List<Employee>();
            //create a command
            SqlCommand command = new SqlCommand("SELECT * FROM Employees", _connection);
            //open the connection
            _connection.Open();
            //create a reader
            SqlDataReader reader = command.ExecuteReader();
            //read the data
            while (reader.Read())
            {
                //create an employee
                Employee employee = new Employee();
                //get the data from the reader
                employee.Id = (int)reader["Id"];
                employee.Firstname = (string)reader["FirstName"];
                employee.Lastname = (string)reader["LastName"];
                employee.Email = (string)reader["Email"];
                employee.Phone = (int)reader["Phone"];
                employee.Address = (string)reader["Address"];
                employee.Salary = (decimal)reader["Salary"];
                employee.Position = (string)reader["Position"];
                employee.DateOfEmployment = (DateTime)reader["DateOfEmployment"];
                employee.BirthNumber = (string)reader["BirthNumber"];
                //add the employee to the list
                employees.Add(employee);
            }
            //close the connection
            _connection.Close();
            //return the list
            return employees;
        }
        //create a method to get an employee by id
        public Employee GetEmployeeById(int id)
        {
            //create an employee
            Employee employee = new Employee();
            //create a command
            SqlCommand command = new SqlCommand("SELECT * FROM Employees WHERE Id = @Id", _connection);
            //add the parameter
            command.Parameters.AddWithValue("@Id", id);
            //open the connection
            _connection.Open();
            //create a reader
            SqlDataReader reader = command.ExecuteReader();
            //read the data
            while (reader.Read())
            {
                //get the data from the reader
                employee.Id = (int)reader["Id"];
                employee.Firstname = (string)reader["FirstName"];
                employee.Lastname = (string)reader["LastName"];
                employee.Email = (string)reader["Email"];
                employee.Phone = (int)reader["Phone"];
                employee.Address = (string)reader["Address"];
                employee.Salary = (decimal)reader["Salary"];
                employee.Position = (string)reader["Position"];
                employee.DateOfEmployment = (DateTime)reader["DateOfEmployment"];
                employee.BirthNumber = (string)reader["BirthNumber"];
            }

            //close the connection
            _connection.Close();
            
            return employee;
        }

        //create a method to insert an employee
        public void InsertEmployee(Employee employee)
        {
            //create a command
            SqlCommand command = new SqlCommand("INSERT INTO Employees (FirstName, LastName, Email, Phone, Address, Salary, HireDate, JobTitle, Department) VALUES (@FirstName, @LastName, @Email, @Phone, @Address, @Salary, @HireDate, @JobTitle, @Department)", _connection);
            //add the parameters
            command.Parameters.AddWithValue("@FirstName", employee.Firstname);
            command.Parameters.AddWithValue("@LastName", employee.Lastname);
            command.Parameters.AddWithValue("@Email", employee.Email);
            command.Parameters.AddWithValue("@Phone", employee.Phone);
            command.Parameters.AddWithValue("@Address", employee.Address);
            command.Parameters.AddWithValue("@Position", employee.Position);
            command.Parameters.AddWithValue("@Salary", employee.Salary);
            command.Parameters.AddWithValue("@DateofEmployment", employee.DateOfEmployment);
            command.Parameters.AddWithValue("@BirthNumber", employee.BirthNumber);
        
            //open the connection
            _connection.Open();
            //execute the command
            command.ExecuteNonQuery();
            //close the connection
            _connection.Close();
        }

        //remove an employee
        public void DeleteEmployee(Employee employee)
        {
            _connection.Open();
            //create a command
            SqlCommand command = new SqlCommand("DELETE FROM Employees WHERE Id = @Id", _connection);

            _connection.Close();
           
        }


    }

    //create data mapper for the class Order from this namespace to sql server
    public class OrderDataMapper
    {
        //create a connection to the database
        private SqlConnection _connection;
        //create a constructor for the class
        public OrderDataMapper()
        {
            //create a connection string
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //create a connection
            _connection = new SqlConnection(connectionString);
        }
        //create a method to get all the orders
        public List<Order> GetAllOrders()
        {
            //create a list of orders
            List<Order> orders = new List<Order>();
            //create a command
            SqlCommand command = new SqlCommand("SELECT * FROM Orders", _connection);
            //open the connection
            _connection.Open();
            //create a reader
            SqlDataReader reader = command.ExecuteReader();
            //read the data
            while (reader.Read())
            {
                //create an order
                Order order = new Order();
                //get the data from the reader
                order.Id = (int)reader["Id"];
                order.Start_date = (DateTime)reader["Start_date"];
                order.End_date = (DateTime)reader["End_date"];
                order.State = (String)reader["State"];
                order.Description = (String)reader["Description"];
                order.Customer_id = (int)reader["Customer_id"];
                order.Employee_id = (int)reader["Employee_id"];
                order.Repair_type_id = (int)reader["RepairType_id"];
                order.Price = (decimal)reader["Price"];
                //add the order to the list
                orders.Add(order);
            }
            //close the connection
            _connection.Close();
            //return the list
            return orders;
        }
        //create a method to get an order by id
        public Order GetOrderById(int id)
        {
            //create an order
            Order order = new Order();
            //create a command
            SqlCommand command = new SqlCommand("SELECT * FROM Orders WHERE Id = @Id", _connection);
            //add the parameter
            command.Parameters.AddWithValue("@Id", id);
            //open the connection
            _connection.Open();
            //create a reader
            SqlDataReader reader = command.ExecuteReader();
            //read the data
            while (reader.Read())
            {
                //get the data from the reader
                order.Id = (int)reader["Id"];
                order.Start_date = (DateTime)reader["Start_date"];
                order.End_date = (DateTime)reader["End_date"];
                order.State = (String)reader["State"];
                order.Description = (String)reader["Description"];
                order.Customer_id = (int)reader["Customer_id"];
                order.Employee_id = (int)reader["Employee_id"];
                order.Repair_type_id = (int)reader["RepairType_id"];
                order.Price = (decimal)reader["Price"];
            }

            _connection.Close();

            return order;
        }

        //  insert order to database

        public void InsertOrder(Order order)
        {
            _connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Orders (Start_date, End_date, State, Description, Customer_id, Employee_id, Price) VALUES (@Start_date, @End_date, @State, @Description, @Customer_id, @Employee_id, @Price)", _connection);
            
            _connection.Close();

        }

        // delete order from database by it's id
        public void DeleteOrder(Order order)
        {
            _connection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM Orders WHERE Id = @Id", _connection);

            _connection.Close();

        }
    }

    //create data mapper for the class RepairType to sql server
    public class RepairTypeDataMapper
    {
        //create a connection to the database
        private SqlConnection _connection;
        //create a constructor for the class
        public RepairTypeDataMapper()
        {
            //create a connection string
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //create a connection
            _connection = new SqlConnection(connectionString);
        }
        //create a method to get all the repair types
        public List<RepairType> GetAllRepairTypes()
        {
            //create a list of repair types
            List<RepairType> repairTypes = new List<RepairType>();
            //create a command
            SqlCommand command = new SqlCommand("SELECT * FROM RepairTypes", _connection);
            //open the connection
            _connection.Open();
            //create a reader
            SqlDataReader reader = command.ExecuteReader();
            //read the data
            while (reader.Read())
            {
                //create a repair type
                RepairType repairType = new RepairType();
                //get the data from the reader
                repairType.Id = (int)reader["Id"];
                repairType.Name = (string)reader["Name"];
                repairType.Price = (decimal)reader["Price"];
                //add the repair type to the list
                repairTypes.Add(repairType);
            }
            //close the connection
            _connection.Close();
            //return the list
            return repairTypes;
        }
        //create a method to get a repair type by id
        public RepairType GetRepairTypeById(int id)
        {
            //create a repair type
            RepairType repairType = new RepairType();
            //create a command
            SqlCommand command = new SqlCommand("SELECT * FROM RepairTypes WHERE Id = @Id", _connection);
            //add the parameter
            command.Parameters.AddWithValue("@Id", id);
            //open the connection
            _connection.Open();
            //create a reader
            SqlDataReader reader = command.ExecuteReader();
            //read the data
            while (reader.Read())
            {
                //get the data from the reader
                repairType.Id = (int)reader["Id"];
                repairType.Name = (string)reader["Name"];
                repairType.Price = (decimal)reader["Price"];
            }
            //close the connection
            _connection.Close();
            //return the repair type
            return repairType;
        }
        //create a method to insert a repair type
        public void InsertRepairType(RepairType repairType)
        {
            //create a command
            SqlCommand command = new SqlCommand("INSERT INTO RepairTypes (Name, Price) VALUES (@Name, @Price)", _connection);
            //add the parameters
            command.Parameters.AddWithValue("@Name", repairType.Name);
            command.Parameters.AddWithValue("@Price", repairType.Price);
            //open the connection
            _connection.Open();
            //execute the command
            command.ExecuteNonQuery();
            //close the connection
            _connection.Close();
        }

        // remove repair type
        public void DeleteRepairType(RepairType repairType)
        {
            //create a command
            SqlCommand command = new SqlCommand("DELETE FROM RepairTypes WHERE Id = @Id", _connection);

            //add the parameters
            command.Parameters.AddWithValue("@Id", repairType.Id);
            //open the connection
            _connection.Open();
            //execute the command
            command.ExecuteNonQuery();
            //close the connection
            _connection.Close();

        }
    }
}