namespace LMS_ADMIN
{
    partial class AllBookRecForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AllBookDataGrrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllBookDataGrrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "All Book Record";
            // 
            // AllBookDataGrrid
            // 
            this.AllBookDataGrrid.AllowUserToAddRows = false;
            this.AllBookDataGrrid.AllowUserToDeleteRows = false;
            this.AllBookDataGrrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllBookDataGrrid.Location = new System.Drawing.Point(46, 60);
            this.AllBookDataGrrid.MultiSelect = false;
            this.AllBookDataGrrid.Name = "AllBookDataGrrid";
            this.AllBookDataGrrid.ReadOnly = true;
            this.AllBookDataGrrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllBookDataGrrid.Size = new System.Drawing.Size(709, 367);
            this.AllBookDataGrrid.TabIndex = 7;
            // 
            // AllBookRecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllBookDataGrrid);
            this.Name = "AllBookRecForm";
            this.Text = "AllBookRecForm";
            ((System.ComponentModel.ISupportInitialize)(this.AllBookDataGrrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AllBookDataGrrid;
    }
}