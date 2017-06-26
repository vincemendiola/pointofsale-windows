using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PointofSale.Util
{
    public static class Formatter
    {
        public static string formatString(string invoicenumber)
        {
            string new_invoice_number = "";
            var match = Regex.Match(invoicenumber, @"(?<=(\D|^))\d+(?=\D*$)");

            if (match.Success)
            {
                new_invoice_number = Regex.Replace(invoicenumber, @"(?<=(\D|^))\d+(?=\D*$)", m => (int.Parse(m.Value) + 1).ToString().PadLeft(match.Length, '0'));
            }

            return new_invoice_number;
        }

    }
}
