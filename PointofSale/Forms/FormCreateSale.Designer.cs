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
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.bsInventories = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txQuantity = new System.Windows.Forms.NumericUpDown();
            this.txPrice = new System.Windows.Forms.NumericUpDown();
            this.txDiscount = new System.Windows.Forms.NumericUpDown();
            this.bsSelectedItems = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedItems)).BeginInit();
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
            // FormCreateSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 485);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvItems);
            this.Name = "FormCreateSale";
            this.Text = "FormCreateSale";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedItems)).EndInit();
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
    }
}