using PasswordManager.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.App
{
    public partial class Reminder : Form
    {
        public Reminder()
        {
            InitializeComponent();
        }

        private void Reminder_Load(object sender, EventArgs e)
        {
            lblGuide1.Text = Globals.Information.Guidelines;
        }

        private void CloseWindow(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Functions.CloseWindow(sender, e, this);
            }
        }
    }
}
