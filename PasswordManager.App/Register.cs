﻿using PasswordManager.BLL;
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
    public partial class Register : Form
    {
        Users users = new Users();

        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblMassege.BackColor = Color.Transparent;
            lblMassege.ForeColor = Color.FromArgb(67, 140, 235);
            lblMassege.Text = string.Empty;

            if (!Verifier.Text(txtName.Text))
            {
                lblMassege.Text = "Enter Your Name";
                lblMassege.ForeColor = Color.Red;
            }
            else if (!Verifier.Text(txtUsername.Text))
            {
                lblMassege.Text = "Enter Your Username";
                lblMassege.ForeColor = Color.Red;
            }
            else if (!Verifier.Email(txtEmail.Text))
            {
                lblMassege.Text = "Plaese Enter a Valid Email Address.";
                lblMassege.ForeColor = Color.Red;
            }
            else if (!Verifier.Text(txtLoginPass.Text))
            {
                lblMassege.Text = "Enter Your Password. This will be used as your Master Password by default.";
                lblMassege.BackColor = Color.Yellow;
                lblMassege.ForeColor = Color.Red;
            }
            else
            {
                User user = new User()
                {
                    Name = txtName.Text,
                    Username = txtUsername.Text,
                    Email = txtEmail.Text,
                    LoginPassword = txtLoginPass.Text,
                    MasterPassword = txtLoginPass.Text
                };

                if (users.Register(user))
                {
                    lblMassege.Text = "User Registered.";

                    this.Hide();
                    Dashboard dashboard = new Dashboard(user);
                    dashboard.Show();
                }
                else
                {
                    lblMassege.Text = "A user with these credentials is already registered. Please Login or use different Email and Username.";
                    lblMassege.ForeColor = Color.Red;
                }
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}