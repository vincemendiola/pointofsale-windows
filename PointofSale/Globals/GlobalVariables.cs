using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointofSale.Globals
{
    public static class GlobalVariables
    {
        private static string def_date_format = "MM-dd-yyyy";
        private static string qry_date_format = "yyyy-MM-dd";
        private static string _decimal_format = "0.00";
        private static string _currency_format = "N2";

        public static string getCurrencyFormat()
        {
            return _currency_format;
        }
    }
}
