namespace LMS_ADMIN
{
    partial class Form1
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
            this.CreateAccBtn = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateAccBtn
            // 
            this.CreateAccBtn.Location = new System.Drawing.Point(466, 294);
            this.CreateAccBtn.Name = "CreateAccBtn";
            this.CreateAccBtn.Size = new System.Drawing.Size(176, 41);
            this.CreateAccBtn.TabIndex = 9;
            this.CreateAccBtn.Text = "Create Account";
            this.CreateAccBtn.UseVisualStyleBackColor = true;
            this.CreateAccBtn.Click += new System.EventHandler(this.CreateAccBtn_Click);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(399, 104);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(115, 42);
            this.Header.TabIndex = 8;
            this.Header.Text = "Login";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(284, 240);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(358, 20);
            this.PassBox.TabIndex = 7;
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(284, 188);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(358, 20);
            this.UserNameBox.TabIndex = 6;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(284, 294);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(176, 41);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 492);
            this.Controls.Add(this.CreateAccBtn);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.LoginBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateAccBtn;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Button LoginBtn;
    }
}

