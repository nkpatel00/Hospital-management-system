﻿
namespace Hospital_management_system
{
    partial class Staffform
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
            this.Comborole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combogender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnregister = new Guna.UI2.WinForms.Guna2Button();
            this.txtmobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtlname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtadd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtfname = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.guna2Panel1.Location = new System.Drawing.Point(122, 63);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1284, 41);
            this.guna2Panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(16, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Management";
            // 
            // pPanel1
            // 
            this.pPanel1.BackColor = System.Drawing.Color.Cornsilk;
            this.pPanel1.Controls.Add(this.Comborole);
            this.pPanel1.Controls.Add(this.label2);
            this.pPanel1.Controls.Add(this.label5);
            this.pPanel1.Controls.Add(this.combogender);
            this.pPanel1.Controls.Add(this.btnregister);
            this.pPanel1.Controls.Add(this.txtmobile);
            this.pPanel1.Controls.Add(this.txtlname);
            this.pPanel1.Controls.Add(this.txtadd);
            this.pPanel1.Controls.Add(this.txtmail);
            this.pPanel1.Controls.Add(this.txtfname);
            this.pPanel1.Controls.Add(this.guna2Button1);
            this.pPanel1.Location = new System.Drawing.Point(122, 101);
            this.pPanel1.Name = "pPanel1";
            this.pPanel1.Size = new System.Drawing.Size(1284, 496);
            this.pPanel1.TabIndex = 9;
            // 
            // Comborole
            // 
            this.Comborole.AutoRoundedCorners = true;
            this.Comborole.BackColor = System.Drawing.Color.Transparent;
            this.Comborole.BorderRadius = 17;
            this.Comborole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Comborole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comborole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Comborole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Comborole.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Comborole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Comborole.ItemHeight = 30;
            this.Comborole.Items.AddRange(new object[] {
            "Doctor",
            "Receptionist",
            "Nurse",
            "Ward Staff",
            "Cleaning staff"});
            this.Comborole.Location = new System.Drawing.Point(132, 256);
            this.Comborole.Name = "Comborole";
            this.Comborole.Size = new System.Drawing.Size(411, 36);
            this.Comborole.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(47, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Role :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(686, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "Gender :";
            // 
            // combogender
            // 
            this.combogender.AutoRoundedCorners = true;
            this.combogender.BackColor = System.Drawing.Color.Transparent;
            this.combogender.BorderRadius = 17;
            this.combogender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combogender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combogender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combogender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combogender.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.combogender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combogender.ItemHeight = 30;
            this.combogender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.combogender.Location = new System.Drawing.Point(789, 250);
            this.combogender.Name = "combogender";
            this.combogender.Size = new System.Drawing.Size(411, 36);
            this.combogender.TabIndex = 15;
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
            this.btnregister.Location = new System.Drawing.Point(57, 433);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(123, 45);
            this.btnregister.TabIndex = 11;
            this.btnregister.Text = "Register";
            this.btnregister.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // txtmobile
            // 
            this.txtmobile.AutoRoundedCorners = true;
            this.txtmobile.BorderRadius = 23;
            this.txtmobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmobile.DefaultText = "";
            this.txtmobile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmobile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmobile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmobile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmobile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmobile.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtmobile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmobile.Location = new System.Drawing.Point(691, 195);
            this.txtmobile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.PasswordChar = '\0';
            this.txtmobile.PlaceholderText = "Mobile Number";
            this.txtmobile.SelectedText = "";
            this.txtmobile.Size = new System.Drawing.Size(509, 48);
            this.txtmobile.TabIndex = 9;
            // 
            // txtlname
            // 
            this.txtlname.AutoRoundedCorners = true;
            this.txtlname.BorderRadius = 23;
            this.txtlname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlname.DefaultText = "";
            this.txtlname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtlname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtlname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlname.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtlname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlname.Location = new System.Drawing.Point(691, 124);
            this.txtlname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtlname.Name = "txtlname";
            this.txtlname.PasswordChar = '\0';
            this.txtlname.PlaceholderText = "Last Name";
            this.txtlname.SelectedText = "";
            this.txtlname.Size = new System.Drawing.Size(509, 48);
            this.txtlname.TabIndex = 8;
            // 
            // txtadd
            // 
            this.txtadd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtadd.DefaultText = "";
            this.txtadd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtadd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtadd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtadd.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtadd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtadd.Location = new System.Drawing.Point(41, 308);
            this.txtadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadd.Name = "txtadd";
            this.txtadd.PasswordChar = '\0';
            this.txtadd.PlaceholderText = "Address";
            this.txtadd.SelectedText = "";
            this.txtadd.Size = new System.Drawing.Size(1159, 87);
            this.txtadd.TabIndex = 6;
            // 
            // txtmail
            // 
            this.txtmail.AutoRoundedCorners = true;
            this.txtmail.BorderRadius = 23;
            this.txtmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmail.DefaultText = "";
            this.txtmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmail.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmail.Location = new System.Drawing.Point(41, 195);
            this.txtmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmail.Name = "txtmail";
            this.txtmail.PasswordChar = '\0';
            this.txtmail.PlaceholderText = "Email";
            this.txtmail.SelectedText = "";
            this.txtmail.Size = new System.Drawing.Size(502, 48);
            this.txtmail.TabIndex = 5;
            // 
            // txtfname
            // 
            this.txtfname.AutoRoundedCorners = true;
            this.txtfname.BorderRadius = 23;
            this.txtfname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfname.DefaultText = "";
            this.txtfname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfname.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtfname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfname.Location = new System.Drawing.Point(41, 124);
            this.txtfname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfname.Name = "txtfname";
            this.txtfname.PasswordChar = '\0';
            this.txtfname.PlaceholderText = "First Name";
            this.txtfname.SelectedText = "";
            this.txtfname.Size = new System.Drawing.Size(502, 48);
            this.txtfname.TabIndex = 3;
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
            this.guna2Button1.Location = new System.Drawing.Point(28, 36);
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
            this.dataGridView1.Location = new System.Drawing.Point(122, 604);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1284, 364);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Staffform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1038);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staffform";
            this.Text = "Staffform";
            this.Load += new System.EventHandler(this.Staffform_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pPanel1.ResumeLayout(false);
            this.pPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pPanel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox combogender;
        private Guna.UI2.WinForms.Guna2Button btnregister;
        private Guna.UI2.WinForms.Guna2TextBox txtmobile;
        private Guna.UI2.WinForms.Guna2TextBox txtlname;
        private Guna.UI2.WinForms.Guna2TextBox txtadd;
        private Guna.UI2.WinForms.Guna2TextBox txtmail;
        private Guna.UI2.WinForms.Guna2TextBox txtfname;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox Comborole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}