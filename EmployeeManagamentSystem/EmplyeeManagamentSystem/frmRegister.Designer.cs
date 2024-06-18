using System.ComponentModel;

namespace EmployeeManagamentSystem
{
    partial class frmRegister
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
            components = new Container();
            btnLogin = new Button();
            txtEmail = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmbRoles = new ComboBox();
            lnkLoginLink = new LinkLabel();
            errProvider = new ErrorProvider(components);
            ((ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(292, 467);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(217, 46);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Submit";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(222, 202);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(357, 27);
            txtEmail.TabIndex = 10;
            txtEmail.Tag = "Email";
            txtEmail.Validating += txt_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(222, 171);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(222, 133);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(357, 27);
            txtUsername.TabIndex = 8;
            txtUsername.Tag = "Username";
            txtUsername.Validating += txt_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(222, 102);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(244, 21);
            label1.Name = "label1";
            label1.Size = new Size(335, 50);
            label1.TabIndex = 6;
            label1.Text = "Registration Form";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(222, 268);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(357, 27);
            txtPassword.TabIndex = 13;
            txtPassword.Tag = "Password";
            txtPassword.Validating += txt_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(222, 237);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 12;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(222, 308);
            label5.Name = "label5";
            label5.Size = new Size(51, 28);
            label5.TabIndex = 14;
            label5.Text = "Role";
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(222, 339);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(357, 28);
            cmbRoles.TabIndex = 15;
            cmbRoles.Tag = "Role";
            cmbRoles.Validating += cmbRoles_Validating;
            // 
            // lnkLoginLink
            // 
            lnkLoginLink.AutoSize = true;
            lnkLoginLink.ForeColor = SystemColors.Control;
            lnkLoginLink.LinkColor = Color.WhiteSmoke;
            lnkLoginLink.Location = new Point(226, 410);
            lnkLoginLink.Name = "lnkLoginLink";
            lnkLoginLink.Size = new Size(201, 20);
            lnkLoginLink.TabIndex = 16;
            lnkLoginLink.TabStop = true;
            lnkLoginLink.Text = "Already have Account? Login";
            lnkLoginLink.LinkClicked += lnkLoginLink_LinkClicked;
            // 
            // errProvider
            // 
            errProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errProvider.ContainerControl = this;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 135, 245);
            ClientSize = new Size(868, 572);
            Controls.Add(lnkLoginLink);
            Controls.Add(cmbRoles);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegister";
            Text = "Register";
            Load += frmRegister_Load;
            ((ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private Label label4;
        private Label label5;
        private ComboBox cmbRoles;
        private LinkLabel lnkLoginLink;
        private ErrorProvider errProvider;
    }
}