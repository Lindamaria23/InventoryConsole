using InventoryConsole.Data;
using InventoryConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TestData testData = new TestData();
            PrintOut printOut = new PrintOut();
            Process process = new Process();

            List<Inventory> InventoryList = testData.GetInventories();
            List<Inventory> InventoryListUpdated = new List<Inventory>();

            printOut.DisplayHeadings("Test data input:-");

            printOut.DisplayList(InventoryList);

            printOut.DisplayHeadings("Test data output:- ");

            InventoryListUpdated = process.GetInventories(InventoryList);

            printOut.DisplayList(InventoryListUpdated);

            Console.ReadLine();

       
        }
    }
}
