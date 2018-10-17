using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager.Globals
{
    public static class Functions
    {
        public static void CloseWindow(object sender, KeyEventArgs e, Object form)
        {
            if (Form.ModifierKeys == Keys.None && e.KeyCode == Keys.Escape)
            {
                ((Form)form).Close();
            }
        }
    }
}