using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointofSale.Database;

namespace PointofSale.Util
{
    class ModelFunctions
    {
        public static long getTotalRecord(string table)
        {
            try
            {
                DBHandler conn = new DBHandler();

                long count = 0;
                string query = "SELECT COUNT(*) as counter FROM " + table;

                conn.OPEN(query);

                while (conn.reader.Read())
                {
                    count = (long)conn.reader["counter"];
                }

                Console.WriteLine(count);

                return count;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
