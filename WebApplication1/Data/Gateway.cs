using Newtonsoft.Json;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    //Creating  gateway class to serialize Invoice class from models into JSON
    public class Gateway
    {
        public void SerializeToJson(Invoice invoice, string filePath)
        {
            try
            {
                using (var stream = File.Create(filePath))
                using (var writer = new StreamWriter(stream))
                {
                    var json = JsonConvert.SerializeObject(invoice);
                    writer.Write(json);
                }
            }
            catch (Exception ex)
            {
                // handle exception
                Console.WriteLine("An error occurred while writing the JSON file: " + ex.Message);
            }
        }

        public Invoice DeserializeFromJson(string filePath)
        {
            using (var stream = File.OpenRead(filePath))
            using (var reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Invoice>(json);
            }
        }
    }
}
