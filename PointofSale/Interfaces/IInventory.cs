using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointofSale.Interfaces
{
    interface IInventory
    {
        string inventoryCode { get; set; }
        string inventoryName { get; set; }
    }
}
