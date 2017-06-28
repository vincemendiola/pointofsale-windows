using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointofSale.Database
{
    class DBHandler
    {
        public MySqlConnection connection;

        private string server = "localhost";
        private string database = "pointofsale2";
        private string uid = "root";
        private string password = "root";
        private string connection_string;
        private string error_message;

        public MySqlCommand cmd = new MySqlCommand();
        public MySqlDataReader reader;

        public DBHandler()
        {
            Initialize_Connection();
        }

        public dynamic Setup_Database()
        {
            if (Create_Database())
            {
                Initialize_Connection();
                Create_Tables();
                return true;
            }
            else
            {
                return error_message;
            }
        }

        public void setParameters(string param, object value)
        {
            cmd.Parameters.AddWithValue(param, value);
        }

        public bool Initialize_Connection()
        {
            try
            {
                connection_string = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";convert zero datetime=True;Allow Zero Datetime=True;";
                connection = new MySqlConnection(connection_string);

                return true;
            }
            catch (MySqlException)
            {
                return false;
            }

        }

        private void Create_Tables()
        {
            try
            {
                string session = "CREATE TABLE IF NOT EXISTS session(";
                session += "id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,";
                session += "token VARCHAR(60) NOT NULL,";
                session += "user_id INT(6),";
                session += "user_name VARCHAR(60),";
                session += "user_email VARCHAR(60),";
                session += "company_id INT(6),";
                session += "company_name VARCHAR(60))Engine=InnoDB";

                string account = "CREATE TABLE IF NOT EXISTS account(";
                account += "id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,";
                account += "account_id INT(6) UNSIGNED,";
                account += "name_id INT(6) UNSIGNED,";
                account += "account_type_id INT(6) UNSIGNED,";
                account += "bank_id INT(6) UNSIGNED,";
                account += "creditcard_name VARCHAR(250),";
                account += "code VARCHAR(250),";
                account += "description TEXT(1000),";
                account += "company_id INT(6) UNSIGNED,";
                account += "account_type_name VARCHAR(250),";
                account += "bank_name VARCHAR(250),";
                account += "account_name VARCHAR(250))Engine=InnoDB";

                string inventory = "CREATE TABLE IF NOT EXISTS inventory(";
                inventory += "id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,";
                inventory += "inventory_id INT(6),";
                inventory += "name VARCHAR(100),";
                inventory += "code VARCHAR(100),";
                inventory += "description VARCHAR(100),";
                inventory += "gl_account_inventory_id INT(6),";
                inventory += "gl_account_sales_id INT(6),";
                inventory += "item_type INT(6),";
                inventory += "price DECIMAL(17,6) NOT NULL DEFAULT 0.00,";
                inventory += "tax DECIMAL(10,6) NOT NULL DEFAULT 0.00,";
                inventory += "vat_value DECIMAL(10,6) NOT NULL DEFAULT 0.00,";
                inventory += "discount DECIMAL(10,6) NOT NULL DEFAULT 0.00,";
                inventory += "is_sc_pwd_applicable BOOLEAN DEFAULT FALSE,";
                inventory += "company_id INT(6))Engine=InnoDB";

                string customer = "CREATE TABLE IF NOT EXISTS customer(";
                customer += "id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,";
                customer += "customer_id INT(6),";
                customer += "name VARCHAR(60),";
                customer += "first_name VARCHAR(60),";
                customer += "last_name VARCHAR(60),";
                customer += "email VARCHAR(60),";
                customer += "code VARCHAR(60),";
                customer += "address1 VARCHAR(60),";
                customer += "address2 VARCHAR(60),";
                customer += "company_id INT(6),";
                customer += "UNIQUE KEY `id_code` (`code`,`company_id`))Engine=InnoDB";

                string user = "CREATE TABLE IF NOT EXISTS user(";
                user += "id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,";
                user += "user_id INT(6),";
                user += "full_name VARCHAR(60),";
                user += "email VARCHAR(60),";
                user += "employee_code VARCHAR(60),";
                user += "company_id INT(6))Engine=InnoDB";

                string payment_type = "CREATE TABLE IF NOT EXISTS payment_types(";
                payment_type += "id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,";
                payment_type += "payment_type_id INT(6),";
                payment_type += "name VARCHAR(250),";
                payment_type += "company_id int(6),";
                payment_type += "is_deleted BOOLEAN DEFAULT False)Engine=InnoDB";

                string pointofsale = "CREATE TABLE IF NOT EXISTS sale (";
                pointofsale += "id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,";
                pointofsale += "sales_id INT(6),";
                pointofsale += "invoicenumber VARCHAR(50) NOT NULL,";
                pointofsale += "transaction_number VARCHAR(50) NOT NULL,";
                pointofsale += "official_receipt VARCHAR(50) NOT NULL,";
                pointofsale += "customer_id INT(6) NOT NULL,";
                pointofsale += "date DATE NOT NULL,";
                pointofsale += "is_from_offline BOOLEAN NOT NULL DEFAULT TRUE,";
                pointofsale += "company_id INT(5),";
                pointofsale += "cashier_id INT(5),";
                pointofsale += "created_on DATETIME DEFAULT CURRENT_TIMESTAMP,";
                pointofsale += "is_synced BOOLEAN DEFAULT FALSE,";
                pointofsale += "is_held BOOLEAN DEFAULT FALSE,";
                pointofsale += "is_cancelled BOOLEAN DEFAULT FALSE,";
                pointofsale += "is_deleted BOOLEAN DEFAULT FALSE,";
                pointofsale += "is_visible BOOLEAN DEFAULT TRUE,";
                pointofsale += "total_gross DECIMAL(17,6) NOT NULL DEFAULT 0.00,";
                pointofsale += "total_discount DECIMAL(17,6) NOT NULL DEFAULT 0.00,";
                pointofsale += "total_vat DECIMAL(17,6) NOT NULL DEFAULT 0.00,";
                pointofsale += "total_net DECIMAL(17,6) NOT NULL DEFAULT 0.00)Engine=InnoDB";

                string pointofsale_detail = "CREATE TABLE IF NOT EXISTS sale_detail(";
                pointofsale_detail += "id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,";
                pointofsale_detail += "sales_id INT(6) UNSIGNED NOT NULL,";
                pointofsale_detail += "inventory_id INT(6),";
                pointofsale_detail += "quantity DECIMAL(17,6) NOT NULL DEFAULT 0.00,";
                pointofsale_detail += "price DECIMAL(17,6) NOT NULL DEFAULT 0.00,";
                pointofsale_detail += "tax DECIMAL(17,6) NOT NULL DEFAULT 0.00,";
                pointofsale_detail += "discount DECIMAL(17,6) NOT NULL DEFAULT 0.00) Engine=InnoDB";

                nonQuery(user);
                nonQuery(pointofsale);
                nonQuery(pointofsale_detail);
                nonQuery(session);
                nonQuery(inventory);
                nonQuery(customer);
                nonQuery(account);
                nonQuery(payment_type);

            }
            catch (MySqlException err)
            {
                Console.WriteLine(err.ToString());
                Open_Error_Dialog(err.ToString());
            }
        }

        private bool Create_Database()
        {
            try
            {
                connection_string = "SERVER=" + server + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";convert zero datetime=True;Allow Zero Datetime=True;";
                connection = new MySqlConnection(connection_string);
                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = "CREATE DATABASE IF NOT EXISTS accounting";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connection.Close();

                return true;

            }
            catch (MySqlException err)
            {
                error_message = err.Message.ToString();
                Open_Error_Dialog(err.Message.ToString());
                return false;
            }

        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }

        public dynamic Insert(String query)
        {
            try
            {
                if (OpenConnection())
                {
                    //Create Command and Assign Query
                    cmd.Connection = connection;
                    cmd.CommandText = query;

                    //Execute
                    cmd.ExecuteNonQuery();

                    long id = cmd.LastInsertedId;

                    Flush();

                    return id;
                }
                else
                {
                    return 0;
                }
            }
            catch (MySqlException err)
            {
                Console.WriteLine(err.ToString());
                Flush();
                return err.Message.ToString() + err.ToString();
            }
        }

        public bool nonQuery(string cmdText)
        {
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }

                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = cmdText;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.Parameters.Clear();
                connection.Close();

                return true;
            }
            catch (MySqlException err)
            {
                cmd.Parameters.Clear();
                Open_Error_Dialog(err.Message.ToString());

                return false;
            }

        }

        public void OPEN(string cmdtext)
        {
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }

                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = cmdtext;
                cmd.CommandTimeout = 60;
                reader = cmd.ExecuteReader();

            }
            catch (MySqlException err)
            {
                Console.WriteLine(err.Message.ToString());
                MessageBox.Show(err.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CLOSE()
        {
            reader.Close();
            cmd.Dispose();
            connection.Close();
        }

        private void Open_Error_Dialog(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        public void Restore_Database()
        {
            nonQuery("DROP DATABASE accounting");
            Setup_Database();
        }

        private void Flush()
        {
            // Clear
            cmd.Dispose();
            cmd.Parameters.Clear();
            //Close Connection
            CloseConnection();
        }
    }
}
