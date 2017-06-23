namespace PointofSale.Forms
{
    partial class DialogCreateInventory
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txCode = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txDescription = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txPrice = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.88372F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.11628F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txDescription, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txPrice, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(387, 187);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // txCode
            // 
            this.txCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txCode.Location = new System.Drawing.Point(137, 11);
            this.txCode.Name = "txCode";
            this.txCode.Size = new System.Drawing.Size(247, 20);
            this.txCode.TabIndex = 4;
            // 
            // txName
            // 
            this.txName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txName.Location = new System.Drawing.Point(137, 54);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(247, 20);
            this.txName.TabIndex = 5;
            // 
            // txDescription
            // 
            this.txDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txDescription.Location = new System.Drawing.Point(137, 99);
            this.txDescription.Name = "txDescription";
            this.txDescription.Size = new System.Drawing.Size(247, 20);
            this.txDescription.TabIndex = 6;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(293, 205);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(106, 28);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Save";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txPrice
            // 
            this.txPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txPrice.DecimalPlaces = 2;
            this.txPrice.Location = new System.Drawing.Point(137, 149);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(246, 20);
            this.txPrice.TabIndex = 7;
            this.txPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txPrice.ThousandsSeparator = true;
            // 
            // DialogCreateInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 245);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DialogCreateInventory";
            this.Text = "Add Inventory";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txCode;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txDescription;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.NumericUpDown txPrice;
    }
}