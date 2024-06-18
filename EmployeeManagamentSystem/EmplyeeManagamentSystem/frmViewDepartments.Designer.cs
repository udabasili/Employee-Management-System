namespace EmployeeManagamentSystem
{
    partial class frmViewDepartments
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
            dgvDepartments = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).BeginInit();
            SuspendLayout();
            // 
            // dgvDepartments
            // 
            dgvDepartments.AllowUserToAddRows = false;
            dgvDepartments.AllowUserToDeleteRows = false;
            dgvDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartments.Location = new Point(47, 76);
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.ReadOnly = true;
            dgvDepartments.RowHeadersWidth = 51;
            dgvDepartments.Size = new Size(1148, 362);
            dgvDepartments.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 20);
            label1.Name = "label1";
            label1.Size = new Size(213, 46);
            label1.TabIndex = 1;
            label1.Text = "Department";
            // 
            // frmViewDepartments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1278, 450);
            Controls.Add(label1);
            Controls.Add(dgvDepartments);
            Name = "frmViewDepartments";
            Tag = "View Departments";
            Text = "View Departments";
            Load += frmViewDepartments_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDepartments;
        private Label label1;
    }
}