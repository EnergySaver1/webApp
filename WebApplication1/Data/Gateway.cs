using Newtonsoft.Json;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    //Creating  gateway class to serialize Invoice class from models into JSON
    public class Gateway
    {

        //serialize list of invoices to file
        public void SerializeToJson(List<Invoice> invoices, string filePath)
        {
            string json = JsonConvert.SerializeObject(invoices);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(json);
            }

            Console.WriteLine("Invoices saved to invoices.json");

        }

        public List<Invoice> DeserializeFromJson(string filePath)
        {
            List<Invoice> invoices;
            using (StreamReader reader = new StreamReader("invoices.json"))
            {
                string json = reader.ReadToEnd();
                invoices = JsonConvert.DeserializeObject<List<Invoice>>(json);
            }

            Console.WriteLine("Invoices loaded from invoices.json");

            return invoices;
        }
    }
}
