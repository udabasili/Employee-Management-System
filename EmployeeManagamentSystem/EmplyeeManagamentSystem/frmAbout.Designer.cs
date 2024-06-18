namespace EmployeeManagamentSystem
{
    partial class frmAbout
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
            lblProductName = new Label();
            lblCompany = new Label();
            lblVersion = new Label();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblProductName.ForeColor = Color.White;
            lblProductName.Location = new Point(39, 29);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(234, 41);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "[ProductName]";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.BackColor = Color.Transparent;
            lblCompany.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCompany.ForeColor = Color.White;
            lblCompany.Location = new Point(39, 354);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(173, 41);
            lblCompany.TabIndex = 1;
            lblCompany.Text = "[Company]";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVersion.ForeColor = Color.White;
            lblVersion.Location = new Point(39, 87);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(80, 25);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "[Version]";
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 135, 245);
            ClientSize = new Size(800, 450);
            Controls.Add(lblVersion);
            Controls.Add(lblCompany);
            Controls.Add(lblProductName);
            Name = "frmAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            Load += frmAbout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductName;
        private Label lblCompany;
        private Label lblVersion;
    }
}