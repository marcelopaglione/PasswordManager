namespace PasswordManager.App
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.txtSearchPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbOptionEquals = new System.Windows.Forms.RadioButton();
            this.rdbOptionContains = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbLookUsername = new System.Windows.Forms.RadioButton();
            this.rdbLookName = new System.Windows.Forms.RadioButton();
            this.rdbLookEmail = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchPassword = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchPassword
            // 
            this.txtSearchPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtSearchPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.txtSearchPassword.Location = new System.Drawing.Point(87, 19);
            this.txtSearchPassword.Name = "txtSearchPassword";
            this.txtSearchPassword.Size = new System.Drawing.Size(232, 25);
            this.txtSearchPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbOptionEquals);
            this.panel2.Controls.Add(this.rdbOptionContains);
            this.panel2.Location = new System.Drawing.Point(87, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 35);
            this.panel2.TabIndex = 47;
            // 
            // rdbOptionEquals
            // 
            this.rdbOptionEquals.AutoSize = true;
            this.rdbOptionEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbOptionEquals.Location = new System.Drawing.Point(5, 5);
            this.rdbOptionEquals.Name = "rdbOptionEquals";
            this.rdbOptionEquals.Size = new System.Drawing.Size(64, 21);
            this.rdbOptionEquals.TabIndex = 6;
            this.rdbOptionEquals.Text = "Equals";
            this.rdbOptionEquals.UseVisualStyleBackColor = true;
            // 
            // rdbOptionContains
            // 
            this.rdbOptionContains.AutoSize = true;
            this.rdbOptionContains.Checked = true;
            this.rdbOptionContains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbOptionContains.Location = new System.Drawing.Point(81, 5);
            this.rdbOptionContains.Name = "rdbOptionContains";
            this.rdbOptionContains.Size = new System.Drawing.Size(78, 21);
            this.rdbOptionContains.TabIndex = 7;
            this.rdbOptionContains.TabStop = true;
            this.rdbOptionContains.Text = "Contains";
            this.rdbOptionContains.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbLookUsername);
            this.panel1.Controls.Add(this.rdbLookName);
            this.panel1.Controls.Add(this.rdbLookEmail);
            this.panel1.Location = new System.Drawing.Point(87, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 35);
            this.panel1.TabIndex = 46;
            // 
            // rdbLookUsername
            // 
            this.rdbLookUsername.AutoSize = true;
            this.rdbLookUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbLookUsername.Location = new System.Drawing.Point(81, 5);
            this.rdbLookUsername.Name = "rdbLookUsername";
            this.rdbLookUsername.Size = new System.Drawing.Size(86, 21);
            this.rdbLookUsername.TabIndex = 4;
            this.rdbLookUsername.Text = "Username";
            this.rdbLookUsername.UseVisualStyleBackColor = true;
            // 
            // rdbLookName
            // 
            this.rdbLookName.AutoSize = true;
            this.rdbLookName.Checked = true;
            this.rdbLookName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbLookName.Location = new System.Drawing.Point(5, 5);
            this.rdbLookName.Name = "rdbLookName";
            this.rdbLookName.Size = new System.Drawing.Size(61, 21);
            this.rdbLookName.TabIndex = 3;
            this.rdbLookName.TabStop = true;
            this.rdbLookName.Text = "Name";
            this.rdbLookName.UseVisualStyleBackColor = true;
            // 
            // rdbLookEmail
            // 
            this.rdbLookEmail.AutoSize = true;
            this.rdbLookEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbLookEmail.Location = new System.Drawing.Point(186, 5);
            this.rdbLookEmail.Name = "rdbLookEmail";
            this.rdbLookEmail.Size = new System.Drawing.Size(57, 21);
            this.rdbLookEmail.TabIndex = 5;
            this.rdbLookEmail.Text = "Email";
            this.rdbLookEmail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Look For :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Options :";
            // 
            // btnSearchPassword
            // 
            this.btnSearchPassword.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSearchPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchPassword.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSearchPassword.FlatAppearance.BorderSize = 0;
            this.btnSearchPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPassword.ForeColor = System.Drawing.Color.White;
            this.btnSearchPassword.Image = global::PasswordManager.App.Properties.Resources.filter;
            this.btnSearchPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchPassword.Location = new System.Drawing.Point(325, 9);
            this.btnSearchPassword.Name = "btnSearchPassword";
            this.btnSearchPassword.Size = new System.Drawing.Size(45, 45);
            this.btnSearchPassword.TabIndex = 2;
            this.btnSearchPassword.UseVisualStyleBackColor = false;
            this.btnSearchPassword.Click += new System.EventHandler(this.btnSearchPassword_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtSearchPassword);
            this.panel3.Controls.Add(this.btnSearchPassword);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 63);
            this.panel3.TabIndex = 48;
            // 
            // Search
            // 
            this.AcceptButton = this.btnSearchPassword;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(384, 154);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CloseWindow);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtSearchPassword;
        private System.Windows.Forms.Button btnSearchPassword;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.RadioButton rdbOptionEquals;
        public System.Windows.Forms.RadioButton rdbOptionContains;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton rdbLookUsername;
        public System.Windows.Forms.RadioButton rdbLookName;
        public System.Windows.Forms.RadioButton rdbLookEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
    }
}