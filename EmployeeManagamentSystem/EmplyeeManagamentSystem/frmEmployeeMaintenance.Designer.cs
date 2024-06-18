namespace EmployeeManagamentSystem
{
    partial class frmEmployeeMaintenance
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
            cboDepartments = new ComboBox();
            label7 = new Label();
            dtpEmployemntDate = new DateTimePicker();
            label6 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnAdd = new Button();
            btnLast = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            btnFirst = new Button();
            txtFirstname = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtEmployeeID = new TextBox();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            prgBar = new ToolStripProgressBar();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            errProvider = new ErrorProvider(components);
            grpEmployees.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // grpEmployees
            // 
            grpEmployees.Controls.Add(cboDepartments);
            grpEmployees.Controls.Add(label7);
            grpEmployees.Controls.Add(dtpEmployemntDate);
            grpEmployees.Controls.Add(label6);
            grpEmployees.Controls.Add(dtpDateOfBirth);
            grpEmployees.Controls.Add(label5);
            grpEmployees.Controls.Add(txtEmail);
            grpEmployees.Controls.Add(label4);
            grpEmployees.Controls.Add(btnDelete);
            grpEmployees.Controls.Add(btnSave);
            grpEmployees.Controls.Add(btnCancel);
            grpEmployees.Controls.Add(btnAdd);
            grpEmployees.Controls.Add(btnLast);
            grpEmployees.Controls.Add(btnPrevious);
            grpEmployees.Controls.Add(btnNext);
            grpEmployees.Controls.Add(btnFirst);
            grpEmployees.Controls.Add(txtFirstname);
            grpEmployees.Controls.Add(label3);
            grpEmployees.Controls.Add(txtLastName);
            grpEmployees.Controls.Add(label2);
            grpEmployees.Controls.Add(txtEmployeeID);
            grpEmployees.Controls.Add(label1);
            grpEmployees.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpEmployees.Location = new Point(37, 12);
            grpEmployees.Name = "grpEmployees";
            grpEmployees.Size = new Size(840, 748);
            grpEmployees.TabIndex = 1;
            grpEmployees.TabStop = false;
            grpEmployees.Text = "Employee Details";
            // 
            // cboDepartments
            // 
            cboDepartments.FormattingEnabled = true;
            cboDepartments.Location = new Point(43, 545);
            cboDepartments.Name = "cboDepartments";
            cboDepartments.Size = new Size(562, 39);
            cboDepartments.TabIndex = 35;
            cboDepartments.Validating += cmb_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(41, 516);
            label7.Name = "label7";
            label7.Size = new Size(108, 23);
            label7.TabIndex = 32;
            label7.Text = "Department";
            // 
            // dtpEmployemntDate
            // 
            dtpEmployemntDate.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpEmployemntDate.Location = new Point(41, 470);
            dtpEmployemntDate.Name = "dtpEmployemntDate";
            dtpEmployemntDate.Size = new Size(564, 38);
            dtpEmployemntDate.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 444);
            label6.Name = "label6";
            label6.Size = new Size(155, 23);
            label6.TabIndex = 30;
            label6.Text = "Employment Date";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(41, 392);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(564, 38);
            dtpDateOfBirth.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 366);
            label5.Name = "label5";
            label5.Size = new Size(115, 23);
            label5.TabIndex = 28;
            label5.Text = "Date of Birth";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(41, 308);
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
            label4.Location = new Point(41, 282);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 26;
            label4.Text = "Email";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(231, 713);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(369, 713);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(507, 713);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(102, 713);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLast
            // 
            btnLast.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLast.Location = new Point(231, 668);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(94, 29);
            btnLast.TabIndex = 21;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += Navigation_Handler;
            // 
            // btnPrevious
            // 
            btnPrevious.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrevious.Location = new Point(369, 668);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 20;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += Navigation_Handler;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(507, 668);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 19;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += Navigation_Handler;
            // 
            // btnFirst
            // 
            btnFirst.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFirst.Location = new Point(102, 668);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(94, 29);
            btnFirst.TabIndex = 18;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += Navigation_Handler;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(41, 152);
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
            label3.Location = new Point(41, 126);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 16;
            label3.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(41, 226);
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
            label2.Location = new Point(41, 200);
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
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, prgBar, toolStripStatusLabel3 });
            statusStrip1.Location = new Point(0, 757);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1083, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 20);
            // 
            // prgBar
            // 
            prgBar.Name = "prgBar";
            prgBar.Size = new Size(100, 18);
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(0, 20);
            // 
            // errProvider
            // 
            errProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errProvider.ContainerControl = this;
            // 
            // frmEmployeeMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 783);
            Controls.Add(statusStrip1);
            Controls.Add(grpEmployees);
            Name = "frmEmployeeMaintenance";
            Tag = "Employee";
            Text = "Employee Maintenance";
            Load += frmEmployeeMaintenance_Load;
            grpEmployees.ResumeLayout(false);
            grpEmployees.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpEmployees;
        private TextBox txtEmployeeID;
        private Label label1;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
        private Button btnAdd;
        private Button btnLast;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnFirst;
        private TextBox txtFirstname;
        private Label label3;
        private TextBox txtLastName;
        private Label label2;
        private ComboBox cboDepartments;
        private Label label7;
        private DateTimePicker dtpEmployemntDate;
        private Label label6;
        private DateTimePicker dtpDateOfBirth;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripProgressBar prgBar;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ErrorProvider errProvider;
    }
}