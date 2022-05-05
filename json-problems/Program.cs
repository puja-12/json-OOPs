// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using System.Text.Json.Serialization;

namespace JSONArticle
{

    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory() { name = "rice", pricePerkg = 100, Weight = 10 };
            Inventory inventory2 = new Inventory() { name = "Wheat", pricePerkg = 50, Weight = 40 };
            Inventory inventory3 = new Inventory() { name = "Pulses", pricePerkg = 50, Weight = 40 };
            var invList = new List<Inventory>()
        {
            inventory,
            inventory2,
            inventory3
        };

            InventoryList inventoryList = new InventoryList() { invList = invList };

            JsonSerializerOptions options = new()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(inventoryList, options);
            Console.Write($"Serialized list {Environment.NewLine} {jsonString} {Environment.NewLine}");

            var list = JsonSerializer.Deserialize<InventoryList>(jsonString);
            Console.Write($"Deserialization completed");
        }
    }

    public class Inventory
    {
        public string name { get; set; }
        public int pricePerkg { get; set; }
        public int Weight { get; set; }
    }

    public class InventoryList
    {
        public List<Inventory> invList { get; set; }
    }
}