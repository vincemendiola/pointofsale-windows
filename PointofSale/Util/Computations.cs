using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointofSale.Util
{
    public static class Computations
    {
        public static decimal getTotal(decimal price, decimal quantity)
        {
            return price * quantity;
        }

        public static decimal getDiscountAmount(decimal price, decimal discount)
        {
            decimal discountPercentage = discount / 100;

            return price * discountPercentage;
        }
    }
}
