using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointofSale.Interfaces;

namespace PointofSale.Models
{
    public class Sales : BaseTransaction, ICrud
    {
        public int id { get; set; }
        public string transactionNumber { get; set; }
        public string invoiceNumber { get; set; }
        public int customerId { get; set; }
        public int cashierId { get; set; }

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

    public class SalesDetail : IInventory, ICrud
    {
        public int salesId { get; set; }
        public int inventoryId { get; set; }
        public string inventoryCode { get; set; }
        public string inventoryName { get; set; }
        public decimal price { get; set; }
        public decimal quantity { get; set; }
        public decimal discount { get; set; }
        public decimal cost { get; set; }

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
