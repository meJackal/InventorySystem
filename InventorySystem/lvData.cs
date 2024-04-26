using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public class lvData
    {
        public class inventory
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Availability { get; set; }
            public string Type { get; set; }
            public int Quantity { get; set; }
            public int Price { get; set; }
            public string UpdatedBy { get; set; }
            public DateTime dt { get; set; }
            public string Remark { get; set; }
        }
    }
}
