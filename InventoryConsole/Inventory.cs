using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryConsole
{
    class Inventory
    {
        private int id;
        private string stockItem;
        private int sellin;
        private int quality;

        public Inventory(int id, string stockItem, int sellin, int quality)
        {
            this.id = id;
            this.stockItem = stockItem;
            this.sellin = sellin;
            this.quality = quality;

        }
        public int Id
        {
            get { return id; }
        }
        public string StockItem
        {
            get { return stockItem; }
            set { stockItem = value; }
        }
        public int Sellin
        {
            get { return sellin; }
            set { sellin = value; }
        }

        public int Quality
        {
            get { return quality; }
            set { quality = value; }
        }
    }
}
