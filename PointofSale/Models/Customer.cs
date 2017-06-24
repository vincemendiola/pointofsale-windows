using PointofSale.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointofSale.Util;

namespace PointofSale.Models
{
    public class Customer : Person
    {
        DBHandler dbHandler = new DBHandler();

        public static List<Customer> read(string customQuery, string limitQuery)
        {
            try
            {
                List<Customer> customers = new List<Customer>();

                DBHandler dbHandler = new DBHandler();

                string query = "SELECT * FROM customer ";

                if (limitQuery != null)
                {
                    query += limitQuery;
                }

                dbHandler.OPEN(query);

                while (dbHandler.reader.Read())
                {
                    Customer customer = new Customer();

                    customer.code = DBDataHandler.object_to_string(dbHandler.reader["code"]);
                    customer.name = DBDataHandler.object_to_string(dbHandler.reader["name"]);
                    customer.address1 = DBDataHandler.object_to_string(dbHandler.reader["address1"]);
                    customer.email = DBDataHandler.object_to_string(dbHandler.reader["email"]);

                    customers.Add(customer);
                }

                dbHandler.CLOSE();


                return customers;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public new bool save()
        {
            try
            {
                string query = "INSERT INTO customer(";
                query += "code,";
                query += "name,";
                query += "first_name,";
                query += "last_name,";
                query += "address1,";
                query += "email)";

                query += " VALUES(";
                query += "@code,";
                query += "@name,";
                query += "@first_name,";
                query += "@last_name,";
                query += "@address1,";
                query += "@email)";

                dbHandler.setParameters("@code", code);
                dbHandler.setParameters("@name", name);
                dbHandler.setParameters("@first_name", firstName);
                dbHandler.setParameters("@last_name", lastName);
                dbHandler.setParameters("@address1", address1);
                dbHandler.setParameters("@email", email);

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
