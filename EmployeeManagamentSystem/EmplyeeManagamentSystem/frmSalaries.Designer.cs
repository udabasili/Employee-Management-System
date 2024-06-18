namespace EmployeeManagamentSystem
{
    partial class frmSalaries
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
            cboEmployees = new ComboBox();
            label3 = new Label();
            btnSubmit = new Button();
            label1 = new Label();
            txtSalaryBeforeTax = new TextBox();
            txtTaxAmount = new TextBox();
            label2 = new Label();
            txtSalaryAfterTax = new TextBox();
            label4 = new Label();
            errProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // cboEmployees
            // 
            cboEmployees.FormattingEnabled = true;
            cboEmployees.Location = new Point(120, 70);
            cboEmployees.Name = "cboEmployees";
            cboEmployees.Size = new Size(343, 28);
            cboEmployees.TabIndex = 13;
            cboEmployees.SelectedIndexChanged += cboEmployees_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(120, 39);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 12;
            label3.Text = "Employee";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Black;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(160, 211);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(197, 52);
            btnSubmit.TabIndex = 15;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(120, 125);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 16;
            label1.Text = "Salary ";
            // 
            // txtSalaryBeforeTax
            // 
            txtSalaryBeforeTax.Location = new Point(120, 156);
            txtSalaryBeforeTax.Name = "txtSalaryBeforeTax";
            txtSalaryBeforeTax.Size = new Size(331, 27);
            txtSalaryBeforeTax.TabIndex = 17;
            txtSalaryBeforeTax.Validating += NumericTextBox_Validating;
            // 
            // txtTaxAmount
            // 
            txtTaxAmount.Location = new Point(100, 315);
            txtTaxAmount.Name = "txtTaxAmount";
            txtTaxAmount.ReadOnly = true;
            txtTaxAmount.Size = new Size(107, 27);
            txtTaxAmount.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(100, 284);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 18;
            label2.Text = "Tax Amount";
            // 
            // txtSalaryAfterTax
            // 
            txtSalaryAfterTax.BackColor = SystemColors.ButtonFace;
            txtSalaryAfterTax.Location = new Point(292, 315);
            txtSalaryAfterTax.Name = "txtSalaryAfterTax";
            txtSalaryAfterTax.ReadOnly = true;
            txtSalaryAfterTax.Size = new Size(138, 27);
            txtSalaryAfterTax.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(302, 284);
            label4.Name = "label4";
            label4.Size = new Size(128, 28);
            label4.TabIndex = 20;
            label4.Text = "Actual Salary";
            // 
            // errProvider
            // 
            errProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errProvider.ContainerControl = this;
            // 
            // frmSalaries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 135, 245);
            ClientSize = new Size(547, 450);
            Controls.Add(txtSalaryAfterTax);
            Controls.Add(label4);
            Controls.Add(txtTaxAmount);
            Controls.Add(label2);
            Controls.Add(txtSalaryBeforeTax);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(cboEmployees);
            Controls.Add(label3);
            Name = "frmSalaries";
            Tag = "Salary";
            Text = "Salary";
            Load += frmSalaries_Load;
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboEmployees;
        private Label label3;
        private Button btnSubmit;
        private Label label1;
        private TextBox txtSalaryBeforeTax;
        private TextBox txtTaxAmount;
        private Label label2;
        private TextBox txtSalaryAfterTax;
        private Label label4;
        private ErrorProvider errProvider;
    }
}