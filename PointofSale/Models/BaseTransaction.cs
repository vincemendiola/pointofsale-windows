using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointofSale.Models
{
    public class BaseTransaction
    {
        public string referenceNumber { get; set; }
        public DateTime date { get; set; }
        public bool isDeleted { get; set; }
        public bool isHeld { get; set; }
        public bool isVoid { get; set; }
        public decimal totalGross { get; set; }
        public decimal totalDiscount { get; set; }
        public decimal totalVat { get; set; }
        public decimal totalNet { get; set; }
    }
}
