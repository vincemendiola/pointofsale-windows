using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointofSale.Interfaces;

namespace PointofSale.Models
{
    public class Person : ICrud
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateofBirth { get; set; }
        public string email { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string contactNo { get; set; }

        public bool deleteOne(int id)
        {
            throw new NotImplementedException();
        }

        public bool deleteAll()
        {
            throw new NotImplementedException();
        }

        public bool updateOne()
        {
            throw new NotImplementedException();
        }

        public bool save()
        {
            throw new NotImplementedException();
        }
    }
}
