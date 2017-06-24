namespace PointofSale.Forms
{
    partial class FormCreateSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbInventory = new System.Windows.Forms.ComboBox();
            this.txQuantity = new System.Windows.Forms.NumericUpDown();
            this.txPrice = new System.Windows.Forms.NumericUpDown();
            this.txDiscount = new System.Windows.Forms.NumericUpDown();
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.bsInventories = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddItem = new System.Windows.Forms.Button();
            this.bsSelectedItems = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalDiscount = new System.Windows.Forms.Label();
            this.labelTotalVat = new System.Windows.Forms.Label();
            this.labelTotalNet = new System.Windows.Forms.Label();
            this.btnSaveSales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedItems)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(12, 12);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(549, 461);
            this.dgvItems.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.82781F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.17219F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbCustomer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbInventory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txQuantity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txPrice, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txDiscount, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(567, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.82609F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.17391F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(302, 160);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMER";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ITEM";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "QUANTITY";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PRICE";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DISCOUNT";
            // 
            // cbCustomer
            // 
            this.cbCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(89, 4);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(200, 21);
            this.cbCustomer.TabIndex = 5;
            // 
            // cbInventory
            // 
            this.cbInventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbInventory.FormattingEnabled = true;
            this.cbInventory.Location = new System.Drawing.Point(89, 35);
            this.cbInventory.Name = "cbInventory";
            this.cbInventory.Size = new System.Drawing.Size(200, 21);
            this.cbInventory.TabIndex = 6;
            this.cbInventory.SelectionChangeCommitted += new System.EventHandler(this.cbInventory_SelectionChangeCommitted);
            // 
            // txQuantity
            // 
            this.txQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txQuantity.DecimalPlaces = 2;
            this.txQuantity.Location = new System.Drawing.Point(91, 68);
            this.txQuantity.Name = "txQuantity";
            this.txQuantity.Size = new System.Drawing.Size(196, 20);
            this.txQuantity.TabIndex = 7;
            this.txQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txQuantity.ThousandsSeparator = true;
            // 
            // txPrice
            // 
            this.txPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txPrice.DecimalPlaces = 2;
            this.txPrice.Location = new System.Drawing.Point(91, 99);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(196, 20);
            this.txPrice.TabIndex = 8;
            this.txPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txPrice.ThousandsSeparator = true;
            // 
            // txDiscount
            // 
            this.txDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txDiscount.DecimalPlaces = 2;
            this.txDiscount.Location = new System.Drawing.Point(91, 132);
            this.txDiscount.Name = "txDiscount";
            this.txDiscount.Size = new System.Drawing.Size(196, 20);
            this.txDiscount.TabIndex = 9;
            this.txDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txDiscount.ThousandsSeparator = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(665, 178);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(204, 46);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "ADD ITEM";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // bsSelectedItems
            // 
            this.bsSelectedItems.DataSourceChanged += new System.EventHandler(this.bsSelectedItems_DataSourceChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.7351F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.2649F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelTotal, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelTotalDiscount, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelTotalVat, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelTotalNet, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(567, 237);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.82609F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.17391F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(302, 107);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "TOTAL";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "TOTAL DISCOUNT";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "TOTAL VAT";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "TOTAL NET";
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(286, 6);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(13, 13);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "0";
            // 
            // labelTotalDiscount
            // 
            this.labelTotalDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTotalDiscount.AutoSize = true;
            this.labelTotalDiscount.Location = new System.Drawing.Point(286, 32);
            this.labelTotalDiscount.Name = "labelTotalDiscount";
            this.labelTotalDiscount.Size = new System.Drawing.Size(13, 13);
            this.labelTotalDiscount.TabIndex = 5;
            this.labelTotalDiscount.Text = "0";
            // 
            // labelTotalVat
            // 
            this.labelTotalVat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTotalVat.AutoSize = true;
            this.labelTotalVat.Location = new System.Drawing.Point(286, 60);
            this.labelTotalVat.Name = "labelTotalVat";
            this.labelTotalVat.Size = new System.Drawing.Size(13, 13);
            this.labelTotalVat.TabIndex = 6;
            this.labelTotalVat.Text = "0";
            // 
            // labelTotalNet
            // 
            this.labelTotalNet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTotalNet.AutoSize = true;
            this.labelTotalNet.Location = new System.Drawing.Point(286, 87);
            this.labelTotalNet.Name = "labelTotalNet";
            this.labelTotalNet.Size = new System.Drawing.Size(13, 13);
            this.labelTotalNet.TabIndex = 7;
            this.labelTotalNet.Text = "0";
            // 
            // btnSaveSales
            // 
            this.btnSaveSales.Location = new System.Drawing.Point(592, 350);
            this.btnSaveSales.Name = "btnSaveSales";
            this.btnSaveSales.Size = new System.Drawing.Size(280, 52);
            this.btnSaveSales.TabIndex = 4;
            this.btnSaveSales.Text = "POST SALES";
            this.btnSaveSales.UseVisualStyleBackColor = true;
            // 
            // FormCreateSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 485);
            this.Controls.Add(this.btnSaveSales);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvItems);
            this.Name = "FormCreateSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Sales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedItems)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbInventory;
        private System.Windows.Forms.BindingSource bsCustomers;
        private System.Windows.Forms.BindingSource bsInventories;
        private System.Windows.Forms.NumericUpDown txQuantity;
        private System.Windows.Forms.NumericUpDown txPrice;
        private System.Windows.Forms.NumericUpDown txDiscount;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.BindingSource bsSelectedItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalDiscount;
        private System.Windows.Forms.Label labelTotalVat;
        private System.Windows.Forms.Label labelTotalNet;
        private System.Windows.Forms.Button btnSaveSales;
    }
}