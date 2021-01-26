using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryConsole.Services
{
    class Process
    {
        public List<Inventory> UpdatedInventoryList = new List<Inventory>();

        public Process()
        {

        }
        public List<Inventory> GetInventories(List<Inventory> Inventories)
        {

            var inventoryAgedBrie = Inventories.Where(item => item.StockItem.ToUpper() == "AGED BRIE");
            var inventoryFrozen = Inventories.Where(item => item.StockItem.ToUpper() == "FROZEN ITEM");
            var inventoryFresh = Inventories.Where(item => item.StockItem.ToUpper() == "FRESH ITEM");
            var inventoryCrackers = Inventories.Where(item => item.StockItem.ToUpper() == "CHRISTMAS CRACKERS");
            var inventorySoap = Inventories.Where(item => item.StockItem.ToUpper() == "SOAP");
            var inventoryInvalid = Inventories.Where(item => item.StockItem.ToUpper() == "INVAILD ITEM");


            foreach (var i in inventoryAgedBrie)
            {
                //set sellin value decrease by 1
                i.Sellin = i.Sellin - 1;
                //set Quality value increase by 1
                i.Quality = i.Quality + 1;
                //create new list to display results
                UpdatedInventoryList.Add(new Inventory(i.Id, i.StockItem, i.Sellin, i.Quality));
            }

            foreach (var i in inventoryFrozen)
            {
                if (i.Sellin < 0)
                {
                    //set quality value decrease by 2
                    i.Quality = i.Quality - 2;
                }
                else
                {
                    //set quality value decrease by 1
                    i.Quality = i.Quality - 1;
                }

                //set sellin value decrease by 1
                i.Sellin = i.Sellin - 1;

                //create new list to display results
                UpdatedInventoryList.Add(new Inventory(i.Id, i.StockItem, i.Sellin, i.Quality));

            }
            foreach (var i in inventoryFresh)
            {
                if (i.Sellin < 0)
                {
                    //set quality value decrease by 4
                    i.Quality = i.Quality - 4;
                }
                else
                {
                    //set quality value decrease by 2
                    i.Quality = i.Quality - 2;
                }

                //set sellin value decrease by 1
                i.Sellin = i.Sellin - 1;

                //create new list to display results
                UpdatedInventoryList.Add(new Inventory(i.Id, i.StockItem, i.Sellin, i.Quality));

            }

            foreach (var i in inventoryCrackers)
            {
                if (i.Sellin < 0)
                {
                    //set quality value to 0
                    i.Quality = 0;
                }
                else if (i.Sellin >= 6 && i.Sellin <= 10)
                {
                    //set quality value increase by 2
                    i.Quality = i.Quality + 2;
                }
                else if (i.Sellin >= 0 && i.Sellin <= 5)
                {
                    //set quality value increase by 3
                    i.Quality = i.Quality + 3;
                }

                //set sellin value decrease by 1
                i.Sellin = i.Sellin - 1;

                //create new list to display results
                UpdatedInventoryList.Add(new Inventory(i.Id, i.StockItem, i.Sellin, i.Quality));
            }

            foreach (var i in inventorySoap)
            {
                //create new list to display results
                UpdatedInventoryList.Add(new Inventory(i.Id, i.StockItem, i.Sellin, i.Quality));

            }

            foreach (var i in inventoryInvalid)
            {
                //change stock item text
                i.StockItem = "NO SUCH ITEM";
                //set sellin value to 0
                i.Sellin = 0;
                //set quality value to 0
                i.Quality = 0;
                //create new list to display results
                UpdatedInventoryList.Add(new Inventory(i.Id, i.StockItem, i.Sellin, i.Quality));
            }

            foreach (var updatedInventory in UpdatedInventoryList)
            {
                //set quality range
                if (updatedInventory.Quality > 50)
                {
                    updatedInventory.Quality = 50;
                }
                else if (updatedInventory.Quality < 0)
                {
                    updatedInventory.Quality = 0;
                }

            }

            return UpdatedInventoryList;
        }
    }
}
