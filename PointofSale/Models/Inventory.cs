using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointofSale.Interfaces;
using PointofSale.Database;
namespace PointofSale.Models
{
    public class Inventory : ICrud
    {
        DBHandler dbHandler = new DBHandler();

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
            try
            {
                string query = "INSERT INTO inventory(code,name,description,price) ";
                query += "VALUES(@code,@name, @description, @price)";

                dbHandler.setParameters("@code", code);
                dbHandler.setParameters("@name", name);
                dbHandler.setParameters("@description", description);
                dbHandler.setParameters("@price", price);

                var result = dbHandler.Insert(query);

                return true;
            }
            catch (Exception)
            {
                return false;
            }


            
        }
    }
}
