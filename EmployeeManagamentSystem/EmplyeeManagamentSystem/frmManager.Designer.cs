namespace EmployeeManagamentSystem
{
    partial class frmManager
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
            label3 = new Label();
            cboNewManager = new ComboBox();
            label1 = new Label();
            btnSubmit = new Button();
            cboDepartments = new ComboBox();
            txtCurrentManager = new TextBox();
            label2 = new Label();
            errProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(81, 119);
            label3.Name = "label3";
            label3.Size = new Size(166, 28);
            label3.TabIndex = 10;
            label3.Text = "Current Manager";
            // 
            // cboNewManager
            // 
            cboNewManager.FormattingEnabled = true;
            cboNewManager.Location = new Point(81, 241);
            cboNewManager.Name = "cboNewManager";
            cboNewManager.Size = new Size(343, 28);
            cboNewManager.TabIndex = 11;
            cboNewManager.Validating += cbo_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(81, 30);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 12;
            label1.Text = "Department";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Black;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(131, 325);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(197, 52);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // cboDepartments
            // 
            cboDepartments.FormattingEnabled = true;
            cboDepartments.Location = new Point(80, 71);
            cboDepartments.Name = "cboDepartments";
            cboDepartments.Size = new Size(344, 28);
            cboDepartments.TabIndex = 15;
            cboDepartments.SelectedIndexChanged += cboDepartments_SelectedIndexChanged;
            // 
            // txtCurrentManager
            // 
            txtCurrentManager.Location = new Point(81, 164);
            txtCurrentManager.Name = "txtCurrentManager";
            txtCurrentManager.ReadOnly = true;
            txtCurrentManager.Size = new Size(333, 27);
            txtCurrentManager.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(81, 210);
            label2.Name = "label2";
            label2.Size = new Size(139, 28);
            label2.TabIndex = 18;
            label2.Text = "New Manager";
            // 
            // errProvider
            // 
            errProvider.ContainerControl = this;
            // 
            // frmManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 135, 245);
            ClientSize = new Size(490, 450);
            Controls.Add(label2);
            Controls.Add(txtCurrentManager);
            Controls.Add(cboDepartments);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Controls.Add(cboNewManager);
            Controls.Add(label3);
            Name = "frmManager";
            Text = "Set Manager";
            Load += frmManager_Load;
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox cboNewManager;
        private Label label1;
        private Button btnSubmit;
        private ComboBox cboDepartments;
        private TextBox txtCurrentManager;
        private Label label2;
        private ErrorProvider errProvider;
    }
}