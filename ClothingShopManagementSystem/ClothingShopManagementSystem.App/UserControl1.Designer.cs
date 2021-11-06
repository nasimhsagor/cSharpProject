
namespace ClothingShopManagementSystem.App
{
    partial class UcCart
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
            this.txtCartSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbCartProductName = new System.Windows.Forms.ListBox();
            this.cmbCartCatagory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCartProductSize = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.udCartProductQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.lblCartTotalPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSell = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvInsideCart = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCartSoldBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.udCartProductQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsideCart)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCartSearch
            // 
            this.txtCartSearch.BorderRadius = 20;
            this.txtCartSearch.BorderThickness = 2;
            this.txtCartSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCartSearch.DefaultText = "";
            this.txtCartSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCartSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCartSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCartSearch.DisabledState.Parent = this.txtCartSearch;
            this.txtCartSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCartSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtCartSearch.FocusedState.Parent = this.txtCartSearch;
            this.txtCartSearch.FocusedState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCartSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtCartSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtCartSearch.HoverState.Parent = this.txtCartSearch;
            this.txtCartSearch.Location = new System.Drawing.Point(22, 95);
            this.txtCartSearch.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtCartSearch.Name = "txtCartSearch";
            this.txtCartSearch.PasswordChar = '\0';
            this.txtCartSearch.PlaceholderText = "Search by product name or code";
            this.txtCartSearch.SelectedText = "";
            this.txtCartSearch.ShadowDecoration.Parent = this.txtCartSearch;
            this.txtCartSearch.Size = new System.Drawing.Size(340, 52);
            this.txtCartSearch.TabIndex = 0;
            this.txtCartSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCartProductName
            // 
            this.lbCartProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCartProductName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCartProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.lbCartProductName.FormattingEnabled = true;
            this.lbCartProductName.ItemHeight = 24;
            this.lbCartProductName.Location = new System.Drawing.Point(22, 186);
            this.lbCartProductName.Name = "lbCartProductName";
            this.lbCartProductName.Size = new System.Drawing.Size(340, 122);
            this.lbCartProductName.TabIndex = 1;
            // 
            // cmbCartCatagory
            // 
            this.cmbCartCatagory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCartCatagory.BorderRadius = 20;
            this.cmbCartCatagory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCartCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCartCatagory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCartCatagory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCartCatagory.FocusedState.Parent = this.cmbCartCatagory;
            this.cmbCartCatagory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCartCatagory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCartCatagory.FormattingEnabled = true;
            this.cmbCartCatagory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCartCatagory.HoverState.Parent = this.cmbCartCatagory;
            this.cmbCartCatagory.ItemHeight = 30;
            this.cmbCartCatagory.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCartCatagory.ItemsAppearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCartCatagory.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbCartCatagory.ItemsAppearance.Parent = this.cmbCartCatagory;
            this.cmbCartCatagory.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbCartCatagory.ItemsAppearance.SelectedFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCartCatagory.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCartCatagory.Location = new System.Drawing.Point(433, 100);
            this.cmbCartCatagory.Name = "cmbCartCatagory";
            this.cmbCartCatagory.ShadowDecoration.Parent = this.cmbCartCatagory;
            this.cmbCartCatagory.Size = new System.Drawing.Size(226, 36);
            this.cmbCartCatagory.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.lbl.Location = new System.Drawing.Point(504, 63);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(84, 24);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Catagory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(523, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Size";
            // 
            // cmbCartProductSize
            // 
            this.cmbCartProductSize.BackColor = System.Drawing.Color.Transparent;
            this.cmbCartProductSize.BorderRadius = 20;
            this.cmbCartProductSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCartProductSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCartProductSize.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCartProductSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCartProductSize.FocusedState.Parent = this.cmbCartProductSize;
            this.cmbCartProductSize.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCartProductSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCartProductSize.FormattingEnabled = true;
            this.cmbCartProductSize.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCartProductSize.HoverState.Parent = this.cmbCartProductSize;
            this.cmbCartProductSize.ItemHeight = 30;
            this.cmbCartProductSize.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCartProductSize.ItemsAppearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCartProductSize.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbCartProductSize.ItemsAppearance.Parent = this.cmbCartProductSize;
            this.cmbCartProductSize.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbCartProductSize.ItemsAppearance.SelectedFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCartProductSize.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCartProductSize.Location = new System.Drawing.Point(431, 185);
            this.cmbCartProductSize.Name = "cmbCartProductSize";
            this.cmbCartProductSize.ShadowDecoration.Parent = this.cmbCartProductSize;
            this.cmbCartProductSize.Size = new System.Drawing.Size(226, 36);
            this.cmbCartProductSize.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(500, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity";
            // 
            // udCartProductQuantity
            // 
            this.udCartProductQuantity.BackColor = System.Drawing.Color.Transparent;
            this.udCartProductQuantity.BorderRadius = 20;
            this.udCartProductQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.udCartProductQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.udCartProductQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.udCartProductQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.udCartProductQuantity.DisabledState.Parent = this.udCartProductQuantity;
            this.udCartProductQuantity.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.udCartProductQuantity.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.udCartProductQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.udCartProductQuantity.FocusedState.Parent = this.udCartProductQuantity;
            this.udCartProductQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udCartProductQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.udCartProductQuantity.Location = new System.Drawing.Point(433, 272);
            this.udCartProductQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.udCartProductQuantity.Name = "udCartProductQuantity";
            this.udCartProductQuantity.ShadowDecoration.Parent = this.udCartProductQuantity;
            this.udCartProductQuantity.Size = new System.Drawing.Size(226, 36);
            this.udCartProductQuantity.TabIndex = 7;
            this.udCartProductQuantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.udCartProductQuantity.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.lblCartTotalPrice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnSell);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgvInsideCart);
            this.panel1.Location = new System.Drawing.Point(3, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 345);
            this.panel1.TabIndex = 8;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BorderRadius = 30;
            this.btnAddToCart.CheckedState.Parent = this.btnAddToCart;
            this.btnAddToCart.CustomImages.Parent = this.btnAddToCart;
            this.btnAddToCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.btnAddToCart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.btnAddToCart.HoverState.Parent = this.btnAddToCart;
            this.btnAddToCart.Location = new System.Drawing.Point(692, 245);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.ShadowDecoration.Parent = this.btnAddToCart;
            this.btnAddToCart.Size = new System.Drawing.Size(226, 63);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add to cart";
            // 
            // lblCartTotalPrice
            // 
            this.lblCartTotalPrice.AutoSize = true;
            this.lblCartTotalPrice.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.lblCartTotalPrice.Location = new System.Drawing.Point(720, 284);
            this.lblCartTotalPrice.Name = "lblCartTotalPrice";
            this.lblCartTotalPrice.Size = new System.Drawing.Size(0, 29);
            this.lblCartTotalPrice.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(522, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total Price (BDT.) :";
            // 
            // btnSell
            // 
            this.btnSell.BorderRadius = 30;
            this.btnSell.CheckedState.Parent = this.btnSell;
            this.btnSell.CustomImages.Parent = this.btnSell;
            this.btnSell.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.btnSell.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.btnSell.HoverState.Parent = this.btnSell;
            this.btnSell.Location = new System.Drawing.Point(35, 264);
            this.btnSell.Name = "btnSell";
            this.btnSell.ShadowDecoration.Parent = this.btnSell;
            this.btnSell.Size = new System.Drawing.Size(172, 63);
            this.btnSell.TabIndex = 2;
            this.btnSell.Text = "Sell";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(411, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Inside Cart";
            // 
            // dgvInsideCart
            // 
            this.dgvInsideCart.AllowUserToAddRows = false;
            this.dgvInsideCart.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvInsideCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInsideCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInsideCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvInsideCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInsideCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInsideCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsideCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInsideCart.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInsideCart.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInsideCart.EnableHeadersVisualStyles = false;
            this.dgvInsideCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInsideCart.Location = new System.Drawing.Point(6, 46);
            this.dgvInsideCart.Name = "dgvInsideCart";
            this.dgvInsideCart.ReadOnly = true;
            this.dgvInsideCart.RowHeadersVisible = false;
            this.dgvInsideCart.RowHeadersWidth = 51;
            this.dgvInsideCart.RowTemplate.Height = 24;
            this.dgvInsideCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsideCart.Size = new System.Drawing.Size(931, 194);
            this.dgvInsideCart.TabIndex = 0;
            this.dgvInsideCart.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvInsideCart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInsideCart.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvInsideCart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvInsideCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvInsideCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvInsideCart.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvInsideCart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInsideCart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvInsideCart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInsideCart.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvInsideCart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInsideCart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvInsideCart.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvInsideCart.ThemeStyle.ReadOnly = true;
            this.dgvInsideCart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInsideCart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInsideCart.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvInsideCart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvInsideCart.ThemeStyle.RowsStyle.Height = 24;
            this.dgvInsideCart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInsideCart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(128, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Product List";
            // 
            // cmbCartSoldBy
            // 
            this.cmbCartSoldBy.BackColor = System.Drawing.Color.Transparent;
            this.cmbCartSoldBy.BorderRadius = 20;
            this.cmbCartSoldBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCartSoldBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCartSoldBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCartSoldBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCartSoldBy.FocusedState.Parent = this.cmbCartSoldBy;
            this.cmbCartSoldBy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCartSoldBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCartSoldBy.FormattingEnabled = true;
            this.cmbCartSoldBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCartSoldBy.HoverState.Parent = this.cmbCartSoldBy;
            this.cmbCartSoldBy.ItemHeight = 30;
            this.cmbCartSoldBy.Items.AddRange(new object[] {
            "l",
            "l",
            "l",
            "l",
            "l",
            "l"});
            this.cmbCartSoldBy.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCartSoldBy.ItemsAppearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCartSoldBy.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbCartSoldBy.ItemsAppearance.Parent = this.cmbCartSoldBy;
            this.cmbCartSoldBy.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbCartSoldBy.ItemsAppearance.SelectedFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCartSoldBy.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCartSoldBy.Location = new System.Drawing.Point(692, 185);
            this.cmbCartSoldBy.Name = "cmbCartSoldBy";
            this.cmbCartSoldBy.ShadowDecoration.Parent = this.cmbCartSoldBy;
            this.cmbCartSoldBy.Size = new System.Drawing.Size(226, 36);
            this.cmbCartSoldBy.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(767, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Slold By";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(95, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Product name or code";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 30;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.guna2Button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(292, 264);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(172, 63);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Remove";
            // 
            // UcCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.cmbCartSoldBy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.udCartProductQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCartProductSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.cmbCartCatagory);
            this.Controls.Add(this.lbCartProductName);
            this.Controls.Add(this.txtCartSearch);
            this.Name = "UcCart";
            this.Size = new System.Drawing.Size(943, 671);
            ((System.ComponentModel.ISupportInitialize)(this.udCartProductQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsideCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtCartSearch;
        private System.Windows.Forms.ListBox lbCartProductName;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCartCatagory;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCartProductSize;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown udCartProductQuantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInsideCart;
        private Guna.UI2.WinForms.Guna2Button btnSell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCartTotalPrice;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnAddToCart;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCartSoldBy;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label6;
    }
}
