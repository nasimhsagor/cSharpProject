
namespace LMS1._0
{
    partial class loginform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateAccBtn = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CreateAccBtn);
            this.panel1.Controls.Add(this.Header);
            this.panel1.Controls.Add(this.PassBox);
            this.panel1.Controls.Add(this.UserNameBox);
            this.panel1.Controls.Add(this.LoginBtn);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 557);
            this.panel1.TabIndex = 0;
            // 
            // CreateAccBtn
            // 
            this.CreateAccBtn.Location = new System.Drawing.Point(562, 393);
            this.CreateAccBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateAccBtn.Name = "CreateAccBtn";
            this.CreateAccBtn.Size = new System.Drawing.Size(264, 63);
            this.CreateAccBtn.TabIndex = 9;
            this.CreateAccBtn.Text = "Create Account";
            this.CreateAccBtn.UseVisualStyleBackColor = true;
            this.CreateAccBtn.Click += new System.EventHandler(this.CreateAccBtn_Click);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(462, 101);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(170, 64);
            this.Header.TabIndex = 8;
            this.Header.Text = "Login";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(290, 310);
            this.PassBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(535, 26);
            this.PassBox.TabIndex = 7;
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(290, 230);
            this.UserNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(535, 26);
            this.UserNameBox.TabIndex = 6;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(290, 393);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(264, 63);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 581);
            this.Controls.Add(this.panel1);
            this.Name = "loginform";
            this.Text = "LMS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CreateAccBtn;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Button LoginBtn;
    }
}

