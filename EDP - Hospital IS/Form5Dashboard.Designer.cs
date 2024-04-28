using System;
using System.Windows.Forms;

namespace EDP___Hospital_IS
{
    partial class Form5Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gunaDataGridViewAppointments = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.LogOutBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.AboutBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SettingsBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ReportsBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.PatientsBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.UsersBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DashboardBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.helloLB = new System.Windows.Forms.Label();
            this.LastNameTB = new System.Windows.Forms.Label();
            this.FirstNameLB = new System.Windows.Forms.Label();
            this.addAppointment = new Guna.UI.WinForms.GunaButton();
            this.addPatient = new Guna.UI.WinForms.GunaButton();
            this.DateTime = new System.Windows.Forms.Label();
            this.newbill = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewAppointments)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1116, 634);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(228, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Appointment Activity";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // gunaDataGridViewAppointments
            // 
            this.gunaDataGridViewAppointments.AllowUserToAddRows = false;
            this.gunaDataGridViewAppointments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridViewAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaDataGridViewAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridViewAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gunaDataGridViewAppointments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.gunaDataGridViewAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridViewAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridViewAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridViewAppointments.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.NullValue = "--";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridViewAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridViewAppointments.EnableHeadersVisualStyles = false;
            this.gunaDataGridViewAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewAppointments.Location = new System.Drawing.Point(219, 322);
            this.gunaDataGridViewAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.gunaDataGridViewAppointments.Name = "gunaDataGridViewAppointments";
            this.gunaDataGridViewAppointments.ReadOnly = true;
            this.gunaDataGridViewAppointments.RowHeadersVisible = false;
            this.gunaDataGridViewAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gunaDataGridViewAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridViewAppointments.Size = new System.Drawing.Size(863, 268);
            this.gunaDataGridViewAppointments.TabIndex = 51;
            this.gunaDataGridViewAppointments.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridViewAppointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewAppointments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridViewAppointments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewAppointments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewAppointments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewAppointments.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.gunaDataGridViewAppointments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewAppointments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.gunaDataGridViewAppointments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridViewAppointments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridViewAppointments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridViewAppointments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridViewAppointments.ThemeStyle.HeaderStyle.Height = 30;
            this.gunaDataGridViewAppointments.ThemeStyle.ReadOnly = true;
            this.gunaDataGridViewAppointments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewAppointments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewAppointments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridViewAppointments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridViewAppointments.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDataGridViewAppointments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewAppointments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridViewAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.gunaPanel1.Controls.Add(this.LogOutBtn);
            this.gunaPanel1.Controls.Add(this.AboutBtn);
            this.gunaPanel1.Controls.Add(this.SettingsBtn);
            this.gunaPanel1.Controls.Add(this.ReportsBtn);
            this.gunaPanel1.Controls.Add(this.PatientsBtn);
            this.gunaPanel1.Controls.Add(this.UsersBtn);
            this.gunaPanel1.Controls.Add(this.DashboardBtn);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 87);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(189, 407);
            this.gunaPanel1.TabIndex = 52;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.AnimationHoverSpeed = 0.07F;
            this.LogOutBtn.AnimationSpeed = 0.03F;
            this.LogOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.LogOutBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.LogOutBtn.BorderColor = System.Drawing.Color.Black;
            this.LogOutBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.LogOutBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.LogOutBtn.CheckedForeColor = System.Drawing.Color.White;
            this.LogOutBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("LogOutBtn.CheckedImage")));
            this.LogOutBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.LogOutBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LogOutBtn.FocusedColor = System.Drawing.Color.Empty;
            this.LogOutBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LogOutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.LogOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogOutBtn.Image")));
            this.LogOutBtn.ImageOffsetX = 10;
            this.LogOutBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.LogOutBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.LogOutBtn.Location = new System.Drawing.Point(0, 310);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.LogOutBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.LogOutBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.LogOutBtn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("LogOutBtn.OnHoverImage")));
            this.LogOutBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.LogOutBtn.OnPressedColor = System.Drawing.Color.Black;
            this.LogOutBtn.Size = new System.Drawing.Size(189, 44);
            this.LogOutBtn.TabIndex = 7;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.TextOffsetX = 5;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.AnimationHoverSpeed = 0.07F;
            this.AboutBtn.AnimationSpeed = 0.03F;
            this.AboutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.AboutBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.AboutBtn.BorderColor = System.Drawing.Color.Black;
            this.AboutBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AboutBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.AboutBtn.CheckedForeColor = System.Drawing.Color.White;
            this.AboutBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("AboutBtn.CheckedImage")));
            this.AboutBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AboutBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AboutBtn.FocusedColor = System.Drawing.Color.Empty;
            this.AboutBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AboutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.AboutBtn.Image = ((System.Drawing.Image)(resources.GetObject("AboutBtn.Image")));
            this.AboutBtn.ImageOffsetX = 10;
            this.AboutBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.AboutBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AboutBtn.Location = new System.Drawing.Point(0, 258);
            this.AboutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.AboutBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.AboutBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.AboutBtn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("AboutBtn.OnHoverImage")));
            this.AboutBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AboutBtn.OnPressedColor = System.Drawing.Color.Black;
            this.AboutBtn.Size = new System.Drawing.Size(189, 44);
            this.AboutBtn.TabIndex = 6;
            this.AboutBtn.Text = "About";
            this.AboutBtn.TextOffsetX = 5;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.AnimationHoverSpeed = 0.07F;
            this.SettingsBtn.AnimationSpeed = 0.03F;
            this.SettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.SettingsBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.SettingsBtn.BorderColor = System.Drawing.Color.Black;
            this.SettingsBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SettingsBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.SettingsBtn.CheckedForeColor = System.Drawing.Color.White;
            this.SettingsBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.CheckedImage")));
            this.SettingsBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SettingsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SettingsBtn.FocusedColor = System.Drawing.Color.Empty;
            this.SettingsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SettingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.SettingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.Image")));
            this.SettingsBtn.ImageOffsetX = 10;
            this.SettingsBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.SettingsBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SettingsBtn.Location = new System.Drawing.Point(0, 207);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.SettingsBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.SettingsBtn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.OnHoverImage")));
            this.SettingsBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SettingsBtn.OnPressedColor = System.Drawing.Color.Black;
            this.SettingsBtn.Size = new System.Drawing.Size(189, 44);
            this.SettingsBtn.TabIndex = 5;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.TextOffsetX = 5;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.AnimationHoverSpeed = 0.07F;
            this.ReportsBtn.AnimationSpeed = 0.03F;
            this.ReportsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.ReportsBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.ReportsBtn.BorderColor = System.Drawing.Color.Black;
            this.ReportsBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ReportsBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.ReportsBtn.CheckedForeColor = System.Drawing.Color.White;
            this.ReportsBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ReportsBtn.CheckedImage")));
            this.ReportsBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ReportsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ReportsBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ReportsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReportsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.ReportsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReportsBtn.Image")));
            this.ReportsBtn.ImageOffsetX = 10;
            this.ReportsBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.ReportsBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ReportsBtn.Location = new System.Drawing.Point(0, 155);
            this.ReportsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.ReportsBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.ReportsBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.ReportsBtn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("ReportsBtn.OnHoverImage")));
            this.ReportsBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ReportsBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ReportsBtn.Size = new System.Drawing.Size(189, 44);
            this.ReportsBtn.TabIndex = 4;
            this.ReportsBtn.Text = "Reports";
            this.ReportsBtn.TextOffsetX = 5;
            this.ReportsBtn.Click += new System.EventHandler(this.ReportsBtn_Click);
            // 
            // PatientsBtn
            // 
            this.PatientsBtn.AnimationHoverSpeed = 0.07F;
            this.PatientsBtn.AnimationSpeed = 0.03F;
            this.PatientsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.PatientsBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.PatientsBtn.BorderColor = System.Drawing.Color.Black;
            this.PatientsBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.PatientsBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.PatientsBtn.CheckedForeColor = System.Drawing.Color.White;
            this.PatientsBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("PatientsBtn.CheckedImage")));
            this.PatientsBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.PatientsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PatientsBtn.FocusedColor = System.Drawing.Color.Empty;
            this.PatientsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PatientsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.PatientsBtn.Image = ((System.Drawing.Image)(resources.GetObject("PatientsBtn.Image")));
            this.PatientsBtn.ImageOffsetX = 10;
            this.PatientsBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.PatientsBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.PatientsBtn.Location = new System.Drawing.Point(0, 103);
            this.PatientsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PatientsBtn.Name = "PatientsBtn";
            this.PatientsBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.PatientsBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.PatientsBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.PatientsBtn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("PatientsBtn.OnHoverImage")));
            this.PatientsBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.PatientsBtn.OnPressedColor = System.Drawing.Color.Black;
            this.PatientsBtn.Size = new System.Drawing.Size(189, 44);
            this.PatientsBtn.TabIndex = 3;
            this.PatientsBtn.Text = "Patients";
            this.PatientsBtn.TextOffsetX = 5;
            this.PatientsBtn.Click += new System.EventHandler(this.PatientsBtn_Click);
            // 
            // UsersBtn
            // 
            this.UsersBtn.AnimationHoverSpeed = 0.07F;
            this.UsersBtn.AnimationSpeed = 0.03F;
            this.UsersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.UsersBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.UsersBtn.BorderColor = System.Drawing.Color.Black;
            this.UsersBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.UsersBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.UsersBtn.CheckedForeColor = System.Drawing.Color.White;
            this.UsersBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("UsersBtn.CheckedImage")));
            this.UsersBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.UsersBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UsersBtn.FocusedColor = System.Drawing.Color.Empty;
            this.UsersBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.UsersBtn.Image = ((System.Drawing.Image)(resources.GetObject("UsersBtn.Image")));
            this.UsersBtn.ImageOffsetX = 10;
            this.UsersBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.UsersBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.UsersBtn.Location = new System.Drawing.Point(0, 52);
            this.UsersBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.UsersBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.UsersBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.UsersBtn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("UsersBtn.OnHoverImage")));
            this.UsersBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.UsersBtn.OnPressedColor = System.Drawing.Color.Black;
            this.UsersBtn.Size = new System.Drawing.Size(189, 44);
            this.UsersBtn.TabIndex = 2;
            this.UsersBtn.Text = "Users";
            this.UsersBtn.TextOffsetX = 5;
            this.UsersBtn.Click += new System.EventHandler(this.UsersBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.AnimationHoverSpeed = 0.07F;
            this.DashboardBtn.AnimationSpeed = 0.03F;
            this.DashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.DashboardBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.DashboardBtn.BorderColor = System.Drawing.Color.Black;
            this.DashboardBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.DashboardBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.DashboardBtn.CheckedForeColor = System.Drawing.Color.White;
            this.DashboardBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("DashboardBtn.CheckedImage")));
            this.DashboardBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.DashboardBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DashboardBtn.FocusedColor = System.Drawing.Color.Empty;
            this.DashboardBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DashboardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.DashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("DashboardBtn.Image")));
            this.DashboardBtn.ImageOffsetX = 10;
            this.DashboardBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.DashboardBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.DashboardBtn.Location = new System.Drawing.Point(0, 0);
            this.DashboardBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.DashboardBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.DashboardBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.DashboardBtn.OnHoverImage = null;
            this.DashboardBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.DashboardBtn.OnPressedColor = System.Drawing.Color.Black;
            this.DashboardBtn.Size = new System.Drawing.Size(189, 44);
            this.DashboardBtn.TabIndex = 1;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.TextOffsetX = 5;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // helloLB
            // 
            this.helloLB.AutoSize = true;
            this.helloLB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloLB.Location = new System.Drawing.Point(947, 32);
            this.helloLB.Name = "helloLB";
            this.helloLB.Size = new System.Drawing.Size(50, 18);
            this.helloLB.TabIndex = 53;
            this.helloLB.Text = "Hello,";
            // 
            // LastNameTB
            // 
            this.LastNameTB.AutoSize = true;
            this.LastNameTB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTB.Location = new System.Drawing.Point(995, 32);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(0, 18);
            this.LastNameTB.TabIndex = 54;
            // 
            // FirstNameLB
            // 
            this.FirstNameLB.AutoSize = true;
            this.FirstNameLB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLB.Location = new System.Drawing.Point(993, 32);
            this.FirstNameLB.Name = "FirstNameLB";
            this.FirstNameLB.Size = new System.Drawing.Size(50, 18);
            this.FirstNameLB.TabIndex = 56;
            this.FirstNameLB.Text = "Hello,";
            this.FirstNameLB.Click += new System.EventHandler(this.label2_Click);
            // 
            // addAppointment
            // 
            this.addAppointment.AnimationHoverSpeed = 0.07F;
            this.addAppointment.AnimationSpeed = 0.03F;
            this.addAppointment.BackColor = System.Drawing.Color.Transparent;
            this.addAppointment.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.addAppointment.BorderColor = System.Drawing.Color.Black;
            this.addAppointment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addAppointment.FocusedColor = System.Drawing.Color.Empty;
            this.addAppointment.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointment.ForeColor = System.Drawing.Color.White;
            this.addAppointment.Image = ((System.Drawing.Image)(resources.GetObject("addAppointment.Image")));
            this.addAppointment.ImageOffsetX = 7;
            this.addAppointment.ImageSize = new System.Drawing.Size(20, 20);
            this.addAppointment.Location = new System.Drawing.Point(239, 117);
            this.addAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addAppointment.Name = "addAppointment";
            this.addAppointment.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.addAppointment.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addAppointment.OnHoverForeColor = System.Drawing.Color.White;
            this.addAppointment.OnHoverImage = null;
            this.addAppointment.OnPressedColor = System.Drawing.Color.Black;
            this.addAppointment.Radius = 10;
            this.addAppointment.Size = new System.Drawing.Size(235, 46);
            this.addAppointment.TabIndex = 57;
            this.addAppointment.Text = "New Appointment";
            this.addAppointment.Click += new System.EventHandler(this.addAppointment_Click);
            // 
            // addPatient
            // 
            this.addPatient.AnimationHoverSpeed = 0.07F;
            this.addPatient.AnimationSpeed = 0.03F;
            this.addPatient.BackColor = System.Drawing.Color.Transparent;
            this.addPatient.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.addPatient.BorderColor = System.Drawing.Color.Black;
            this.addPatient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addPatient.FocusedColor = System.Drawing.Color.Empty;
            this.addPatient.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatient.ForeColor = System.Drawing.Color.White;
            this.addPatient.Image = ((System.Drawing.Image)(resources.GetObject("addPatient.Image")));
            this.addPatient.ImageOffsetX = 7;
            this.addPatient.ImageSize = new System.Drawing.Size(20, 20);
            this.addPatient.Location = new System.Drawing.Point(531, 117);
            this.addPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPatient.Name = "addPatient";
            this.addPatient.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.addPatient.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addPatient.OnHoverForeColor = System.Drawing.Color.White;
            this.addPatient.OnHoverImage = null;
            this.addPatient.OnPressedColor = System.Drawing.Color.Black;
            this.addPatient.Radius = 10;
            this.addPatient.Size = new System.Drawing.Size(235, 46);
            this.addPatient.TabIndex = 58;
            this.addPatient.Text = "New Patient";
            this.addPatient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addPatient.TextOffsetX = 20;
            this.addPatient.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // DateTime
            // 
            this.DateTime.AutoSize = true;
            this.DateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.DateTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime.Location = new System.Drawing.Point(915, 165);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(0, 18);
            this.DateTime.TabIndex = 44;
            // 
            // newbill
            // 
            this.newbill.AnimationHoverSpeed = 0.07F;
            this.newbill.AnimationSpeed = 0.03F;
            this.newbill.BackColor = System.Drawing.Color.Transparent;
            this.newbill.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.newbill.BorderColor = System.Drawing.Color.Black;
            this.newbill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.newbill.FocusedColor = System.Drawing.Color.Empty;
            this.newbill.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newbill.ForeColor = System.Drawing.Color.White;
            this.newbill.Image = ((System.Drawing.Image)(resources.GetObject("newbill.Image")));
            this.newbill.ImageOffsetX = 7;
            this.newbill.ImageSize = new System.Drawing.Size(20, 20);
            this.newbill.Location = new System.Drawing.Point(824, 117);
            this.newbill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newbill.Name = "newbill";
            this.newbill.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.newbill.OnHoverBorderColor = System.Drawing.Color.Black;
            this.newbill.OnHoverForeColor = System.Drawing.Color.White;
            this.newbill.OnHoverImage = null;
            this.newbill.OnPressedColor = System.Drawing.Color.Black;
            this.newbill.Radius = 10;
            this.newbill.Size = new System.Drawing.Size(235, 46);
            this.newbill.TabIndex = 59;
            this.newbill.Text = "Billing";
            this.newbill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newbill.TextOffsetX = 20;
            this.newbill.Click += new System.EventHandler(this.newbill_Click);
            // 
            // Form5Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1112, 629);
            this.Controls.Add(this.newbill);
            this.Controls.Add(this.addPatient);
            this.Controls.Add(this.addAppointment);
            this.Controls.Add(this.FirstNameLB);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.helloLB);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaDataGridViewAppointments);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form5Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewAppointments)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            Form8Users form8 = new Form8Users();
            form8.Show();
            this.Close();
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            Form6Reports form6 = new Form6Reports();
            form6.Show();
            this.Close();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            Form7AboutProgram form7 = new Form7AboutProgram();
            form7.Show();
            this.Close();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label31_Click(object sender, EventArgs e)
        {
           
        }

        private void label29_Click(object sender, EventArgs e)
        {
            
        }

        private void label30_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridViewAppointments;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton LogOutBtn;
        private Guna.UI.WinForms.GunaAdvenceButton AboutBtn;
        private Guna.UI.WinForms.GunaAdvenceButton SettingsBtn;
        private Guna.UI.WinForms.GunaAdvenceButton ReportsBtn;
        private Guna.UI.WinForms.GunaAdvenceButton PatientsBtn;
        private Guna.UI.WinForms.GunaAdvenceButton UsersBtn;
        private Guna.UI.WinForms.GunaAdvenceButton DashboardBtn;
        private Label helloLB;
        private Label LastNameTB;
        private Label FirstNameLB;
        private Guna.UI.WinForms.GunaButton addAppointment;
        private Guna.UI.WinForms.GunaButton addPatient;
        private Label DateTime;
        private Guna.UI.WinForms.GunaButton newbill;
    }
}