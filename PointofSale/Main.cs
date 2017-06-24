using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointofSale.Database;
using PointofSale.Forms;
using PointofSale.Forms.Dialogs;

namespace PointofSale
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogCreateInventory dialog = new DialogCreateInventory();
            dialog.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogCreateCustomer dialog = new DialogCreateCustomer();
            dialog.ShowDialog();
        }

        private void inventoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListFormInventory form = new ListFormInventory();
            form.Show();
        }

        private void initializeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBHandler db = new DBHandler();
            db.Setup_Database();
            MessageBox.Show("Tables Created");
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListFormCustomers form = new ListFormCustomers();
            form.Show();
        }
    }
}
