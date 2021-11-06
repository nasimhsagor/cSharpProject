
namespace ClothingShopManagementSystem.App
{
    partial class CompanyPayment
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
            this.btnPayment = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPaidAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLiabilities = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCompanyName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // btnPayment
            // 
            this.btnPayment.BorderRadius = 30;
            this.btnPayment.CheckedState.Parent = this.btnPayment;
            this.btnPayment.CustomImages.Parent = this.btnPayment;
            this.btnPayment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.HoverState.Parent = this.btnPayment;
            this.btnPayment.Location = new System.Drawing.Point(96, 332);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.ShadowDecoration.Parent = this.btnPayment;
            this.btnPayment.Size = new System.Drawing.Size(172, 63);
            this.btnPayment.TabIndex = 37;
            this.btnPayment.Text = "Add";
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label9.Location = new System.Drawing.Point(124, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "Paid amount";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.BorderRadius = 20;
            this.txtPaidAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaidAmount.DefaultText = "0.00";
            this.txtPaidAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPaidAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPaidAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaidAmount.DisabledState.Parent = this.txtPaidAmount;
            this.txtPaidAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaidAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtPaidAmount.FocusedState.Parent = this.txtPaidAmount;
            this.txtPaidAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtPaidAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtPaidAmount.HoverState.Parent = this.txtPaidAmount;
            this.txtPaidAmount.Location = new System.Drawing.Point(54, 287);
            this.txtPaidAmount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.PasswordChar = '\0';
            this.txtPaidAmount.PlaceholderText = "";
            this.txtPaidAmount.SelectedText = "";
            this.txtPaidAmount.SelectionStart = 4;
            this.txtPaidAmount.ShadowDecoration.Parent = this.txtPaidAmount;
            this.txtPaidAmount.Size = new System.Drawing.Size(256, 36);
            this.txtPaidAmount.TabIndex = 35;
            this.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(138, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "Liabilities";
            // 
            // txtLiabilities
            // 
            this.txtLiabilities.BorderRadius = 20;
            this.txtLiabilities.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLiabilities.DefaultText = "";
            this.txtLiabilities.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLiabilities.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLiabilities.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLiabilities.DisabledState.Parent = this.txtLiabilities;
            this.txtLiabilities.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLiabilities.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtLiabilities.FocusedState.Parent = this.txtLiabilities;
            this.txtLiabilities.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiabilities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtLiabilities.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.txtLiabilities.HoverState.Parent = this.txtLiabilities;
            this.txtLiabilities.Location = new System.Drawing.Point(54, 215);
            this.txtLiabilities.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLiabilities.Name = "txtLiabilities";
            this.txtLiabilities.PasswordChar = '\0';
            this.txtLiabilities.PlaceholderText = "";
            this.txtLiabilities.ReadOnly = true;
            this.txtLiabilities.SelectedText = "";
            this.txtLiabilities.ShadowDecoration.Parent = this.txtLiabilities;
            this.txtLiabilities.Size = new System.Drawing.Size(256, 36);
            this.txtLiabilities.TabIndex = 33;
            this.txtLiabilities.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(112, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Company name";
            // 
            // cmbCompanyName
            // 
            this.cmbCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.cmbCompanyName.BorderRadius = 20;
            this.cmbCompanyName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCompanyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCompanyName.FocusedState.Parent = this.cmbCompanyName;
            this.cmbCompanyName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCompanyName.HoverState.Parent = this.cmbCompanyName;
            this.cmbCompanyName.ItemHeight = 30;
            this.cmbCompanyName.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCompanyName.ItemsAppearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompanyName.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbCompanyName.ItemsAppearance.Parent = this.cmbCompanyName;
            this.cmbCompanyName.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbCompanyName.ItemsAppearance.SelectedFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompanyName.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(204)))));
            this.cmbCompanyName.Location = new System.Drawing.Point(54, 146);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.ShadowDecoration.Parent = this.cmbCompanyName;
            this.cmbCompanyName.Size = new System.Drawing.Size(256, 36);
            this.cmbCompanyName.TabIndex = 31;
            this.cmbCompanyName.SelectedIndexChanged += new System.EventHandler(this.cmbCompanyName_SelectedIndexChanged);
            // 
            // CompanyPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 437);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPaidAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLiabilities);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCompanyName);
            this.Name = "CompanyPayment";
            this.Text = "CompanyPayment";
            this.Load += new System.EventHandler(this.CompanyPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnPayment;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtPaidAmount;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtLiabilities;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCompanyName;
    }
}