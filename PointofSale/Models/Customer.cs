using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointofSale.Models
{
    public class Customer : Person
    {

        public new bool save()
        {
            try
            {
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
