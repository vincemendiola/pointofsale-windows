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
using PointofSale.Variables;
using PointofSale.Util;

namespace PointofSale.Forms.Dialogs
{
    public partial class DialogCreateCustomer : Form
    {
        public DialogCreateCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(validateCustomer() && saveCustomer())
            {
                MessageBoxHandler.openBox("Success", "Custoemr saved", MessageBoxIcon.Information);
            }

        }

        private bool validateCustomer()
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool saveCustomer()
        {
            try
            {
                Customer customer = new Customer();

                customer.code = txCode.Text.ToString();
                customer.name = txName.Text.ToString();
                customer.firstName = txFirstName.Text.ToString();
                customer.lastName = txLastName.Text.ToString();
                customer.address1 = txAddress1.Text.ToString();
                customer.email = txEmail.Text.ToString();

                return customer.save();

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
