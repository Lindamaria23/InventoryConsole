using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryConsole.Data
{
    class TestData
    {
        public List<Inventory> InventoryList { get; set; }

        public TestData()
        {

        }

        public List<Inventory> GetInventories()
        {
            List<Inventory> InventoryList = new List<Inventory>();

            InventoryList.Add(new Inventory(1, "Aged Brie", 1, 1));
            InventoryList.Add(new Inventory(2, "Christmas Crackers", -1, 2));
            InventoryList.Add(new Inventory(3, "Christmas Crackers", 9, 2));
            InventoryList.Add(new Inventory(4, "Soap", 2, 2));
            InventoryList.Add(new Inventory(5, "Frozen Item", -1, 55));
            InventoryList.Add(new Inventory(6, "Frozen Item", 2, 2));
            InventoryList.Add(new Inventory(7, "INVAILD ITEM", 2, 2));
            InventoryList.Add(new Inventory(8, "Fresh Item", 2, 2));
            InventoryList.Add(new Inventory(9, "Fresh Item", -1, 5));

            return InventoryList;
        }
    }
}
