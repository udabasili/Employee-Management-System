namespace EmployeeManagamentSystem
{
    partial class frmEditProfile
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
            components = new System.ComponentModel.Container();
            grpEmployees = new GroupBox();
            btnSubmit = new Button();
            txtUsername = new TextBox();
            label7 = new Label();
            dtpEmployemntDate = new DateTimePicker();
            label6 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtFirstname = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtEmployeeID = new TextBox();
            label1 = new Label();
            errProvider = new ErrorProvider(components);
            grpEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // grpEmployees
            // 
            grpEmployees.Controls.Add(btnSubmit);
            grpEmployees.Controls.Add(txtUsername);
            grpEmployees.Controls.Add(label7);
            grpEmployees.Controls.Add(dtpEmployemntDate);
            grpEmployees.Controls.Add(label6);
            grpEmployees.Controls.Add(dtpDateOfBirth);
            grpEmployees.Controls.Add(label5);
            grpEmployees.Controls.Add(txtEmail);
            grpEmployees.Controls.Add(label4);
            grpEmployees.Controls.Add(txtFirstname);
            grpEmployees.Controls.Add(label3);
            grpEmployees.Controls.Add(txtLastName);
            grpEmployees.Controls.Add(label2);
            grpEmployees.Controls.Add(txtEmployeeID);
            grpEmployees.Controls.Add(label1);
            grpEmployees.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpEmployees.Location = new Point(121, 17);
            grpEmployees.Name = "grpEmployees";
            grpEmployees.Size = new Size(840, 748);
            grpEmployees.TabIndex = 2;
            grpEmployees.TabStop = false;
            grpEmployees.Text = "Employee Details";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(218, 648);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(172, 55);
            btnSubmit.TabIndex = 34;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(38, 150);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(564, 38);
            txtUsername.TabIndex = 33;
            txtUsername.Tag = "First Name";
            txtUsername.Validating += txt_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 124);
            label7.Name = "label7";
            label7.Size = new Size(89, 23);
            label7.TabIndex = 32;
            label7.Text = "Username";
            // 
            // dtpEmployemntDate
            // 
            dtpEmployemntDate.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpEmployemntDate.Location = new Point(41, 534);
            dtpEmployemntDate.Name = "dtpEmployemntDate";
            dtpEmployemntDate.Size = new Size(564, 38);
            dtpEmployemntDate.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 508);
            label6.Name = "label6";
            label6.Size = new Size(155, 23);
            label6.TabIndex = 30;
            label6.Text = "Employment Date";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(41, 456);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(564, 38);
            dtpDateOfBirth.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 430);
            label5.Name = "label5";
            label5.Size = new Size(115, 23);
            label5.TabIndex = 28;
            label5.Text = "Date of Birth";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(41, 372);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(564, 38);
            txtEmail.TabIndex = 27;
            txtEmail.Tag = "Email";
            txtEmail.Validating += txt_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 346);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 26;
            label4.Text = "Email";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(41, 216);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(564, 38);
            txtFirstname.TabIndex = 17;
            txtFirstname.Tag = "First Name";
            txtFirstname.Validating += txt_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 190);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 16;
            label3.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(41, 290);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(564, 38);
            txtLastName.TabIndex = 15;
            txtLastName.Tag = "Last Name";
            txtLastName.Validating += txt_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 264);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 14;
            label2.Text = "Last Name";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(41, 68);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.ReadOnly = true;
            txtEmployeeID.Size = new Size(564, 38);
            txtEmployeeID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 42);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 0;
            label1.Text = "EmployeeID";
            // 
            // errProvider
            // 
            errProvider.ContainerControl = this;
            // 
            // frmEditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 783);
            Controls.Add(grpEmployees);
            Name = "frmEditProfile";
            Tag = "Edit Profile";
            Text = "Edit Profile";
            Load += frmEditProfile_Load;
            grpEmployees.ResumeLayout(false);
            grpEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEmployees;
        private DateTimePicker dtpEmployemntDate;
        private Label label6;
        private DateTimePicker dtpDateOfBirth;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtFirstname;
        private Label label3;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtEmployeeID;
        private Label label1;
        private TextBox txtUsername;
        private Label label7;
        private Button btnSubmit;
        private ErrorProvider errProvider;
    }
}