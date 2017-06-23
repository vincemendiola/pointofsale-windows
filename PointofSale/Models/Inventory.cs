using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointofSale.Interfaces;
using PointofSale.Database;
using PointofSale.Util;

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

        public Inventory()
        {

        }

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

        public static List<Inventory> read(string customQuery, string limitQuery)
        {
            try
            {
                DBHandler dbHandler = new DBHandler();
                List<Inventory> inventories = new List<Inventory>();

                string query = "SELECT * FROM inventory ";

                if (limitQuery != null)
                {
                    query += limitQuery;
                }

                dbHandler.OPEN(query);

                while (dbHandler.reader.Read())
                {
                    Inventory inventory = new Inventory();

                    inventory.code = DBDataHandler.object_to_string(dbHandler.reader["code"]);
                    inventory.name = DBDataHandler.object_to_string(dbHandler.reader["name"]);
                    inventory.description = DBDataHandler.object_to_string(dbHandler.reader["description"]);
                    inventory.price = DBDataHandler.object_to_decimal(dbHandler.reader["price"]);

                    inventories.Add(inventory);
                }

                dbHandler.CLOSE();

                return inventories;

            }
            catch (Exception)
            {
                return null;
            }
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
