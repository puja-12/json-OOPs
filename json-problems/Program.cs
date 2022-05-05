// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using System.Text.Json.Serialization;

namespace json_problems
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to inventory Management");
            const string FILE = @"C:\bridge\\Json-OOPs\Json-problems\jsconfig1.json";
            inventoryManagement inventory = new inventoryManagement();
            Console.WriteLine("select number\n1.Dispaly\n");
            bool check = true;
            while (check)
            {
                Console.WriteLine("enter options");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        inventory.Displayinventory(FILE);
                        break;
                }
            }
        }
    }
}