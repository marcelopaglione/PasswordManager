﻿using PasswordManager.Entities;
using PasswordManager.Globals;
using PasswordManager.Services;
using PasswordManager.Theme;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PasswordManager.App
{
    public partial class UpdatePassword : Form
    {
        User user;
        Password password;

        public UpdatePassword(User user, Password password)
        {
            InitializeComponent();

            this.user = user;
            this.password = password;
        }

        private void UpdatePassword_Load(object sender, EventArgs e)
        {
            txtName.Text = password.Name;
            txtEmail.Text = password.Email;
            txtUsername.Text = password.Username;
            txtWebsite.Text = password.Website;
            txtPassword.Text = password.Text;
            rtxtNotes.Text = password.Notes;
            
            btnSave.Enabled = IsEnable();

            try
            {
                List<PasswordHistory> pass = PasswordsService.Instance().GetAllUserPasswordHistory(user, this.password);
                dataGridHistory.Rows.Clear();
                pass.ForEach(p => dataGridHistory.Rows.Add(p.GetToString()));
            }
            catch (Exception ex)
            {
                Messenger.Show(ex.Message + " " + ex.HResult, "Error");
            }            
            
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            password.Name = txtName.Text;
            password.Email = txtEmail.Text;
            password.Username = txtUsername.Text;
            password.Website = txtWebsite.Text;
            password.Text = txtPassword.Text;
            password.Notes = rtxtNotes.Text;
            password.DateModified = DateTime.Now;

            try
            {
                await PasswordsService.Instance().UpdateUserPasswordAsync(user, password);
            }
            catch (Exception ex)
            {
                Messenger.Show(ex.Message + " " + ex.HResult, "Error");
            }
        }

        private void ForSaveBtnEnable(object sender, EventArgs e)
        {
            btnSave.Enabled = IsEnable();
        }

        private bool IsEnable()
        {
            if (Verifier.Text(txtName.Text) && Verifier.Text(txtPassword.Text))
                return true;
            return false;
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                txtPassword.Text = await PasswordsService.Instance().GeneratePasswordAsync(user);
            }
            catch (Exception ex)
            {
                Messenger.Show(ex.Message + " " + ex.HResult, "Error");
            }
        }

        private async void btnOptions_Click(object sender, EventArgs e)
        {
            try
            {
                PasswordGenerateOptions passwordGenerateOptionsForm = new PasswordGenerateOptions(user);

                if (passwordGenerateOptionsForm.ShowDialog() == DialogResult.OK)
                {
                    user.Settings.PasswordOptions = passwordGenerateOptionsForm.passwordOptions;
                    txtPassword.Text = await PasswordsService.Instance().GeneratePasswordAsync(user);
                }
            }
            catch (Exception ex)
            {
                Messenger.Show(ex.Message + " " + ex.HResult, "Error");
            }
        }

        private void CloseWindow(object sender, KeyEventArgs e)
        {
            Functions.CloseWindow(sender, e, this);
        }

        private void buttonReminder_Click(object sender, EventArgs e)
        {
            Entities.Reminder newReminder = new Entities.Reminder();
            newReminder.ReminderText = reminderLabelText.Text;
            newReminder.ShowReminderDate = Convert.ToDateTime(dateTimePickerReminder.Text);
            newReminder.ReminderPassword = this.password;
            object obj = PasswordsService.Instance().AddNewPasswordReminderAsync(newReminder);
            if (obj != null)
            {
                Messenger.Show($"You will be reminbered to '{newReminder.ReminderText}' on '{newReminder.ShowReminderDate}'", "Success");
            }
        }
    }
}
