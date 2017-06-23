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
    public partial class ListFormInventory : Form
    {
        private static long totalRecords = ModelFunctions.getTotalRecord("inventory");
        private const int pageSize = 30;

        public ListFormInventory()
        {
            InitializeComponent();

            initializeDataGrid();
        }

        private void readInventory()
        {
            bsInventory.DataSource = Inventory.read(null, null);
        }

        private void initializeDataGrid()
        {
            dgvInventory.Columns.Clear();
            dgvInventory.Refresh();
            dgvInventory.AutoGenerateColumns = false;

            readInventory();

            dgvInventory.Columns.Add(DGVHandler.CreateTextBox("code", "Code", "code", false));
            dgvInventory.Columns.Add(DGVHandler.CreateTextBox("name", "Name", "name", false));
            dgvInventory.Columns.Add(DGVHandler.CreateTextBox("description", "Description", "description", false));
            dgvInventory.Columns.Add(DGVHandler.CreateTextBox("price", "Price", "price", false));

            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            bindingNavigator1.BindingSource = bsInventory;
            bsInventory.CurrentChanged += new System.EventHandler(bsInventory_CurrentChanged);
            bsInventory.DataSource = new PageOffsetList(totalRecords, pageSize);
        }

        private void bsInventory_CurrentChanged(object sender, EventArgs e)
        {
            int offset = (int)bsInventory.Current;

            int startPage = offset;
            int lastPage = pageSize;

            string limitQuery = "LIMIT " + startPage + "," + lastPage;

            List<Inventory> records = Inventory.read(null, limitQuery);

            dgvInventory.DataSource = records;
        }
    }
}
