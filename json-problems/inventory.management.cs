using json_problems;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace json_problems
{
    internal class inventoryManagement
    {
        public void Displayinventory(string filepath)
        {
            using (StreamReader reader = new StreamReader(filepath)) 
            {
                var json = reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject<List<inventoryData>>(json);
                Console.WriteLine("Name" + "\t" + "Weight" + "\t" + "PricePerKg" + "\t" + "totalPrice");
                foreach(var data in inventory)
                {
                    Console.WriteLine(data.name + "\t" + data.Weight + "\t" + data.PricePerkg + "\t" + (data.Weight * data.PricePerkg));
                }

            }
        }
    }
}
