﻿
namespace Hospital_management_system
{
    partial class Patient
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
            this.pPanel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.combogender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnregister = new Guna.UI2.WinForms.Guna2Button();
            this.txtdob = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtlname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtadd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtage = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtfname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpid = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pPanel1
            // 
            this.pPanel1.BackColor = System.Drawing.Color.Cornsilk;
            this.pPanel1.Controls.Add(this.label5);
            this.pPanel1.Controls.Add(this.combogender);
            this.pPanel1.Controls.Add(this.btnregister);
            this.pPanel1.Controls.Add(this.txtdob);
            this.pPanel1.Controls.Add(this.txtmobile);
            this.pPanel1.Controls.Add(this.txtlname);
            this.pPanel1.Controls.Add(this.txtadd);
            this.pPanel1.Controls.Add(this.txtage);
            this.pPanel1.Controls.Add(this.txtmail);
            this.pPanel1.Controls.Add(this.txtfname);
            this.pPanel1.Controls.Add(this.txtpid);
            this.pPanel1.Controls.Add(this.guna2Button2);
            this.pPanel1.Controls.Add(this.guna2Button1);
            this.pPanel1.Location = new System.Drawing.Point(96, 97);
            this.pPanel1.Name = "pPanel1";
            this.pPanel1.Size = new System.Drawing.Size(1284, 563);
            this.pPanel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(36, 296);
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
            this.combogender.Location = new System.Drawing.Point(132, 290);
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
            this.btnregister.Location = new System.Drawing.Point(57, 486);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(123, 45);
            this.btnregister.TabIndex = 11;
            this.btnregister.Text = "Register";
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // txtdob
            // 
            this.txtdob.AutoRoundedCorners = true;
            this.txtdob.BorderRadius = 23;
            this.txtdob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdob.DefaultText = "";
            this.txtdob.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdob.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdob.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdob.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtdob.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdob.Location = new System.Drawing.Point(691, 235);
            this.txtdob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdob.Name = "txtdob";
            this.txtdob.PasswordChar = '\0';
            this.txtdob.PlaceholderText = "Date of Birth";
            this.txtdob.SelectedText = "";
            this.txtdob.Size = new System.Drawing.Size(509, 48);
            this.txtdob.TabIndex = 10;
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
            this.txtmobile.Location = new System.Drawing.Point(691, 180);
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
            this.txtadd.Location = new System.Drawing.Point(41, 343);
            this.txtadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadd.Name = "txtadd";
            this.txtadd.PasswordChar = '\0';
            this.txtadd.PlaceholderText = "Address";
            this.txtadd.SelectedText = "";
            this.txtadd.Size = new System.Drawing.Size(1159, 87);
            this.txtadd.TabIndex = 6;
            // 
            // txtage
            // 
            this.txtage.AutoRoundedCorners = true;
            this.txtage.BorderRadius = 23;
            this.txtage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtage.DefaultText = "";
            this.txtage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtage.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtage.Location = new System.Drawing.Point(41, 235);
            this.txtage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtage.Name = "txtage";
            this.txtage.PasswordChar = '\0';
            this.txtage.PlaceholderText = "Age";
            this.txtage.SelectedText = "";
            this.txtage.Size = new System.Drawing.Size(502, 48);
            this.txtage.TabIndex = 5;
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
            this.txtmail.Location = new System.Drawing.Point(41, 180);
            this.txtmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmail.Name = "txtmail";
            this.txtmail.PasswordChar = '\0';
            this.txtmail.PlaceholderText = "Email";
            this.txtmail.SelectedText = "";
            this.txtmail.Size = new System.Drawing.Size(502, 48);
            this.txtmail.TabIndex = 4;
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
            // txtpid
            // 
            this.txtpid.AutoRoundedCorners = true;
            this.txtpid.BorderRadius = 23;
            this.txtpid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpid.DefaultText = "";
            this.txtpid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpid.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtpid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpid.Location = new System.Drawing.Point(691, 36);
            this.txtpid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpid.Name = "txtpid";
            this.txtpid.PasswordChar = '\0';
            this.txtpid.PlaceholderText = "Patient ID";
            this.txtpid.SelectedText = "";
            this.txtpid.Size = new System.Drawing.Size(380, 48);
            this.txtpid.TabIndex = 2;
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 21;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(1077, 36);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(123, 45);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "Search";
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
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(96, 59);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1284, 41);
            this.guna2Panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(16, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Management";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 679);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1284, 347);
            this.dataGridView1.TabIndex = 9;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1038);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.pPanel1.ResumeLayout(false);
            this.pPanel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pPanel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox combogender;
        private Guna.UI2.WinForms.Guna2Button btnregister;
        private Guna.UI2.WinForms.Guna2TextBox txtdob;
        private Guna.UI2.WinForms.Guna2TextBox txtmobile;
        private Guna.UI2.WinForms.Guna2TextBox txtlname;
        private Guna.UI2.WinForms.Guna2TextBox txtadd;
        private Guna.UI2.WinForms.Guna2TextBox txtage;
        private Guna.UI2.WinForms.Guna2TextBox txtmail;
        private Guna.UI2.WinForms.Guna2TextBox txtfname;
        private Guna.UI2.WinForms.Guna2TextBox txtpid;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}