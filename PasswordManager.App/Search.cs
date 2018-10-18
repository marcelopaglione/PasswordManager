using PasswordManager.Entities;
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
    public partial class Search : Form
    {
        public static AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

        public Search()
        {
            InitializeComponent();
            LoadAutoComplete();
            this.ActiveControl = txtSearchPassword;
        }

        private void LoadAutoComplete()
        {
            txtSearchPassword.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchPassword.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearchPassword.AutoCompleteCustomSource = autoComplete;
        }

        private void SetAutoCompleteMode()
        {
            autoComplete.Add(txtSearchPassword.Text);
        }

        private void CloseWindow(object sender, KeyEventArgs e)
        {
            Functions.CloseWindow(sender, e, this);
        }

        private void btnSearchPassword_Click(object sender, EventArgs e)
        {
            SetAutoCompleteMode();
        }
    }
}
