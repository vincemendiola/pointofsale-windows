using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointofSale.Database;
using PointofSale.Util;

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

        public static string getNextReferenceNumber(string table, string referenceName)
        {
            string last_invoice_number = "";
            DBHandler conn = new DBHandler();
            try
            {
                string query = "SELECT " + referenceName + " FROM " + table + " ORDER BY date DESC, id DESC, CAST(" + referenceName + " as unsigned) DESC LIMIT 1";

                conn.OPEN(query);

                while (conn.reader.Read())
                {
                    last_invoice_number = (string)conn.reader[referenceName];
                }

                if (last_invoice_number.Length <= 0)
                {
                    last_invoice_number = "000";
                }

                conn.CLOSE();

                return Formatter.formatString(last_invoice_number);

            }
            catch (Exception err)
            {
                return last_invoice_number;
            }
        }
    }
}
