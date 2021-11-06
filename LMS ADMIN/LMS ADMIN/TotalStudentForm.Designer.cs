namespace LMS_ADMIN
{
    partial class TotalStudentForm
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
            this.AllStudentGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllStudentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "All Student Record ";
            // 
            // AllStudentGrid
            // 
            this.AllStudentGrid.AllowUserToAddRows = false;
            this.AllStudentGrid.AllowUserToDeleteRows = false;
            this.AllStudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllStudentGrid.Location = new System.Drawing.Point(12, 58);
            this.AllStudentGrid.MultiSelect = false;
            this.AllStudentGrid.Name = "AllStudentGrid";
            this.AllStudentGrid.ReadOnly = true;
            this.AllStudentGrid.Size = new System.Drawing.Size(689, 396);
            this.AllStudentGrid.TabIndex = 2;
            // 
            // TotalStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllStudentGrid);
            this.Name = "TotalStudentForm";
            this.Text = "TotalStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.AllStudentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AllStudentGrid;
    }
}