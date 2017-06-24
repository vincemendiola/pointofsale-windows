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
using PointofSale.Util;

namespace PointofSale.Forms
{
    public partial class ListFormCustomers : Form
    {
        private static long totalRecords = ModelFunctions.getTotalRecord("customer");
        private const int pageSize = 30;

        public ListFormCustomers()
        {
            InitializeComponent();
            initializeDataGrid();
        }

        private void readInventory()
        {
            bsCustomers.DataSource = Customer.read(null, null);
        }

        private void initializeDataGrid()
        {
            dgvCustomer.Columns.Clear();
            dgvCustomer.Refresh();
            dgvCustomer.AutoGenerateColumns = false;

            readInventory();

            dgvCustomer.Columns.Add(DGVHandler.CreateTextBox("code", "Code", "code", false));
            dgvCustomer.Columns.Add(DGVHandler.CreateTextBox("name", "Name", "name", false));
            dgvCustomer.Columns.Add(DGVHandler.CreateTextBox("address1", "Address 1", "address1", false));
            dgvCustomer.Columns.Add(DGVHandler.CreateTextBox("email", "Email", "email", false));

            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            bindingNavigator1.BindingSource = bsCustomers;
            bsCustomers.CurrentChanged += new System.EventHandler(bsCustomers_CurrentChanged);
            bsCustomers.DataSource = new PageOffsetList(totalRecords, pageSize);
        }

        private void bsCustomers_CurrentChanged(object sender, EventArgs e)
        {
            int offset = (int)bsCustomers.Current;

            int startPage = offset;
            int lastPage = pageSize;

            string limitQuery = "LIMIT " + startPage + "," + lastPage;

            List<Customer> records = Customer.read(null, limitQuery);

            dgvCustomer.DataSource = records;
        }
    }
}
