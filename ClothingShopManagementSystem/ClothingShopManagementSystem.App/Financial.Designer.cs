
namespace ClothingShopManagementSystem.App
{
    partial class Financial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnUpadate = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditExpence = new Guna.UI2.WinForms.Guna2Button();
            this.lblExpenceCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSearchExpancetype = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvExpence = new MetroFramework.Controls.MetroGrid();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costdetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbExpenceType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchExpence = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteExpence = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpenceAmmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddExpence = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSearchExpence = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddexpence = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpence)).BeginInit();
            this.SuspendLayout();
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
            this.iconButton1.Location = new System.Drawing.Point(903, 1);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(40, 38);
            this.iconButton1.TabIndex = 14;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnUpadate
            // 
            this.btnUpadate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpadate.BorderRadius = 30;
            this.btnUpadate.CheckedState.Parent = this.btnUpadate;
            this.btnUpadate.CustomImages.Parent = this.btnUpadate;
            this.btnUpadate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.btnUpadate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpadate.ForeColor = System.Drawing.Color.White;
            this.btnUpadate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.btnUpadate.HoverState.Parent = this.btnUpadate;
            this.btnUpadate.Location = new System.Drawing.Point(107, 425);
            this.btnUpadate.Name = "btnUpadate";
            this.btnUpadate.ShadowDecoration.Parent = this.btnUpadate;
            this.btnUpadate.Size = new System.Drawing.Size(172, 63);
            this.btnUpadate.TabIndex = 47;
            this.btnUpadate.Text = "Update";
            this.btnUpadate.Visible = false;
            this.btnUpadate.Click += new System.EventHandler(this.btnUpadate_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.BorderRadius = 15;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(235)))), ((int)(((byte)(180)))));
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(658, 169);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(144, 64);
            this.btnRefresh.TabIndex = 46;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnEditExpence
            // 
            this.btnEditExpence.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditExpence.BorderRadius = 20;
            this.btnEditExpence.CheckedState.Parent = this.btnEditExpence;
            this.btnEditExpence.CustomImages.Parent = this.btnEditExpence;
            this.btnEditExpence.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.btnEditExpence.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditExpence.ForeColor = System.Drawing.Color.White;
            this.btnEditExpence.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.btnEditExpence.HoverState.Parent = this.btnEditExpence;
            this.btnEditExpence.Location = new System.Drawing.Point(808, 85);
            this.btnEditExpence.Name = "btnEditExpence";
            this.btnEditExpence.ShadowDecoration.Parent = this.btnEditExpence;
            this.btnEditExpence.Size = new System.Drawing.Size(109, 78);
            this.btnEditExpence.TabIndex = 45;
            this.btnEditExpence.Text = "Edit";
            this.btnEditExpence.Click += new System.EventHandler(this.btnEditExpence_Click_1);
            // 
            // lblExpenceCount
            // 
            this.lblExpenceCount.AutoSize = true;
            this.lblExpenceCount.BackColor = System.Drawing.SystemColors.Control;
            this.lblExpenceCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenceCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.lblExpenceCount.Location = new System.Drawing.Point(739, 562);
            this.lblExpenceCount.Name = "lblExpenceCount";
            this.lblExpenceCount.Size = new System.Drawing.Size(20, 24);
            this.lblExpenceCount.TabIndex = 44;
            this.lblExpenceCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(549, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Grand total Expence :";
            // 
            // cmbSearchExpancetype
            // 
            this.cmbSearchExpancetype.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchExpancetype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbSearchExpancetype.FormattingEnabled = true;
            this.cmbSearchExpancetype.Location = new System.Drawing.Point(415, 194);
            this.cmbSearchExpancetype.Name = "cmbSearchExpancetype";
            this.cmbSearchExpancetype.Size = new System.Drawing.Size(237, 35);
            this.cmbSearchExpancetype.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(473, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "Expence type";
            // 
            // dgvExpence
            // 
            this.dgvExpence.AllowUserToAddRows = false;
            this.dgvExpence.AllowUserToDeleteRows = false;
            this.dgvExpence.AllowUserToResizeColumns = false;
            this.dgvExpence.AllowUserToResizeRows = false;
            this.dgvExpence.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvExpence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpence.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvExpence.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvExpence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.Id,
            this.costdetails,
            this.type,
            this.amount});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpence.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvExpence.EnableHeadersVisualStyles = false;
            this.dgvExpence.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvExpence.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvExpence.Location = new System.Drawing.Point(415, 244);
            this.dgvExpence.Name = "dgvExpence";
            this.dgvExpence.ReadOnly = true;
            this.dgvExpence.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpence.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvExpence.RowHeadersWidth = 51;
            this.dgvExpence.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvExpence.RowTemplate.Height = 24;
            this.dgvExpence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpence.Size = new System.Drawing.Size(502, 300);
            this.dgvExpence.TabIndex = 40;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // costdetails
            // 
            this.costdetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costdetails.DataPropertyName = "costdetails";
            this.costdetails.HeaderText = "Details";
            this.costdetails.MinimumWidth = 6;
            this.costdetails.Name = "costdetails";
            this.costdetails.ReadOnly = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // cmbExpenceType
            // 
            this.cmbExpenceType.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpenceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbExpenceType.FormattingEnabled = true;
            this.cmbExpenceType.Location = new System.Drawing.Point(25, 297);
            this.cmbExpenceType.Name = "cmbExpenceType";
            this.cmbExpenceType.Size = new System.Drawing.Size(337, 35);
            this.cmbExpenceType.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(133, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Expence type";
            // 
            // btnSearchExpence
            // 
            this.btnSearchExpence.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearchExpence.BorderRadius = 30;
            this.btnSearchExpence.CheckedState.Parent = this.btnSearchExpence;
            this.btnSearchExpence.CustomImages.Parent = this.btnSearchExpence;
            this.btnSearchExpence.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(235)))), ((int)(((byte)(180)))));
            this.btnSearchExpence.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchExpence.ForeColor = System.Drawing.Color.White;
            this.btnSearchExpence.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.btnSearchExpence.HoverState.Parent = this.btnSearchExpence;
            this.btnSearchExpence.Location = new System.Drawing.Point(658, 85);
            this.btnSearchExpence.Name = "btnSearchExpence";
            this.btnSearchExpence.ShadowDecoration.Parent = this.btnSearchExpence;
            this.btnSearchExpence.Size = new System.Drawing.Size(144, 78);
            this.btnSearchExpence.TabIndex = 37;
            this.btnSearchExpence.Text = "Search";
            this.btnSearchExpence.Click += new System.EventHandler(this.btnSearchExpence_Click_1);
            // 
            // btnDeleteExpence
            // 
            this.btnDeleteExpence.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteExpence.BorderRadius = 30;
            this.btnDeleteExpence.CheckedState.Parent = this.btnDeleteExpence;
            this.btnDeleteExpence.CustomImages.Parent = this.btnDeleteExpence;
            this.btnDeleteExpence.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.btnDeleteExpence.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteExpence.ForeColor = System.Drawing.Color.White;
            this.btnDeleteExpence.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.btnDeleteExpence.HoverState.Parent = this.btnDeleteExpence;
            this.btnDeleteExpence.Location = new System.Drawing.Point(808, 171);
            this.btnDeleteExpence.Name = "btnDeleteExpence";
            this.btnDeleteExpence.ShadowDecoration.Parent = this.btnDeleteExpence;
            this.btnDeleteExpence.Size = new System.Drawing.Size(109, 62);
            this.btnDeleteExpence.TabIndex = 36;
            this.btnDeleteExpence.Text = "Delete";
            this.btnDeleteExpence.Click += new System.EventHandler(this.btnDeleteExpence_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(110, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Expence ammount";
            // 
            // txtExpenceAmmount
            // 
            this.txtExpenceAmmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtExpenceAmmount.BorderRadius = 20;
            this.txtExpenceAmmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExpenceAmmount.DefaultText = "";
            this.txtExpenceAmmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtExpenceAmmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtExpenceAmmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExpenceAmmount.DisabledState.Parent = this.txtExpenceAmmount;
            this.txtExpenceAmmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExpenceAmmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtExpenceAmmount.FocusedState.Parent = this.txtExpenceAmmount;
            this.txtExpenceAmmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpenceAmmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtExpenceAmmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtExpenceAmmount.HoverState.Parent = this.txtExpenceAmmount;
            this.txtExpenceAmmount.Location = new System.Drawing.Point(25, 208);
            this.txtExpenceAmmount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtExpenceAmmount.Name = "txtExpenceAmmount";
            this.txtExpenceAmmount.PasswordChar = '\0';
            this.txtExpenceAmmount.PlaceholderText = "";
            this.txtExpenceAmmount.SelectedText = "";
            this.txtExpenceAmmount.ShadowDecoration.Parent = this.txtExpenceAmmount;
            this.txtExpenceAmmount.Size = new System.Drawing.Size(337, 46);
            this.txtExpenceAmmount.TabIndex = 34;
            this.txtExpenceAmmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddExpence
            // 
            this.btnAddExpence.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddExpence.BorderRadius = 30;
            this.btnAddExpence.CheckedState.Parent = this.btnAddExpence;
            this.btnAddExpence.CustomImages.Parent = this.btnAddExpence;
            this.btnAddExpence.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.btnAddExpence.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpence.ForeColor = System.Drawing.Color.White;
            this.btnAddExpence.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.btnAddExpence.HoverState.Parent = this.btnAddExpence;
            this.btnAddExpence.Location = new System.Drawing.Point(107, 348);
            this.btnAddExpence.Name = "btnAddExpence";
            this.btnAddExpence.ShadowDecoration.Parent = this.btnAddExpence;
            this.btnAddExpence.Size = new System.Drawing.Size(172, 63);
            this.btnAddExpence.TabIndex = 33;
            this.btnAddExpence.Text = "Add";
            this.btnAddExpence.Click += new System.EventHandler(this.btnAddExpence_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(467, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Search by date";
            // 
            // dtpSearchExpence
            // 
            this.dtpSearchExpence.BackColor = System.Drawing.SystemColors.Control;
            this.dtpSearchExpence.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpSearchExpence.BorderRadius = 20;
            this.dtpSearchExpence.BorderThickness = 1;
            this.dtpSearchExpence.CheckedState.Parent = this.dtpSearchExpence;
            this.dtpSearchExpence.CustomFormat = "dd.MM.yyyy";
            this.dtpSearchExpence.FillColor = System.Drawing.Color.White;
            this.dtpSearchExpence.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.dtpSearchExpence.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearchExpence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.dtpSearchExpence.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchExpence.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.dtpSearchExpence.HoverState.Parent = this.dtpSearchExpence;
            this.dtpSearchExpence.Location = new System.Drawing.Point(415, 114);
            this.dtpSearchExpence.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpSearchExpence.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpSearchExpence.Name = "dtpSearchExpence";
            this.dtpSearchExpence.ShadowDecoration.Parent = this.dtpSearchExpence;
            this.dtpSearchExpence.Size = new System.Drawing.Size(237, 46);
            this.dtpSearchExpence.TabIndex = 31;
            this.dtpSearchExpence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpSearchExpence.Value = new System.DateTime(2021, 4, 23, 0, 13, 7, 287);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(104, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Add expence details";
            // 
            // txtAddexpence
            // 
            this.txtAddexpence.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddexpence.BorderRadius = 20;
            this.txtAddexpence.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddexpence.DefaultText = "";
            this.txtAddexpence.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddexpence.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddexpence.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddexpence.DisabledState.Parent = this.txtAddexpence;
            this.txtAddexpence.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddexpence.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtAddexpence.FocusedState.Parent = this.txtAddexpence;
            this.txtAddexpence.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddexpence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtAddexpence.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtAddexpence.HoverState.Parent = this.txtAddexpence;
            this.txtAddexpence.Location = new System.Drawing.Point(25, 116);
            this.txtAddexpence.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAddexpence.Name = "txtAddexpence";
            this.txtAddexpence.PasswordChar = '\0';
            this.txtAddexpence.PlaceholderText = "";
            this.txtAddexpence.SelectedText = "";
            this.txtAddexpence.ShadowDecoration.Parent = this.txtAddexpence;
            this.txtAddexpence.Size = new System.Drawing.Size(337, 46);
            this.txtAddexpence.TabIndex = 29;
            this.txtAddexpence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Financial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpadate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEditExpence);
            this.Controls.Add(this.lblExpenceCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSearchExpancetype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvExpence);
            this.Controls.Add(this.cmbExpenceType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchExpence);
            this.Controls.Add(this.btnDeleteExpence);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExpenceAmmount);
            this.Controls.Add(this.btnAddExpence);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpSearchExpence);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddexpence);
            this.Controls.Add(this.iconButton1);
            this.Name = "Financial";
            this.Size = new System.Drawing.Size(943, 671);
            this.Load += new System.EventHandler(this.Financial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI2.WinForms.Guna2Button btnUpadate;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnEditExpence;
        private System.Windows.Forms.Label lblExpenceCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSearchExpancetype;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroGrid dgvExpence;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn costdetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.ComboBox cmbExpenceType;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSearchExpence;
        private Guna.UI2.WinForms.Guna2Button btnDeleteExpence;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtExpenceAmmount;
        private Guna.UI2.WinForms.Guna2Button btnAddExpence;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSearchExpence;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtAddexpence;
    }
}
