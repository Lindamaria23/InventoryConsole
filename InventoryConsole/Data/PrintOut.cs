using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryConsole.Data
{
    class PrintOut
    {
        public PrintOut()
        {

        }
        public string results = "";
        public string headings = "";

        public string DisplayList(List<Inventory> Inventories)
        {
            var inventoryInAscOrder = Inventories.OrderBy(i => i.Id);

            foreach (var inventory in inventoryInAscOrder)
            {
                Console.WriteLine("{0},{1},{2}", inventory.StockItem, inventory.Sellin, inventory.Quality);
            }

            return results;
        }

        public string DisplayHeadings(string heading)
        {
            Console.WriteLine("");
            Console.WriteLine(heading);
            Console.WriteLine("");
            return headings;
        }
    }
}
