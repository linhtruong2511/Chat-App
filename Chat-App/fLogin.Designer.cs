namespace Chat_App
{
    partial class fLogin
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
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbUserName);
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 67);
            this.panel1.TabIndex = 0;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(157, 25);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(347, 26);
            this.txbUserName.TabIndex = 1;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(28, 25);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(123, 29);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "User Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbPassword);
            this.panel2.Controls.Add(this.lbPassword);
            this.panel2.Location = new System.Drawing.Point(12, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 67);
            this.panel2.TabIndex = 1;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(157, 29);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(347, 26);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(28, 25);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(113, 29);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password:";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(273, 170);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(129, 35);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(408, 170);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(129, 35);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(12, 170);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(129, 35);
            this.btRegister.TabIndex = 5;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 239);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btRegister;
    }
}