
namespace Hospital_management_system
{
    partial class Department
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
            this.components = new System.ComponentModel.Container();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pPanel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pctimg = new System.Windows.Forms.PictureBox();
            this.txtOtime = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOdate = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnREgister = new Guna.UI2.WinForms.Guna2Button();
            this.txtDlocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDcontect = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMS_DBDataSet = new Hospital_management_system.HMS_DBDataSet();
            this.departmentTableAdapter = new Hospital_management_system.HMS_DBDataSetTableAdapters.DepartmentTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dept_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept_Odate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept_Otime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept_Contect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept_Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Panel1.SuspendLayout();
            this.pPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(72, 34);
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
            this.label1.Size = new System.Drawing.Size(301, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department Management";
            // 
            // pPanel1
            // 
            this.pPanel1.BackColor = System.Drawing.Color.Cornsilk;
            this.pPanel1.Controls.Add(this.label2);
            this.pPanel1.Controls.Add(this.button1);
            this.pPanel1.Controls.Add(this.pctimg);
            this.pPanel1.Controls.Add(this.txtOtime);
            this.pPanel1.Controls.Add(this.txtOdate);
            this.pPanel1.Controls.Add(this.btnREgister);
            this.pPanel1.Controls.Add(this.txtDlocation);
            this.pPanel1.Controls.Add(this.txtDcontect);
            this.pPanel1.Controls.Add(this.txtDname);
            this.pPanel1.Controls.Add(this.guna2Button1);
            this.pPanel1.Location = new System.Drawing.Point(72, 72);
            this.pPanel1.Name = "pPanel1";
            this.pPanel1.Size = new System.Drawing.Size(1284, 563);
            this.pPanel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(700, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Department Image :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1075, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pctimg
            // 
            this.pctimg.Location = new System.Drawing.Point(927, 293);
            this.pctimg.Name = "pctimg";
            this.pctimg.Size = new System.Drawing.Size(123, 102);
            this.pctimg.TabIndex = 23;
            this.pctimg.TabStop = false;
            // 
            // txtOtime
            // 
            this.txtOtime.AutoRoundedCorners = true;
            this.txtOtime.BorderRadius = 23;
            this.txtOtime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOtime.DefaultText = "";
            this.txtOtime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOtime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOtime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOtime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOtime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOtime.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtOtime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOtime.Location = new System.Drawing.Point(691, 213);
            this.txtOtime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOtime.Name = "txtOtime";
            this.txtOtime.PasswordChar = '\0';
            this.txtOtime.PlaceholderText = "Open Time";
            this.txtOtime.SelectedText = "";
            this.txtOtime.Size = new System.Drawing.Size(509, 48);
            this.txtOtime.TabIndex = 22;
            // 
            // txtOdate
            // 
            this.txtOdate.AutoRoundedCorners = true;
            this.txtOdate.BorderRadius = 23;
            this.txtOdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOdate.DefaultText = "";
            this.txtOdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOdate.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtOdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOdate.Location = new System.Drawing.Point(39, 213);
            this.txtOdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOdate.Name = "txtOdate";
            this.txtOdate.PasswordChar = '\0';
            this.txtOdate.PlaceholderText = "Open Date";
            this.txtOdate.SelectedText = "";
            this.txtOdate.Size = new System.Drawing.Size(502, 48);
            this.txtOdate.TabIndex = 21;
            // 
            // btnREgister
            // 
            this.btnREgister.AutoRoundedCorners = true;
            this.btnREgister.BackColor = System.Drawing.Color.Transparent;
            this.btnREgister.BorderRadius = 21;
            this.btnREgister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnREgister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnREgister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnREgister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnREgister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.btnREgister.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnREgister.ForeColor = System.Drawing.Color.White;
            this.btnREgister.Location = new System.Drawing.Point(44, 409);
            this.btnREgister.Name = "btnREgister";
            this.btnREgister.Size = new System.Drawing.Size(123, 45);
            this.btnREgister.TabIndex = 11;
            this.btnREgister.Text = "Register";
            this.btnREgister.Click += new System.EventHandler(this.btnREgister_Click);
            // 
            // txtDlocation
            // 
            this.txtDlocation.AutoRoundedCorners = true;
            this.txtDlocation.BorderRadius = 23;
            this.txtDlocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDlocation.DefaultText = "";
            this.txtDlocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDlocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDlocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDlocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDlocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDlocation.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtDlocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDlocation.Location = new System.Drawing.Point(689, 145);
            this.txtDlocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDlocation.Name = "txtDlocation";
            this.txtDlocation.PasswordChar = '\0';
            this.txtDlocation.PlaceholderText = "Location";
            this.txtDlocation.SelectedText = "";
            this.txtDlocation.Size = new System.Drawing.Size(509, 48);
            this.txtDlocation.TabIndex = 8;
            // 
            // txtDcontect
            // 
            this.txtDcontect.AutoRoundedCorners = true;
            this.txtDcontect.BorderRadius = 23;
            this.txtDcontect.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDcontect.DefaultText = "";
            this.txtDcontect.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDcontect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDcontect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDcontect.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDcontect.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDcontect.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtDcontect.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDcontect.Location = new System.Drawing.Point(39, 293);
            this.txtDcontect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDcontect.Name = "txtDcontect";
            this.txtDcontect.PasswordChar = '\0';
            this.txtDcontect.PlaceholderText = "DepartmentrContect Number";
            this.txtDcontect.SelectedText = "";
            this.txtDcontect.Size = new System.Drawing.Size(502, 48);
            this.txtDcontect.TabIndex = 5;
            // 
            // txtDname
            // 
            this.txtDname.AutoRoundedCorners = true;
            this.txtDname.BorderRadius = 23;
            this.txtDname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDname.DefaultText = "";
            this.txtDname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDname.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtDname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDname.Location = new System.Drawing.Point(39, 145);
            this.txtDname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDname.Name = "txtDname";
            this.txtDname.PasswordChar = '\0';
            this.txtDname.PlaceholderText = "`Name";
            this.txtDname.SelectedText = "";
            this.txtDname.Size = new System.Drawing.Size(502, 48);
            this.txtDname.TabIndex = 3;
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
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.hMS_DBDataSet;
            // 
            // hMS_DBDataSet
            // 
            this.hMS_DBDataSet.DataSetName = "HMS_DBDataSet";
            this.hMS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dept_Id,
            this.Dept_Name,
            this.Dept_Location,
            this.Dept_Odate,
            this.Dept_Otime,
            this.Dept_Contect,
            this.Dept_Image,
            this.Update,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(72, 651);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1284, 371);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Dept_Id
            // 
            this.Dept_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dept_Id.HeaderText = "Dept_Id";
            this.Dept_Id.MinimumWidth = 6;
            this.Dept_Id.Name = "Dept_Id";
            this.Dept_Id.Visible = false;
            // 
            // Dept_Name
            // 
            this.Dept_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dept_Name.HeaderText = "Dept_Name";
            this.Dept_Name.MinimumWidth = 6;
            this.Dept_Name.Name = "Dept_Name";
            this.Dept_Name.Visible = false;
            // 
            // Dept_Location
            // 
            this.Dept_Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dept_Location.HeaderText = "Dept_Location";
            this.Dept_Location.MinimumWidth = 6;
            this.Dept_Location.Name = "Dept_Location";
            this.Dept_Location.Visible = false;
            // 
            // Dept_Odate
            // 
            this.Dept_Odate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dept_Odate.HeaderText = "Dept_Odate";
            this.Dept_Odate.MinimumWidth = 6;
            this.Dept_Odate.Name = "Dept_Odate";
            this.Dept_Odate.Visible = false;
            // 
            // Dept_Otime
            // 
            this.Dept_Otime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dept_Otime.HeaderText = "Dept_Otime";
            this.Dept_Otime.MinimumWidth = 6;
            this.Dept_Otime.Name = "Dept_Otime";
            this.Dept_Otime.Visible = false;
            // 
            // Dept_Contect
            // 
            this.Dept_Contect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dept_Contect.HeaderText = "Dept_Contect";
            this.Dept_Contect.MinimumWidth = 6;
            this.Dept_Contect.Name = "Dept_Contect";
            this.Dept_Contect.Visible = false;
            // 
            // Dept_Image
            // 
            this.Dept_Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dept_Image.DataPropertyName = "Image";
            this.Dept_Image.HeaderText = "Dept_Image";
            this.Dept_Image.MinimumWidth = 6;
            this.Dept_Image.Name = "Dept_Image";
            this.Dept_Image.Visible = false;
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
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1046);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department";
            this.Text = "Treatment";
            this.Load += new System.EventHandler(this.Department_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pPanel1.ResumeLayout(false);
            this.pPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pPanel1;
        private Guna.UI2.WinForms.Guna2Button btnREgister;
        private Guna.UI2.WinForms.Guna2TextBox txtDlocation;
        private Guna.UI2.WinForms.Guna2TextBox txtDcontect;
        private Guna.UI2.WinForms.Guna2TextBox txtDname;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtOtime;
        private Guna.UI2.WinForms.Guna2TextBox txtOdate;
        private HMS_DBDataSet hMS_DBDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private HMS_DBDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pctimg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept_Odate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept_Otime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept_Contect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept_Image;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}