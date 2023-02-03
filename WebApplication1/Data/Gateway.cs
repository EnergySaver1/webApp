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
            System.IO.File.WriteAllText(filePath, string.Empty);
            try
            {
                using (var stream = File.Create(filePath))
                using (var writer = new StreamWriter(stream))
                {
                    var json = JsonConvert.SerializeObject(invoices);
                    writer.Write(json);
                }
            }
            catch (Exception ex)
            {
                // handle exception
                Console.WriteLine("An error occurred while writing the JSON file: " + ex.Message);
            }

        }

        public List<Invoice> DeserializeFromJson(string filePath)
        {
            List<Invoice> invoices;
            using (StreamReader reader = new StreamReader(filePath))
            {
                string json = reader.ReadToEnd();
                if (!string.IsNullOrWhiteSpace(json))
                {
                    invoices = JsonConvert.DeserializeObject<List<Invoice>>(json);
                }

                else
                {
                    invoices = new List<Invoice>();

                }
            }
            Console.WriteLine("Invoices loaded from invoices.json");

            return invoices;
        }
    }
}
