using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointofSale.Interfaces;

namespace PointofSale.Models
{
    class Inventory : ICrud
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int itemType { get; set; }

        public bool deleteOne(int id)
        {
            return true;
        }

        public bool deleteAll()
        {
            return true;
        }

        public bool updateOne()
        {
            return true;
        }

        public bool save()
        {
            return true;
        }
    }
}
