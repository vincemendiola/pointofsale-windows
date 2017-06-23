using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointofSale.Interfaces
{
    interface ICrud
    {
        bool deleteOne(int id);
        bool deleteAll();
        bool updateOne();
        bool save();

    }
}
