using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointofSale.Models;

namespace PointofSale.Util
{
    class DGVHandler
    {
        public static DataGridViewComboBoxColumn CreateInventoryComboBox()
        {
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.DataSource = Inventory.read(null,null);
            combo.DataPropertyName = "inventory_id";
            combo.DisplayMember = "name";
            combo.ValueMember = "inventory_id";
            combo.Name = "inventory_id";
            combo.HeaderText = "Code";
            combo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            return combo;
        }

        //public static DataGridViewComboBoxColumn CreateGLAccountComboBox()
        //{
        //    DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
        //    combo.DataSource = new Account().read();
        //    combo.DataPropertyName = "gl_account_sales_id";
        //    combo.DisplayMember = "account_name";
        //    combo.ValueMember = "account_id";
        //    combo.Name = "account_id";
        //    combo.HeaderText = "Account";
        //    combo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //    return combo;
        //}

        public static DataGridViewComboBoxColumn CreateGenericComboBox<T>(string datapropertyname, string headertext, string valuemember, string name, string displaymember, List<T> list_data)
        {
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.DataSource = list_data;
            combo.DataPropertyName = datapropertyname;
            combo.DisplayMember = displaymember;
            combo.ValueMember = valuemember;
            combo.Name = name;
            combo.HeaderText = headertext;
            combo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            return combo;
        }

        public static DataGridViewTextBoxColumn CreateTextBox(string dataproperty, string headertext, string name, bool is_numbers)
        {
            DataGridViewTextBoxColumn textbox = new DataGridViewTextBoxColumn();
            textbox.DataPropertyName = dataproperty;
            textbox.HeaderText = headertext;
            textbox.Name = name;

            if (is_numbers)
            {
                textbox.DefaultCellStyle.Format = "N2";
                textbox.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            return textbox;
        }

        //public static DataGridViewCheckBoxColumn CreateCheckBoxColumn()
        //{
        //    DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
        //    checkbox.DataPropertyName = nameof(Invoice.is_selected);
        //    checkbox.Name = "is_selected";
        //    checkbox.HeaderText = "Select";
        //    checkbox.ReadOnly = false;
        //    checkbox.Width = 1;
        //    return checkbox;
        //}
    }
}
