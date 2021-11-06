
namespace ClothingShopManagementSystem.App
{
    partial class Company
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCompanyEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewCompany = new Guna.UI2.WinForms.Guna2Button();
            this.btnCompanyDelete = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompanySearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddPayment = new Guna.UI2.WinForms.Guna2Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dgvEmployeeDetails = new MetroFramework.Controls.MetroGrid();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liabilities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCompanyEdit
            // 
            this.btnCompanyEdit.BorderRadius = 30;
            this.btnCompanyEdit.CheckedState.Parent = this.btnCompanyEdit;
            this.btnCompanyEdit.CustomImages.Parent = this.btnCompanyEdit;
            this.btnCompanyEdit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanyEdit.ForeColor = System.Drawing.Color.White;
            this.btnCompanyEdit.HoverState.Parent = this.btnCompanyEdit;
            this.btnCompanyEdit.Location = new System.Drawing.Point(647, 562);
            this.btnCompanyEdit.Name = "btnCompanyEdit";
            this.btnCompanyEdit.ShadowDecoration.Parent = this.btnCompanyEdit;
            this.btnCompanyEdit.Size = new System.Drawing.Size(128, 63);
            this.btnCompanyEdit.TabIndex = 12;
            this.btnCompanyEdit.Text = "Edit";
            this.btnCompanyEdit.Click += new System.EventHandler(this.btnCompanyEdit_Click);
            // 
            // btnNewCompany
            // 
            this.btnNewCompany.BorderRadius = 30;
            this.btnNewCompany.CheckedState.Parent = this.btnNewCompany;
            this.btnNewCompany.CustomImages.Parent = this.btnNewCompany;
            this.btnNewCompany.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCompany.ForeColor = System.Drawing.Color.White;
            this.btnNewCompany.HoverState.Parent = this.btnNewCompany;
            this.btnNewCompany.Location = new System.Drawing.Point(513, 562);
            this.btnNewCompany.Name = "btnNewCompany";
            this.btnNewCompany.ShadowDecoration.Parent = this.btnNewCompany;
            this.btnNewCompany.Size = new System.Drawing.Size(128, 63);
            this.btnNewCompany.TabIndex = 10;
            this.btnNewCompany.Text = "New Company";
            this.btnNewCompany.Click += new System.EventHandler(this.btnNewCompany_Click);
            // 
            // btnCompanyDelete
            // 
            this.btnCompanyDelete.BorderRadius = 30;
            this.btnCompanyDelete.CheckedState.Parent = this.btnCompanyDelete;
            this.btnCompanyDelete.CustomImages.Parent = this.btnCompanyDelete;
            this.btnCompanyDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.btnCompanyDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanyDelete.ForeColor = System.Drawing.Color.White;
            this.btnCompanyDelete.HoverState.Parent = this.btnCompanyDelete;
            this.btnCompanyDelete.Location = new System.Drawing.Point(781, 562);
            this.btnCompanyDelete.Name = "btnCompanyDelete";
            this.btnCompanyDelete.ShadowDecoration.Parent = this.btnCompanyDelete;
            this.btnCompanyDelete.Size = new System.Drawing.Size(128, 63);
            this.btnCompanyDelete.TabIndex = 11;
            this.btnCompanyDelete.Text = "Delete";
            this.btnCompanyDelete.Click += new System.EventHandler(this.btnCompanyDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(198, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Company Name";
            // 
            // txtCompanySearch
            // 
            this.txtCompanySearch.BorderRadius = 20;
            this.txtCompanySearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompanySearch.DefaultText = "";
            this.txtCompanySearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCompanySearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCompanySearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompanySearch.DisabledState.Parent = this.txtCompanySearch;
            this.txtCompanySearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompanySearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtCompanySearch.FocusedState.Parent = this.txtCompanySearch;
            this.txtCompanySearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanySearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtCompanySearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtCompanySearch.HoverState.Parent = this.txtCompanySearch;
            this.txtCompanySearch.Location = new System.Drawing.Point(29, 59);
            this.txtCompanySearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCompanySearch.Name = "txtCompanySearch";
            this.txtCompanySearch.PasswordChar = '\0';
            this.txtCompanySearch.PlaceholderText = "Search by product name or code";
            this.txtCompanySearch.SelectedText = "";
            this.txtCompanySearch.ShadowDecoration.Parent = this.txtCompanySearch;
            this.txtCompanySearch.Size = new System.Drawing.Size(480, 36);
            this.txtCompanySearch.TabIndex = 8;
            this.txtCompanySearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCompanySearch.TextChanged += new System.EventHandler(this.txtCompanySearch_TextChanged);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.BorderRadius = 10;
            this.btnAddPayment.CheckedState.Parent = this.btnAddPayment;
            this.btnAddPayment.CustomImages.Parent = this.btnAddPayment;
            this.btnAddPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.btnAddPayment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPayment.ForeColor = System.Drawing.Color.White;
            this.btnAddPayment.HoverState.Parent = this.btnAddPayment;
            this.btnAddPayment.Location = new System.Drawing.Point(517, 59);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.ShadowDecoration.Parent = this.btnAddPayment;
            this.btnAddPayment.Size = new System.Drawing.Size(392, 36);
            this.btnAddPayment.TabIndex = 14;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(903, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(40, 38);
            this.iconButton1.TabIndex = 15;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dgvEmployeeDetails
            // 
            this.dgvEmployeeDetails.AllowUserToAddRows = false;
            this.dgvEmployeeDetails.AllowUserToDeleteRows = false;
            this.dgvEmployeeDetails.AllowUserToResizeColumns = false;
            this.dgvEmployeeDetails.AllowUserToResizeRows = false;
            this.dgvEmployeeDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEmployeeDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployeeDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEmployeeDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEmployeeDetails.ColumnHeadersHeight = 40;
            this.dgvEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployeeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.address,
            this.liabilities,
            this.paidAmount});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeDetails.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvEmployeeDetails.EnableHeadersVisualStyles = false;
            this.dgvEmployeeDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvEmployeeDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEmployeeDetails.Location = new System.Drawing.Point(29, 104);
            this.dgvEmployeeDetails.Name = "dgvEmployeeDetails";
            this.dgvEmployeeDetails.ReadOnly = true;
            this.dgvEmployeeDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvEmployeeDetails.RowHeadersWidth = 51;
            this.dgvEmployeeDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEmployeeDetails.RowTemplate.Height = 24;
            this.dgvEmployeeDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeDetails.Size = new System.Drawing.Size(884, 452);
            this.dgvEmployeeDetails.TabIndex = 16;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // liabilities
            // 
            this.liabilities.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.liabilities.DataPropertyName = "liabilities";
            this.liabilities.HeaderText = "Liabilities";
            this.liabilities.MinimumWidth = 6;
            this.liabilities.Name = "liabilities";
            this.liabilities.ReadOnly = true;
            // 
            // paidAmount
            // 
            this.paidAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paidAmount.DataPropertyName = "paidAmount";
            this.paidAmount.HeaderText = "Total paid amount";
            this.paidAmount.MinimumWidth = 6;
            this.paidAmount.Name = "paidAmount";
            this.paidAmount.ReadOnly = true;
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEmployeeDetails);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.btnCompanyEdit);
            this.Controls.Add(this.btnNewCompany);
            this.Controls.Add(this.btnCompanyDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompanySearch);
            this.Name = "Company";
            this.Size = new System.Drawing.Size(943, 671);
            this.Load += new System.EventHandler(this.Company_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnCompanyEdit;
        private Guna.UI2.WinForms.Guna2Button btnNewCompany;
        private Guna.UI2.WinForms.Guna2Button btnCompanyDelete;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtCompanySearch;
        private Guna.UI2.WinForms.Guna2Button btnAddPayment;
        private FontAwesome.Sharp.IconButton iconButton1;
        private MetroFramework.Controls.MetroGrid dgvEmployeeDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn liabilities;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidAmount;
    }
}
