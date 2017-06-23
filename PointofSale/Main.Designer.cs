namespace PointofSale
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCreateInventory = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Tables";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreateInventory
            // 
            this.btnCreateInventory.Location = new System.Drawing.Point(36, 95);
            this.btnCreateInventory.Name = "btnCreateInventory";
            this.btnCreateInventory.Size = new System.Drawing.Size(132, 57);
            this.btnCreateInventory.TabIndex = 1;
            this.btnCreateInventory.Text = "Create Inventory";
            this.btnCreateInventory.UseVisualStyleBackColor = true;
            this.btnCreateInventory.Click += new System.EventHandler(this.btnCreateInventory_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "View Inventory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 498);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCreateInventory);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Point of Sale";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCreateInventory;
        private System.Windows.Forms.Button button2;
    }
}

