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
    public class Sales : BaseTransaction, ICrud, ICustomer
    {
        DBHandler dbHandler = new DBHandler();

        public int id { get; set; }
        public string transactionNumber { get; set; }
        public string invoiceNumber { get; set; }
        public string officialReceipt { get; set; }
        public int customerId { get; set; }
        public string customerName { get; set; }
        public int cashierId { get; set; }
        public decimal total { get; set; }
        public List<SalesDetail> salesDetails { get; set; }

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

        public static List<Sales> read(string whereQuery, string limitQuery)
        {
            try
            {
                List<Sales> sales = new List<Sales>();

                DBHandler dbHandler = new DBHandler();

                string query = "SELECT ";
                query += " invoicenumber,";
                query += " date,";
                query += " total_gross,";
                query += " customer.name AS customer_name";
                query += " FROM sale ";
                query += " LEFT JOIN customer ON sale.customer_id = customer.id ";

                if (limitQuery != null)
                {
                    query += limitQuery;
                }

                dbHandler.OPEN(query);

                while (dbHandler.reader.Read())
                {
                    Sales sale = new Sales();

                    sale.customerName = DBDataHandler.object_to_string(dbHandler.reader["customer_name"]);
                    sale.invoiceNumber = DBDataHandler.object_to_string(dbHandler.reader["invoicenumber"]);
                    sale.date = Convert.ToDateTime(dbHandler.reader["date"]).Date;
                    sale.totalGross = DBDataHandler.object_to_decimal(dbHandler.reader["total_gross"]);

                    sales.Add(sale);
                }

                dbHandler.CLOSE();

                return sales;
            }
            catch (Exception)
            {
                return null;
            }
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
                    foreach(SalesDetail salesDetail in salesDetails)
                    {
                        if(!salesDetail.save(result))
                        {
                            throw new Exception("Error on Detail");
                        }
                    }

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

    public class SalesDetail : IInventory, ICrudDetail
    {
        DBHandler dbHandler = new DBHandler();

        public int salesId { get; set; }
        public int inventoryId { get; set; }
        public string inventoryCode { get; set; }
        public string inventoryName { get; set; }
        public decimal price { get; set; }
        public decimal quantity { get; set; }
        public decimal discount { get; set; }
        public decimal cost { get; set; }
        public decimal vat { get; set; }
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

        public bool save(long salesId)
        {
            try
            {
                string query = "INSERT sale_detail(";
                query += "sales_id,";
                query += "inventory_id,";
                query += "price,";
                query += "quantity,";
                query += "discount,";
                query += "tax)";

                query += " VALUES(";
                query += "@sales_id,";
                query += "@inventory_id,";
                query += "@price,";
                query += "@quantity,";
                query += "@discount,";
                query += "@tax)";

                dbHandler.setParameters("@sales_id", salesId);
                dbHandler.setParameters("@inventory_id", inventoryId);
                dbHandler.setParameters("@price", price);
                dbHandler.setParameters("@quantity", quantity);
                dbHandler.setParameters("@discount", discount);
                dbHandler.setParameters("@tax", vat);
                
                var result = dbHandler.Insert(query);

                if (result is string)
                {
                    throw new Exception(result);
                }

                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                return false;
            }
        }
    }
}
