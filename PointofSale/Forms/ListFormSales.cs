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
    public partial class ListFormSales : Form
    {
        private static long totalRecords = ModelFunctions.getTotalRecord("sale");
        private const int pageSize = 30;

        public ListFormSales()
        {
            InitializeComponent();
            initializeDataGrid();
        }

        public void readSales()
        {
            bsSales.DataSource = Sales.read(null,null);
        }

        private void initializeDataGrid()
        {
            dgvSales.Columns.Clear();
            dgvSales.Refresh();
            dgvSales.AutoGenerateColumns = false;

            readSales();

            dgvSales.Columns.Add(DGVHandler.CreateTextBox("invoiceNumber", "Invoice Number", "invoiceNumber", false));
            dgvSales.Columns.Add(DGVHandler.CreateTextBox("customerName", "Customer", "customerName", false));
            dgvSales.Columns.Add(DGVHandler.CreateTextBox("date", "Date", "date", false));
            dgvSales.Columns.Add(DGVHandler.CreateTextBox("totalGross", "Total Gross", "totalGross", false));

            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.RowHeadersVisible = false;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            bindingNavigator1.BindingSource = bsSales;
            bsSales.CurrentChanged += new System.EventHandler(bsSales_CurrentChanged);
            bsSales.DataSource = new PageOffsetList(totalRecords, pageSize);
        }

        private void bsSales_CurrentChanged(object sender, EventArgs e)
        {
            int offset = (int)bsSales.Current;

            int startPage = offset;
            int lastPage = pageSize;

            string limitQuery = "LIMIT " + startPage + "," + lastPage;

            List<Sales> records = Sales.read(null, limitQuery);

            dgvSales.DataSource = records;
        }
    }
}
