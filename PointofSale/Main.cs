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

namespace PointofSale
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBHandler db = new DBHandler();
            db.Setup_Database();
            MessageBox.Show("Tables Created");
        }

        private void btnCreateInventory_Click(object sender, EventArgs e)
        {
            DialogCreateInventory dialog = new DialogCreateInventory();
            dialog.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListFormInventory form = new ListFormInventory();
            form.Show();
        }
    }
}
