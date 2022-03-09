using System;
using JSONinventoryManagement;

namespace JSONinventoryManagement
{
    internal class Program
    {
        const string INVENTORY_JSON = @"E:\desktop\newpgm\JSONinventoryManagement\JSONinventoryManagement\inventory.json";
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Json Inventory management program ");
            InventoryMain inv = new InventoryMain();
            inv.ShowOptions(INVENTORY_JSON);
        }
    }
}
