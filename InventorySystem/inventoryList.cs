using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public class inventoryList
    {
        //public string Inventory_ID;
        //public string Inventory_Name;
        //public string Inventory_InStock;
        //public int Inventory_Quantity;
        //public string Inventory_Type;
        //public int Inventory_Price;
        //public string Inventory_Remarks;
        //public DateTime Inventory_Date;

        public string Inventory_ID { get; set; }
        public string Inventory_Name { get; set; }
        public string Inventory_InStock { get; set; }
        public int Inventory_Quantity { get; set; }
        public string Inventory_Type { get; set; }
        public int Inventory_Price { get; set; }
        public string Inventory_Remarks { get; set; }
        public DateTime Inventory_Date { get; set; }

        public inventoryList()
        {
            Inventory_ID = "";
            Inventory_Name = "";
            Inventory_InStock = "";
            Inventory_Quantity = 0;
            Inventory_Type = "";
            Inventory_Price = 0;
            Inventory_Remarks = "";
            Inventory_Date = DateTime.Now;
        }
    }
}
