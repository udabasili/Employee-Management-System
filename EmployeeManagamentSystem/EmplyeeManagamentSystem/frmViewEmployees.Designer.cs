namespace EmployeeManagamentSystem
{
    partial class frmViewEmployees
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
            dgvEmployees = new DataGridView();
            grpDepartment = new GroupBox();
            cboDepartment = new ComboBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            grpDepartment.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(190, 46);
            label1.TabIndex = 3;
            label1.Text = "Employees";
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(12, 182);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(1148, 276);
            dgvEmployees.TabIndex = 2;
            dgvEmployees.CellClick += dgvEmployees_CellClick;
            // 
            // grpDepartment
            // 
            grpDepartment.Controls.Add(cboDepartment);
            grpDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDepartment.Location = new Point(70, 74);
            grpDepartment.Name = "grpDepartment";
            grpDepartment.Size = new Size(519, 91);
            grpDepartment.TabIndex = 4;
            grpDepartment.TabStop = false;
            grpDepartment.Text = "Choose A Department";
            // 
            // cboDepartment
            // 
            cboDepartment.FormattingEnabled = true;
            cboDepartment.Location = new Point(91, 33);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(322, 36);
            cboDepartment.TabIndex = 0;
            cboDepartment.SelectedIndexChanged += cboDepartment_SelectedIndexChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 488);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1179, 24);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 18);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 18);
            // 
            // frmViewEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 512);
            Controls.Add(statusStrip1);
            Controls.Add(grpDepartment);
            Controls.Add(label1);
            Controls.Add(dgvEmployees);
            Name = "frmViewEmployees";
            Tag = "View Employees";
            Text = "View Employees";
            Load += frmViewEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            grpDepartment.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvEmployees;
        private GroupBox grpDepartment;
        private ComboBox cboDepartment;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}