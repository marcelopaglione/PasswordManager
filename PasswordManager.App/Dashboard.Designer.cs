﻿using System.Windows.Forms;

namespace PasswordManager.App
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnGuide = new System.Windows.Forms.Button();
            this.btnSearchPassword = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExportPasswords = new System.Windows.Forms.Button();
            this.btnImportPasswords = new System.Windows.Forms.Button();
            this.btnNewPassword = new System.Windows.Forms.Button();
            this.btnMasterPassword = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.lblMassege = new System.Windows.Forms.Label();
            this.PasswordsContainerPanel = new System.Windows.Forms.Panel();
            this.PasswordsGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDateUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCopy = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.MenuPanel.SuspendLayout();
            this.PasswordsContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.MenuPanel.Controls.Add(this.btnGuide);
            this.MenuPanel.Controls.Add(this.btnSearchPassword);
            this.MenuPanel.Controls.Add(this.btnLogout);
            this.MenuPanel.Controls.Add(this.btnAbout);
            this.MenuPanel.Controls.Add(this.btnSettings);
            this.MenuPanel.Controls.Add(this.btnExportPasswords);
            this.MenuPanel.Controls.Add(this.btnImportPasswords);
            this.MenuPanel.Controls.Add(this.btnNewPassword);
            this.MenuPanel.Controls.Add(this.btnMasterPassword);
            this.MenuPanel.Controls.Add(this.btnTitle);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(55, 676);
            this.MenuPanel.TabIndex = 0;
            // 
            // btnGuide
            // 
            this.btnGuide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuide.BackColor = System.Drawing.Color.DarkCyan;
            this.btnGuide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuide.FlatAppearance.BorderSize = 0;
            this.btnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuide.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuide.ForeColor = System.Drawing.Color.White;
            this.btnGuide.Image = global::PasswordManager.App.Properties.Resources.question;
            this.btnGuide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuide.Location = new System.Drawing.Point(5, 300);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(43, 50);
            this.btnGuide.TabIndex = 16;
            this.btnGuide.Text = "          Guidelines";
            this.btnGuide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuide.UseVisualStyleBackColor = false;
            this.btnGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // btnSearchPassword
            // 
            this.btnSearchPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchPassword.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSearchPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchPassword.FlatAppearance.BorderSize = 0;
            this.btnSearchPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPassword.ForeColor = System.Drawing.Color.White;
            this.btnSearchPassword.Image = global::PasswordManager.App.Properties.Resources.filter;
            this.btnSearchPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchPassword.Location = new System.Drawing.Point(5, 50);
            this.btnSearchPassword.Name = "btnSearchPassword";
            this.btnSearchPassword.Size = new System.Drawing.Size(43, 50);
            this.btnSearchPassword.TabIndex = 15;
            this.btnSearchPassword.Text = "          Search Password";
            this.btnSearchPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchPassword.UseVisualStyleBackColor = false;
            this.btnSearchPassword.Click += new System.EventHandler(this.btnSearchPassword_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::PasswordManager.App.Properties.Resources.power_button;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(5, 450);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(43, 50);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "          Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = global::PasswordManager.App.Properties.Resources.faq;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(5, 400);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(43, 50);
            this.btnAbout.TabIndex = 13;
            this.btnAbout.Text = "          About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::PasswordManager.App.Properties.Resources.options;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(5, 350);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(43, 50);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.Text = "          Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnExportPasswords
            // 
            this.btnExportPasswords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportPasswords.BackColor = System.Drawing.Color.DarkCyan;
            this.btnExportPasswords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportPasswords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportPasswords.FlatAppearance.BorderSize = 0;
            this.btnExportPasswords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPasswords.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPasswords.ForeColor = System.Drawing.Color.White;
            this.btnExportPasswords.Image = global::PasswordManager.App.Properties.Resources.download;
            this.btnExportPasswords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportPasswords.Location = new System.Drawing.Point(5, 250);
            this.btnExportPasswords.Name = "btnExportPasswords";
            this.btnExportPasswords.Size = new System.Drawing.Size(43, 50);
            this.btnExportPasswords.TabIndex = 11;
            this.btnExportPasswords.Text = "          Export Passwords";
            this.btnExportPasswords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportPasswords.UseVisualStyleBackColor = false;
            this.btnExportPasswords.Click += new System.EventHandler(this.btnExportPasswords_Click);
            // 
            // btnImportPasswords
            // 
            this.btnImportPasswords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportPasswords.BackColor = System.Drawing.Color.DarkCyan;
            this.btnImportPasswords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImportPasswords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportPasswords.FlatAppearance.BorderSize = 0;
            this.btnImportPasswords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportPasswords.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportPasswords.ForeColor = System.Drawing.Color.White;
            this.btnImportPasswords.Image = global::PasswordManager.App.Properties.Resources.cloud_computing;
            this.btnImportPasswords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportPasswords.Location = new System.Drawing.Point(5, 200);
            this.btnImportPasswords.Name = "btnImportPasswords";
            this.btnImportPasswords.Size = new System.Drawing.Size(43, 50);
            this.btnImportPasswords.TabIndex = 10;
            this.btnImportPasswords.Text = "          Import Passwords";
            this.btnImportPasswords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportPasswords.UseVisualStyleBackColor = false;
            this.btnImportPasswords.Click += new System.EventHandler(this.btnImportPasswords_Click);
            // 
            // btnNewPassword
            // 
            this.btnNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewPassword.BackColor = System.Drawing.Color.DarkCyan;
            this.btnNewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPassword.FlatAppearance.BorderSize = 0;
            this.btnNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPassword.ForeColor = System.Drawing.Color.White;
            this.btnNewPassword.Image = global::PasswordManager.App.Properties.Resources.add;
            this.btnNewPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewPassword.Location = new System.Drawing.Point(5, 100);
            this.btnNewPassword.Name = "btnNewPassword";
            this.btnNewPassword.Size = new System.Drawing.Size(43, 50);
            this.btnNewPassword.TabIndex = 9;
            this.btnNewPassword.Text = "          New Password";
            this.btnNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewPassword.UseVisualStyleBackColor = false;
            this.btnNewPassword.Click += new System.EventHandler(this.btnNewPassword_Click);
            // 
            // btnMasterPassword
            // 
            this.btnMasterPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasterPassword.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMasterPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMasterPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasterPassword.FlatAppearance.BorderSize = 0;
            this.btnMasterPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasterPassword.ForeColor = System.Drawing.Color.White;
            this.btnMasterPassword.Image = global::PasswordManager.App.Properties.Resources.document;
            this.btnMasterPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterPassword.Location = new System.Drawing.Point(5, 150);
            this.btnMasterPassword.Name = "btnMasterPassword";
            this.btnMasterPassword.Size = new System.Drawing.Size(43, 50);
            this.btnMasterPassword.TabIndex = 8;
            this.btnMasterPassword.Text = "          Master Password";
            this.btnMasterPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterPassword.UseVisualStyleBackColor = false;
            this.btnMasterPassword.Click += new System.EventHandler(this.btnMasterPassword_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.btnTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTitle.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnTitle.FlatAppearance.BorderSize = 0;
            this.btnTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(140)))), ((int)(((byte)(235)))));
            this.btnTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(140)))), ((int)(((byte)(235)))));
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.ForeColor = System.Drawing.Color.White;
            this.btnTitle.Image = global::PasswordManager.App.Properties.Resources.home;
            this.btnTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.Location = new System.Drawing.Point(5, 5);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(43, 45);
            this.btnTitle.TabIndex = 7;
            this.btnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTitle.UseVisualStyleBackColor = false;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // lblMassege
            // 
            this.lblMassege.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.lblMassege.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMassege.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMassege.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblMassege.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMassege.Location = new System.Drawing.Point(0, 653);
            this.lblMassege.Name = "lblMassege";
            this.lblMassege.Size = new System.Drawing.Size(943, 23);
            this.lblMassege.TabIndex = 17;
            this.lblMassege.Text = " ";
            this.lblMassege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordsContainerPanel
            // 
            this.PasswordsContainerPanel.BackColor = System.Drawing.Color.SlateGray;
            this.PasswordsContainerPanel.Controls.Add(this.lblMassege);
            this.PasswordsContainerPanel.Controls.Add(this.PasswordsGridView);
            this.PasswordsContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordsContainerPanel.Location = new System.Drawing.Point(55, 0);
            this.PasswordsContainerPanel.Name = "PasswordsContainerPanel";
            this.PasswordsContainerPanel.Size = new System.Drawing.Size(943, 676);
            this.PasswordsContainerPanel.TabIndex = 1;
            // 
            // PasswordsGridView
            // 
            this.PasswordsGridView.AllowUserToAddRows = false;
            this.PasswordsGridView.AllowUserToDeleteRows = false;
            this.PasswordsGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.PasswordsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.PasswordsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PasswordsGridView.BackgroundColor = System.Drawing.Color.White;
            this.PasswordsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.NullValue = "-";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PasswordsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.PasswordsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PasswordsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColDateUpdated,
            this.ColName,
            this.ColEmail,
            this.ColUsername,
            this.ColPassword,
            this.ColCopy,
            this.ColUpdate,
            this.ColDelete});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PasswordsGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.PasswordsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PasswordsGridView.EnableHeadersVisualStyles = false;
            this.PasswordsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.PasswordsGridView.Location = new System.Drawing.Point(0, 0);
            this.PasswordsGridView.Name = "PasswordsGridView";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PasswordsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.PasswordsGridView.RowHeadersVisible = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.PasswordsGridView.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.PasswordsGridView.RowTemplate.Height = 30;
            this.PasswordsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.PasswordsGridView.Size = new System.Drawing.Size(943, 676);
            this.PasswordsGridView.TabIndex = 0;
            this.PasswordsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PasswordsGridView_CellContentClick);
            this.PasswordsGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PasswordsGridView_CellMouseEnter);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(140)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle14.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewImageColumn1.Description = "Copy This Password";
            this.dataGridViewImageColumn1.HeaderText = "Copy";
            this.dataGridViewImageColumn1.Image = global::PasswordManager.App.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 73;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.Description = "Update This Password";
            this.dataGridViewImageColumn2.HeaderText = "Update";
            this.dataGridViewImageColumn2.Image = global::PasswordManager.App.Properties.Resources.edit;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 73;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn3.Description = "Delete This Password";
            this.dataGridViewImageColumn3.HeaderText = "Delete";
            this.dataGridViewImageColumn3.Image = global::PasswordManager.App.Properties.Resources.page_delete;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.Width = 73;
            // 
            // ColID
            // 
            this.ColID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.Visible = false;
            this.ColID.Width = 73;
            // 
            // ColDateUpdated
            // 
            this.ColDateUpdated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDateUpdated.HeaderText = "Date Updated";
            this.ColDateUpdated.Name = "ColDateUpdated";
            this.ColDateUpdated.Width = 129;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.Width = 76;
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            // 
            // ColUsername
            // 
            this.ColUsername.HeaderText = "Username";
            this.ColUsername.Name = "ColUsername";
            // 
            // ColPassword
            // 
            this.ColPassword.HeaderText = "Password";
            this.ColPassword.Name = "ColPassword";
            // 
            // ColCopy
            // 
            this.ColCopy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(140)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle10.NullValue")));
            this.ColCopy.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColCopy.Description = "Copy This Password";
            this.ColCopy.HeaderText = "Copy";
            this.ColCopy.Image = global::PasswordManager.App.Properties.Resources.page_copy;
            this.ColCopy.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColCopy.Name = "ColCopy";
            this.ColCopy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCopy.Width = 60;
            // 
            // ColUpdate
            // 
            this.ColUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColUpdate.Description = "Update This Password";
            this.ColUpdate.HeaderText = "Update";
            this.ColUpdate.Image = global::PasswordManager.App.Properties.Resources.page_edit;
            this.ColUpdate.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColUpdate.Name = "ColUpdate";
            this.ColUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColUpdate.Width = 60;
            // 
            // ColDelete
            // 
            this.ColDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColDelete.Description = "Delete This Password";
            this.ColDelete.HeaderText = "Delete";
            this.ColDelete.Image = global::PasswordManager.App.Properties.Resources.page_delete;
            this.ColDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDelete.Width = 60;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(998, 676);
            this.Controls.Add(this.PasswordsContainerPanel);
            this.Controls.Add(this.MenuPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OpenByShortCut);
            this.MenuPanel.ResumeLayout(false);
            this.PasswordsContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel PasswordsContainerPanel;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Button btnMasterPassword;
        private System.Windows.Forms.DataGridView PasswordsGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Button btnExportPasswords;
        private System.Windows.Forms.Button btnImportPasswords;
        private System.Windows.Forms.Button btnNewPassword;
        private System.Windows.Forms.Button btnSearchPassword;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.Label lblMassege;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColDateUpdated;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColEmail;
        private DataGridViewTextBoxColumn ColUsername;
        private DataGridViewTextBoxColumn ColPassword;
        private DataGridViewImageColumn ColCopy;
        private DataGridViewImageColumn ColUpdate;
        private DataGridViewImageColumn ColDelete;
    }
}