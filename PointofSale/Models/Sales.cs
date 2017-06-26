using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointofSale.Interfaces;
using PointofSale.Util;
using PointofSale.Database;


namespace PointofSale.Models
{
    public class Sales : BaseTransaction, ICrud
    {
        DBHandler dbHandler = new DBHandler();

        public int id { get; set; }
        public string transactionNumber { get; set; }
        public string invoiceNumber { get; set; }
        public string officialReceipt { get; set; }
        public int customerId { get; set; }
        public int cashierId { get; set; }
        public decimal total { get; set; }

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
            try
            {
                string query = "INSERT sale(";
                query += "transaction_number,";
                query += "invoicenumber,";
                query += "official_receipt,";
                query += "customer_id,";
                query += "date,";
                query += "total_gross)";

                query += "VALUES(";
                query += "@transaction_number,";
                query += "@invoicenumber,";
                query += "@official_receipt,";
                query += "@customer_id,";
                query += "@date,";
                query += "@total_gross)";

                dbHandler.setParameters("@invoicenumber", invoiceNumber);
                dbHandler.setParameters("@transaction_number", transactionNumber);
                dbHandler.setParameters("@official_receipt", officialReceipt);
                dbHandler.setParameters("@customer_id", customerId);
                dbHandler.setParameters("@date", date);
                dbHandler.setParameters("@total_gross", totalGross);

                var result = dbHandler.Insert(query);

                if (result is long)
                {
                    Console.WriteLine("Result is " + result);
                    return true;
                }else
                {
                    throw new Exception(result);
                }

            }
            catch (Exception err)
            {
                MessageBoxHandler.openBox("Error", err.ToString());
                return false;
            }
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
        public decimal discountAmount
        {
            get { return Computations.getDiscountAmount(price, discount); }
            set { discountAmount = value; }
        }
        public decimal totalGross
        {
            get { return Computations.getTotal(price, quantity); }
            set { totalGross = value; }
        }
        public decimal total
        {
            get { return Computations.getTotalNet(price, discount, quantity);  }
            set { total = value; }
        }

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
            try
            {
                //string query = "INSERT sale(";
                //query += "sales_number,";
                //query += "customer_id,";
                //query += "date,";
                //query += "total)";

                //query += "VALUES(";
                //query += "@sales_number,";
                //query += "@customer_id,";
                //query += "@date,";
                //query += "@total)";

                //dbHandler.setParameters("@sales_number", sales_number);
                //dbHandler.setParameters("@customer_id", customer_id);
                //dbHandler.setParameters("@date", description);
                //dbHandler.setParameters("@total", price);

                //var result = dbHandler.Insert(query);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
