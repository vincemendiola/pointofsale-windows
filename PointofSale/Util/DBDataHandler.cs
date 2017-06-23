using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointofSale.Util
{
    public static class DBDataHandler
    {
        public static string object_to_string(object data)
        {
            return (data == null) ? string.Empty : data.ToString();
        }

        public static decimal object_to_decimal(object data)
        {
            string str_value = object_to_string(data);

            return (str_value == null || str_value.Length <= 0) ? 0 : Convert.ToDecimal(str_value);
        }

        public static int object_to_int(object data)
        {
            string str_value = object_to_string(data);

            return (str_value == null || str_value.Length <= 0) ? 0 : int.Parse(str_value);
        }
    }
}
