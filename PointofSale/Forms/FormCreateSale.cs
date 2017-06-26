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
using PointofSale.Globals;

namespace PointofSale.Forms
{
    public partial class FormCreateSale : Form
    {
        private Sales sale;
        private Customer selectedCustomer;
        private Inventory selectedInventory;
        private DateTime dateNow = new DateTime();
        private List<SalesDetail> salesDetails = new List<SalesDetail>();

        public FormCreateSale()
        {
            InitializeComponent();

            readCustomers();
            readInventory();

            initializeUI();
            initializeDataGrid();
        }

        private void initializeUI()
        {
            txQuantity.Maximum = Decimal.MaxValue;
            txPrice.Maximum = Decimal.MaxValue;
            txDiscount.Maximum = Decimal.MaxValue;
        }

        private void readCustomers()
        {
            bsCustomers.DataSource = Customer.read(null, null);
            cbCustomer.DataSource = bsCustomers;
            cbCustomer.DisplayMember = "name";
            cbCustomer.ValueMember = "id";
            cbCustomer.ResetText();
            cbCustomer.SelectedIndex = -1;
            cbCustomer.DropDownStyle = ComboBoxStyle.DropDown;
            cbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void readInventory()
        {
            bsInventories.DataSource = Inventory.read(null, null);
            cbInventory.DataSource = bsInventories;
            cbInventory.DisplayMember = "name";
            cbInventory.ValueMember = "id";
            cbInventory.ResetText();
            cbInventory.SelectedIndex = -1;
            cbInventory.DropDownStyle = ComboBoxStyle.DropDown;
            cbInventory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbInventory.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void initializeDataGrid()
        {
            dgvItems.Columns.Clear();
            dgvItems.Refresh();
            dgvItems.AutoGenerateColumns = false;

            dgvItems.DataSource = bsSelectedItems;

            dgvItems.Columns.Add(DGVHandler.CreateTextBox("inventoryCode", "Code", "inventoryCode", false));
            dgvItems.Columns.Add(DGVHandler.CreateTextBox("inventoryName", "Name", "inventoryName", false));
            dgvItems.Columns.Add(DGVHandler.CreateTextBox("price", "Price", "price", true));
            dgvItems.Columns.Add(DGVHandler.CreateTextBox("quantity", "Quantity", "quantity", false));
            dgvItems.Columns.Add(DGVHandler.CreateTextBox("total", "Total", "total", true));

            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.RowHeadersVisible = false;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            getCurrentSelectedInventory();

            SalesDetail salesDetail = new SalesDetail();

            salesDetail.inventoryCode = selectedInventory.code;
            salesDetail.inventoryName = selectedInventory.name;
            salesDetail.inventoryId = selectedInventory.id;
            salesDetail.price = selectedInventory.price;
            

            validateSelection(ref salesDetail);

            salesDetails.Add(salesDetail);
            bsSelectedItems.DataSource = null;
            bsSelectedItems.DataSource = salesDetails;

            selectedInventory = null;
        }

        private void cbInventory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedInventory = (cbInventory.SelectedItem as Inventory);
            txPrice.Value = selectedInventory.price;
        }

        // Form Controls

        private void getCurrentSelectedInventory()
        {
            selectedInventory = (cbInventory.SelectedItem as Inventory);
        }

        private void getCurrentSelectedCustomer()
        {
            selectedCustomer = (cbCustomer.SelectedItem as Customer);
        }

        private void validateSelection(ref SalesDetail salesDetail)
        {
            try
            {
                if (txQuantity.Value > 0)
                {
                    salesDetail.quantity = txQuantity.Value;
                }

                if (txDiscount.Value > 0)
                {
                    salesDetail.discount = txDiscount.Value;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool validateSales()
        {
            try
            {
                sale = new Sales();

                if (selectedCustomer != null)
                {
                    sale.customerId = selectedCustomer.id;
                }

                sale.date = new DateTime();
                sale.transactionNumber = ModelFunctions.getNextReferenceNumber("sale", "transaction_number");
                sale.officialReceipt = ModelFunctions.getNextReferenceNumber("sale", "official_receipt");
                sale.invoiceNumber = ModelFunctions.getNextReferenceNumber("sale", "invoicenumber");
                sale.totalGross = 1000;

                return true;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
        }

        
        // Computations

        private void setTotal()
        {
            decimal total = 0;

            if (salesDetails.Count == 0) return;

            foreach(SalesDetail saleDetail in salesDetails)
            {
                total += saleDetail.totalGross;
            }

            labelTotal.Text = total.ToString(GlobalVariables.getCurrencyFormat());
        }

        private void setTotalDiscount()
        {
            decimal total = 0;

            if (salesDetails.Count == 0) return;

            foreach (SalesDetail saleDetail in salesDetails)
            {
                total += saleDetail.discountAmount;
            }

            labelTotalDiscount.Text = total.ToString(GlobalVariables.getCurrencyFormat());
        }

        private void setTotalNet()
        {
            decimal total = 0;

            if (salesDetails.Count == 0) return;

            foreach (SalesDetail saleDetail in salesDetails)
            {
                total += saleDetail.total;
            }

            labelTotalNet.Text = total.ToString(GlobalVariables.getCurrencyFormat());
        }

        private void bsSelectedItems_DataSourceChanged(object sender, EventArgs e)
        {
            setTotal();
            setTotalDiscount();
            setTotalNet();
        }

        private void clearSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salesDetails = new List<SalesDetail>();
            bsSelectedItems.DataSource = salesDetails;
        }

        private void btnSaveSales_Click(object sender, EventArgs e)
        {
            try
            {
                if(validateSales() && sale.save())
                {
                    MessageBoxHandler.openBox("Sales Saved", "Success", MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBoxHandler.openBox("Error", err.ToString(), MessageBoxIcon.Error);
            }
        }
    }
}
