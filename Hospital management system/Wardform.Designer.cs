﻿
namespace Hospital_management_system
{
    partial class Wardform
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pPanel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtcharge = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnregister = new Guna.UI2.WinForms.Guna2Button();
            this.txtnumpat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnumdoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnumnurs = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtwname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Panel1.SuspendLayout();
            this.pPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(65, 66);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1284, 41);
            this.guna2Panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(16, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ward Management";
            // 
            // pPanel1
            // 
            this.pPanel1.BackColor = System.Drawing.Color.Cornsilk;
            this.pPanel1.Controls.Add(this.txtcharge);
            this.pPanel1.Controls.Add(this.btnregister);
            this.pPanel1.Controls.Add(this.txtnumpat);
            this.pPanel1.Controls.Add(this.txtnumdoc);
            this.pPanel1.Controls.Add(this.txtnumnurs);
            this.pPanel1.Controls.Add(this.txtwname);
            this.pPanel1.Controls.Add(this.guna2Button1);
            this.pPanel1.Location = new System.Drawing.Point(65, 104);
            this.pPanel1.Name = "pPanel1";
            this.pPanel1.Size = new System.Drawing.Size(1284, 536);
            this.pPanel1.TabIndex = 11;
            // 
            // txtcharge
            // 
            this.txtcharge.AutoRoundedCorners = true;
            this.txtcharge.BorderRadius = 27;
            this.txtcharge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcharge.DefaultText = "";
            this.txtcharge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcharge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcharge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcharge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcharge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcharge.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtcharge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcharge.Location = new System.Drawing.Point(41, 325);
            this.txtcharge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcharge.Name = "txtcharge";
            this.txtcharge.PasswordChar = '\0';
            this.txtcharge.PlaceholderText = "Total Ward Charge";
            this.txtcharge.SelectedText = "";
            this.txtcharge.Size = new System.Drawing.Size(509, 57);
            this.txtcharge.TabIndex = 14;
            // 
            // btnregister
            // 
            this.btnregister.AutoRoundedCorners = true;
            this.btnregister.BackColor = System.Drawing.Color.Transparent;
            this.btnregister.BorderRadius = 21;
            this.btnregister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnregister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnregister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnregister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnregister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.btnregister.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnregister.ForeColor = System.Drawing.Color.White;
            this.btnregister.Location = new System.Drawing.Point(51, 449);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(123, 45);
            this.btnregister.TabIndex = 11;
            this.btnregister.Text = "Register";
            this.btnregister.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // txtnumpat
            // 
            this.txtnumpat.AutoRoundedCorners = true;
            this.txtnumpat.BorderRadius = 27;
            this.txtnumpat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnumpat.DefaultText = "";
            this.txtnumpat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnumpat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnumpat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnumpat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnumpat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnumpat.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtnumpat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnumpat.Location = new System.Drawing.Point(725, 217);
            this.txtnumpat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnumpat.Name = "txtnumpat";
            this.txtnumpat.PasswordChar = '\0';
            this.txtnumpat.PlaceholderText = "Number of Patients";
            this.txtnumpat.SelectedText = "";
            this.txtnumpat.Size = new System.Drawing.Size(509, 57);
            this.txtnumpat.TabIndex = 9;
            // 
            // txtnumdoc
            // 
            this.txtnumdoc.AutoRoundedCorners = true;
            this.txtnumdoc.BorderRadius = 27;
            this.txtnumdoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnumdoc.DefaultText = "";
            this.txtnumdoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnumdoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnumdoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnumdoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnumdoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnumdoc.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtnumdoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnumdoc.Location = new System.Drawing.Point(725, 103);
            this.txtnumdoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnumdoc.Name = "txtnumdoc";
            this.txtnumdoc.PasswordChar = '\0';
            this.txtnumdoc.PlaceholderText = "Number of assign Doctors";
            this.txtnumdoc.SelectedText = "";
            this.txtnumdoc.Size = new System.Drawing.Size(509, 57);
            this.txtnumdoc.TabIndex = 8;
            // 
            // txtnumnurs
            // 
            this.txtnumnurs.AutoRoundedCorners = true;
            this.txtnumnurs.BorderRadius = 27;
            this.txtnumnurs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnumnurs.DefaultText = "";
            this.txtnumnurs.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnumnurs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnumnurs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnumnurs.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnumnurs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnumnurs.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtnumnurs.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnumnurs.Location = new System.Drawing.Point(41, 217);
            this.txtnumnurs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnumnurs.Name = "txtnumnurs";
            this.txtnumnurs.PasswordChar = '\0';
            this.txtnumnurs.PlaceholderText = "Number of Nurses";
            this.txtnumnurs.SelectedText = "";
            this.txtnumnurs.Size = new System.Drawing.Size(509, 57);
            this.txtnumnurs.TabIndex = 5;
            // 
            // txtwname
            // 
            this.txtwname.AutoRoundedCorners = true;
            this.txtwname.BorderRadius = 27;
            this.txtwname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtwname.DefaultText = "";
            this.txtwname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtwname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtwname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtwname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtwname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtwname.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtwname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtwname.Location = new System.Drawing.Point(41, 103);
            this.txtwname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtwname.Name = "txtwname";
            this.txtwname.PasswordChar = '\0';
            this.txtwname.PlaceholderText = "Ward Name";
            this.txtwname.SelectedText = "";
            this.txtwname.Size = new System.Drawing.Size(509, 57);
            this.txtwname.TabIndex = 3;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(41, 30);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Generate Report";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(65, 657);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1284, 339);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Update
            // 
            this.Update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Update.HeaderText = "Update";
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Wardform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1038);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Wardform";
            this.Text = "Wardform";
            this.Load += new System.EventHandler(this.Wardform_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pPanel1;
        private Guna.UI2.WinForms.Guna2Button btnregister;
        private Guna.UI2.WinForms.Guna2TextBox txtnumpat;
        private Guna.UI2.WinForms.Guna2TextBox txtnumdoc;
        private Guna.UI2.WinForms.Guna2TextBox txtnumnurs;
        private Guna.UI2.WinForms.Guna2TextBox txtwname;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtcharge;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}