using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointofSale.Util
{
    public static class MessageBoxHandler
    {
        public static void openBox(string title, string message, MessageBoxIcon msg = MessageBoxIcon.Information)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, msg);
        }

        
    }
}
