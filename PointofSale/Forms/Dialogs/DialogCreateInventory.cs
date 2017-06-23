using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointofSale.Models;

namespace PointofSale.Forms
{
    public partial class DialogCreateInventory : Form
    {
        public DialogCreateInventory()
        {
            InitializeComponent();
            txPrice.Maximum = Decimal.MaxValue;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                saveInventory();
            }
        }


        private bool validateForm()
        {
            return true;
        }

        private bool saveInventory()
        {
            try
            {
                Inventory inventory = new Inventory();

                inventory.code = txCode.Text.ToString();
                inventory.description = txDescription.Text.ToString();
                inventory.name = txName.Text.ToString();
                inventory.price = txPrice.Value;

                inventory.save();


                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
