
namespace ClothingShopManagementSystem.App
{
    partial class History
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbReturn = new MetroFramework.Controls.MetroTabControl();
            this.tbLoginHistory = new MetroFramework.Controls.MetroTabPage();
            this.btnRefreshLogin = new Guna.UI2.WinForms.Guna2Button();
            this.dgvLogin = new MetroFramework.Controls.MetroGrid();
            this.lEmployeeDetail_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ldate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateLoginHistory = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tbSellHistory = new MetroFramework.Controls.MetroTabPage();
            this.lblTotalsell = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.dgvSalesDetails = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeDetail_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpSellHistoryDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.tbReturn.SuspendLayout();
            this.tbLoginHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).BeginInit();
            this.tbSellHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tbReturn
            // 
            this.tbReturn.Controls.Add(this.tbLoginHistory);
            this.tbReturn.Controls.Add(this.tbSellHistory);
            this.tbReturn.ItemSize = new System.Drawing.Size(150, 40);
            this.tbReturn.Location = new System.Drawing.Point(0, 44);
            this.tbReturn.Name = "tbReturn";
            this.tbReturn.SelectedIndex = 1;
            this.tbReturn.Size = new System.Drawing.Size(943, 627);
            this.tbReturn.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbReturn.TabIndex = 1;
            this.tbReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbReturn.UseCustomBackColor = true;
            this.tbReturn.UseCustomForeColor = true;
            this.tbReturn.UseSelectable = true;
            this.tbReturn.UseStyleColors = true;
            // 
            // tbLoginHistory
            // 
            this.tbLoginHistory.BackColor = System.Drawing.SystemColors.Control;
            this.tbLoginHistory.Controls.Add(this.btnRefreshLogin);
            this.tbLoginHistory.Controls.Add(this.dgvLogin);
            this.tbLoginHistory.Controls.Add(this.label2);
            this.tbLoginHistory.Controls.Add(this.dtpDateLoginHistory);
            this.tbLoginHistory.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.tbLoginHistory.HorizontalScrollbarBarColor = true;
            this.tbLoginHistory.HorizontalScrollbarHighlightOnWheel = false;
            this.tbLoginHistory.HorizontalScrollbarSize = 10;
            this.tbLoginHistory.Location = new System.Drawing.Point(4, 44);
            this.tbLoginHistory.Name = "tbLoginHistory";
            this.tbLoginHistory.Size = new System.Drawing.Size(935, 579);
            this.tbLoginHistory.TabIndex = 0;
            this.tbLoginHistory.Text = "Login history";
            this.tbLoginHistory.VerticalScrollbarBarColor = true;
            this.tbLoginHistory.VerticalScrollbarHighlightOnWheel = false;
            this.tbLoginHistory.VerticalScrollbarSize = 10;
            // 
            // btnRefreshLogin
            // 
            this.btnRefreshLogin.BackColor = System.Drawing.Color.White;
            this.btnRefreshLogin.BorderRadius = 20;
            this.btnRefreshLogin.CheckedState.Parent = this.btnRefreshLogin;
            this.btnRefreshLogin.CustomImages.Parent = this.btnRefreshLogin;
            this.btnRefreshLogin.FillColor = System.Drawing.Color.Green;
            this.btnRefreshLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshLogin.ForeColor = System.Drawing.Color.White;
            this.btnRefreshLogin.HoverState.Parent = this.btnRefreshLogin;
            this.btnRefreshLogin.Location = new System.Drawing.Point(704, 106);
            this.btnRefreshLogin.Name = "btnRefreshLogin";
            this.btnRefreshLogin.ShadowDecoration.Parent = this.btnRefreshLogin;
            this.btnRefreshLogin.Size = new System.Drawing.Size(209, 46);
            this.btnRefreshLogin.TabIndex = 22;
            this.btnRefreshLogin.Text = "Refresh";
            this.btnRefreshLogin.Click += new System.EventHandler(this.btnRefreshLogin_Click);
            // 
            // dgvLogin
            // 
            this.dgvLogin.AllowUserToAddRows = false;
            this.dgvLogin.AllowUserToDeleteRows = false;
            this.dgvLogin.AllowUserToResizeColumns = false;
            this.dgvLogin.AllowUserToResizeRows = false;
            this.dgvLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLogin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLogin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lEmployeeDetail_Id,
            this.name,
            this.ldate,
            this.time});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogin.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLogin.EnableHeadersVisualStyles = false;
            this.dgvLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvLogin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLogin.Location = new System.Drawing.Point(24, 180);
            this.dgvLogin.Name = "dgvLogin";
            this.dgvLogin.ReadOnly = true;
            this.dgvLogin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogin.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLogin.RowHeadersWidth = 51;
            this.dgvLogin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLogin.RowTemplate.Height = 24;
            this.dgvLogin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogin.Size = new System.Drawing.Size(889, 300);
            this.dgvLogin.TabIndex = 21;
            // 
            // lEmployeeDetail_Id
            // 
            this.lEmployeeDetail_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lEmployeeDetail_Id.DataPropertyName = "lEmployeeDetail_Id";
            this.lEmployeeDetail_Id.HeaderText = "Employee Id";
            this.lEmployeeDetail_Id.MinimumWidth = 6;
            this.lEmployeeDetail_Id.Name = "lEmployeeDetail_Id";
            this.lEmployeeDetail_Id.ReadOnly = true;
            this.lEmployeeDetail_Id.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Employee name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // ldate
            // 
            this.ldate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ldate.DataPropertyName = "ldate";
            this.ldate.HeaderText = "Date";
            this.ldate.MinimumWidth = 6;
            this.ldate.Name = "ldate";
            this.ldate.ReadOnly = true;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Time";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(415, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Login Date";
            // 
            // dtpDateLoginHistory
            // 
            this.dtpDateLoginHistory.BackColor = System.Drawing.Color.White;
            this.dtpDateLoginHistory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpDateLoginHistory.BorderRadius = 20;
            this.dtpDateLoginHistory.BorderThickness = 1;
            this.dtpDateLoginHistory.CheckedState.Parent = this.dtpDateLoginHistory;
            this.dtpDateLoginHistory.CustomFormat = "dd-MMM-yyyy";
            this.dtpDateLoginHistory.FillColor = System.Drawing.Color.White;
            this.dtpDateLoginHistory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.dtpDateLoginHistory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateLoginHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.dtpDateLoginHistory.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateLoginHistory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.dtpDateLoginHistory.HoverState.Parent = this.dtpDateLoginHistory;
            this.dtpDateLoginHistory.Location = new System.Drawing.Point(346, 106);
            this.dtpDateLoginHistory.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDateLoginHistory.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpDateLoginHistory.Name = "dtpDateLoginHistory";
            this.dtpDateLoginHistory.ShadowDecoration.Parent = this.dtpDateLoginHistory;
            this.dtpDateLoginHistory.Size = new System.Drawing.Size(237, 46);
            this.dtpDateLoginHistory.TabIndex = 7;
            this.dtpDateLoginHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpDateLoginHistory.Value = new System.DateTime(2021, 4, 23, 0, 13, 7, 287);
            this.dtpDateLoginHistory.ValueChanged += new System.EventHandler(this.dtpDateLoginHistory_ValueChanged);
            // 
            // tbSellHistory
            // 
            this.tbSellHistory.Controls.Add(this.lblIncome);
            this.tbSellHistory.Controls.Add(this.lblTotalsell);
            this.tbSellHistory.Controls.Add(this.label1);
            this.tbSellHistory.Controls.Add(this.label3);
            this.tbSellHistory.Controls.Add(this.btnRefresh);
            this.tbSellHistory.Controls.Add(this.dgvSalesDetails);
            this.tbSellHistory.Controls.Add(this.dtpSellHistoryDate);
            this.tbSellHistory.Controls.Add(this.label5);
            this.tbSellHistory.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSellHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.tbSellHistory.HorizontalScrollbarBarColor = true;
            this.tbSellHistory.HorizontalScrollbarHighlightOnWheel = false;
            this.tbSellHistory.HorizontalScrollbarSize = 10;
            this.tbSellHistory.Location = new System.Drawing.Point(4, 44);
            this.tbSellHistory.Name = "tbSellHistory";
            this.tbSellHistory.Size = new System.Drawing.Size(935, 579);
            this.tbSellHistory.TabIndex = 1;
            this.tbSellHistory.Text = "Sell history";
            this.tbSellHistory.VerticalScrollbarBarColor = true;
            this.tbSellHistory.VerticalScrollbarHighlightOnWheel = false;
            this.tbSellHistory.VerticalScrollbarSize = 10;
            // 
            // lblTotalsell
            // 
            this.lblTotalsell.AutoSize = true;
            this.lblTotalsell.BackColor = System.Drawing.Color.White;
            this.lblTotalsell.Location = new System.Drawing.Point(835, 521);
            this.lblTotalsell.Name = "lblTotalsell";
            this.lblTotalsell.Size = new System.Drawing.Size(55, 29);
            this.lblTotalsell.TabIndex = 21;
            this.lblTotalsell.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(654, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Total sell today :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.BorderRadius = 20;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.Green;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(720, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(186, 45);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvSalesDetails
            // 
            this.dgvSalesDetails.AllowUserToAddRows = false;
            this.dgvSalesDetails.AllowUserToDeleteRows = false;
            this.dgvSalesDetails.AllowUserToResizeColumns = false;
            this.dgvSalesDetails.AllowUserToResizeRows = false;
            this.dgvSalesDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSalesDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalesDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSalesDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSalesDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Product_Id,
            this.EmployeeDetail_Id,
            this.customerPhoneNumber,
            this.date,
            this.category,
            this.productCode,
            this.productName,
            this.companyName,
            this.quantity,
            this.unitPrice,
            this.discountAmount,
            this.Total});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSalesDetails.EnableHeadersVisualStyles = false;
            this.dgvSalesDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSalesDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSalesDetails.Location = new System.Drawing.Point(26, 83);
            this.dgvSalesDetails.Name = "dgvSalesDetails";
            this.dgvSalesDetails.ReadOnly = true;
            this.dgvSalesDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSalesDetails.RowHeadersWidth = 51;
            this.dgvSalesDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSalesDetails.RowTemplate.Height = 24;
            this.dgvSalesDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesDetails.Size = new System.Drawing.Size(880, 435);
            this.dgvSalesDetails.TabIndex = 18;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Product_Id
            // 
            this.Product_Id.DataPropertyName = "Product_Id";
            this.Product_Id.HeaderText = "ProductId";
            this.Product_Id.MinimumWidth = 6;
            this.Product_Id.Name = "Product_Id";
            this.Product_Id.ReadOnly = true;
            this.Product_Id.Visible = false;
            this.Product_Id.Width = 125;
            // 
            // EmployeeDetail_Id
            // 
            this.EmployeeDetail_Id.DataPropertyName = "EmployeeDetail_Id";
            this.EmployeeDetail_Id.HeaderText = "empid";
            this.EmployeeDetail_Id.MinimumWidth = 6;
            this.EmployeeDetail_Id.Name = "EmployeeDetail_Id";
            this.EmployeeDetail_Id.ReadOnly = true;
            this.EmployeeDetail_Id.Visible = false;
            this.EmployeeDetail_Id.Width = 125;
            // 
            // customerPhoneNumber
            // 
            this.customerPhoneNumber.DataPropertyName = "customerPhoneNumber";
            this.customerPhoneNumber.HeaderText = "customerphone";
            this.customerPhoneNumber.MinimumWidth = 6;
            this.customerPhoneNumber.Name = "customerPhoneNumber";
            this.customerPhoneNumber.ReadOnly = true;
            this.customerPhoneNumber.Visible = false;
            this.customerPhoneNumber.Width = 125;
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
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // productCode
            // 
            this.productCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productCode.DataPropertyName = "productCode";
            this.productCode.HeaderText = "Code";
            this.productCode.MinimumWidth = 6;
            this.productCode.Name = "productCode";
            this.productCode.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "Name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // companyName
            // 
            this.companyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.companyName.DataPropertyName = "companyName";
            this.companyName.HeaderText = "Company Name";
            this.companyName.MinimumWidth = 6;
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // unitPrice
            // 
            this.unitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitPrice.DataPropertyName = "unitPrice";
            this.unitPrice.HeaderText = "Unit price";
            this.unitPrice.MinimumWidth = 6;
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.ReadOnly = true;
            // 
            // discountAmount
            // 
            this.discountAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.discountAmount.DataPropertyName = "discountAmount";
            this.discountAmount.HeaderText = "Discount";
            this.discountAmount.MinimumWidth = 6;
            this.discountAmount.Name = "discountAmount";
            this.discountAmount.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // dtpSellHistoryDate
            // 
            this.dtpSellHistoryDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpSellHistoryDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.dtpSellHistoryDate.BorderRadius = 20;
            this.dtpSellHistoryDate.BorderThickness = 1;
            this.dtpSellHistoryDate.CheckedState.Parent = this.dtpSellHistoryDate;
            this.dtpSellHistoryDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpSellHistoryDate.FillColor = System.Drawing.Color.White;
            this.dtpSellHistoryDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSellHistoryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSellHistoryDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.dtpSellHistoryDate.HoverState.Parent = this.dtpSellHistoryDate;
            this.dtpSellHistoryDate.Location = new System.Drawing.Point(342, 31);
            this.dtpSellHistoryDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpSellHistoryDate.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.dtpSellHistoryDate.Name = "dtpSellHistoryDate";
            this.dtpSellHistoryDate.ShadowDecoration.Parent = this.dtpSellHistoryDate;
            this.dtpSellHistoryDate.Size = new System.Drawing.Size(248, 46);
            this.dtpSellHistoryDate.TabIndex = 11;
            this.dtpSellHistoryDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpSellHistoryDate.Value = new System.DateTime(2021, 4, 23, 22, 45, 53, 859);
            this.dtpSellHistoryDate.ValueChanged += new System.EventHandler(this.dtpSellHistoryDate_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(442, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date";
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
            this.iconButton1.TabIndex = 13;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Total income today :";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.BackColor = System.Drawing.Color.White;
            this.lblIncome.Location = new System.Drawing.Point(238, 521);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(55, 29);
            this.lblIncome.TabIndex = 21;
            this.lblIncome.Text = "0.00";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.tbReturn);
            this.Name = "History";
            this.Size = new System.Drawing.Size(943, 671);
            this.Load += new System.EventHandler(this.History_Load);
            this.tbReturn.ResumeLayout(false);
            this.tbLoginHistory.ResumeLayout(false);
            this.tbLoginHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).EndInit();
            this.tbSellHistory.ResumeLayout(false);
            this.tbSellHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbReturn;
        private MetroFramework.Controls.MetroTabPage tbLoginHistory;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateLoginHistory;
        private MetroFramework.Controls.MetroTabPage tbSellHistory;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSellHistoryDate;
        private FontAwesome.Sharp.IconButton iconButton1;
        private MetroFramework.Controls.MetroGrid dgvSalesDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeDetail_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalsell;
        private MetroFramework.Controls.MetroGrid dgvLogin;
        private Guna.UI2.WinForms.Guna2Button btnRefreshLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn lEmployeeDetail_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ldate;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label label1;
    }
}
