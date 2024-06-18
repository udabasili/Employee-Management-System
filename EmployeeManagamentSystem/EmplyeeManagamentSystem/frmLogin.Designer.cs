namespace EmployeeManagamentSystem
{
    partial class frmLogin
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
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            lnkRegisterLink = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(177, 20);
            label1.Name = "label1";
            label1.Size = new Size(221, 50);
            label1.TabIndex = 0;
            label1.Text = "Login Form";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(102, 121);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(102, 152);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(357, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(102, 238);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(357, 27);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(102, 207);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(144, 343);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(217, 46);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Submit";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnkRegisterLink
            // 
            lnkRegisterLink.AutoSize = true;
            lnkRegisterLink.Location = new Point(177, 307);
            lnkRegisterLink.Name = "lnkRegisterLink";
            lnkRegisterLink.Size = new Size(152, 20);
            lnkRegisterLink.TabIndex = 17;
            lnkRegisterLink.TabStop = true;
            lnkRegisterLink.Text = "No Account? Register";
            lnkRegisterLink.LinkClicked += lnkRegisterLink_LinkClicked;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 135, 245);
            ClientSize = new Size(580, 470);
            Controls.Add(lnkRegisterLink);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private Button btnLogin;
        private LinkLabel lnkRegisterLink;
    }
}