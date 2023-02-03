namespace WebApplication1.Models
{
    public class Invoice : Order
    {
        private int? _ico;
        private int? _dic;
        private int? _bankAccount;
        private int? _bankCode;
        private int? _variableSymbol;

        public Invoice (Order order)
        {
            Ico = 77777888;
            Dic = 66666888;
            BankAccount = 888888;
            BankCode = 8888;
            Id = order.Id;
            Start_date = order.Start_date;
            End_date = order.End_date;
            State = order.State;
            Description = order.Description;
            Customer_id = order.Customer_id;
            Repair_type_id = order.Repair_type_id;
            Price = order.Price;
            VariableSymbol = order.Id;
        }

        public Invoice()
        {
            Ico = 77777888;
            Dic = 66666888;
            BankAccount = 888888;
            BankCode = 8888;
        }

        public Invoice(int id, DateTime start_date, DateTime end_date, string state, string description, int customer_id, int repair_type_id, decimal price, int _ico, int _dic, int _bankAccount, int _bankCode, int _variableSymbol) : base(id, start_date, end_date, state, description, customer_id, repair_type_id, price)
        {
            Ico = _ico;
            Dic = _dic;
            BankAccount = _bankAccount;
            BankCode = _bankCode;
            VariableSymbol = _variableSymbol;
        }
       

        public int? Ico { get => _ico; set => _ico = value; }
        public int? Dic { get => _dic; set => _dic = value; }
        public int? BankAccount { get => _bankAccount; set => _bankAccount = value; }
        public int? BankCode { get => _bankCode; set => _bankCode = value; }
        public int? VariableSymbol { get => _variableSymbol; set => _variableSymbol = value; }

        public String ToString()
        {
            return $"Ico: {Ico}, Dic: {Dic}, BankAccount: {BankAccount}, BankCode: {BankCode}, VariableSymbol: {VariableSymbol}, Id: {Id}, Start_date: {Start_date}, End_date: {End_date}, State: {State}, Description: {Description}, Customer_id: {Customer_id}, Repair_type_id: {Repair_type_id}, Price: {Price}";
        }


    }
}

