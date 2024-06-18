namespace EmployeeManagamentSystem
{
    partial class frmEmployeeSystemManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeSystemManager));
            menuStrip = new MenuStrip();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            departmentsToolStripMenuItem = new ToolStripMenuItem();
            editProfileToolStripMenuItem = new ToolStripMenuItem();
            viewEmployeesToolStripMenuItem = new ToolStripMenuItem();
            viewDepartmentsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            setManagerToolStripMenuItem = new ToolStripMenuItem();
            setSalaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            departmentToolStripButton = new ToolStripButton();
            employeesToolStripButton = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { employeesToolStripMenuItem, departmentsToolStripMenuItem, editProfileToolStripMenuItem, viewEmployeesToolStripMenuItem, viewDepartmentsToolStripMenuItem, aboutToolStripMenuItem, setManagerToolStripMenuItem, setSalaToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(1224, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(133, 24);
            employeesToolStripMenuItem.Tag = "Employees";
            employeesToolStripMenuItem.Text = "Employee Editor";
            employeesToolStripMenuItem.Click += ShowNewForm;
            // 
            // departmentsToolStripMenuItem
            // 
            departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            departmentsToolStripMenuItem.Size = new Size(147, 24);
            departmentsToolStripMenuItem.Tag = "Departments";
            departmentsToolStripMenuItem.Text = "Department Editor";
            departmentsToolStripMenuItem.Click += ShowNewForm;
            // 
            // editProfileToolStripMenuItem
            // 
            editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            editProfileToolStripMenuItem.Size = new Size(92, 24);
            editProfileToolStripMenuItem.Tag = "Edit Profile";
            editProfileToolStripMenuItem.Text = "EditProfile";
            editProfileToolStripMenuItem.Click += ShowNewForm;
            // 
            // viewEmployeesToolStripMenuItem
            // 
            viewEmployeesToolStripMenuItem.Name = "viewEmployeesToolStripMenuItem";
            viewEmployeesToolStripMenuItem.Size = new Size(131, 24);
            viewEmployeesToolStripMenuItem.Tag = "View Employees";
            viewEmployeesToolStripMenuItem.Text = "View Employees";
            viewEmployeesToolStripMenuItem.Click += ShowNewForm;
            // 
            // viewDepartmentsToolStripMenuItem
            // 
            viewDepartmentsToolStripMenuItem.Name = "viewDepartmentsToolStripMenuItem";
            viewDepartmentsToolStripMenuItem.Size = new Size(145, 24);
            viewDepartmentsToolStripMenuItem.Tag = "View Departments";
            viewDepartmentsToolStripMenuItem.Text = "View Departments";
            viewDepartmentsToolStripMenuItem.Click += ShowNewForm;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Tag = "About";
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += ShowNewForm;
            // 
            // setManagerToolStripMenuItem
            // 
            setManagerToolStripMenuItem.Name = "setManagerToolStripMenuItem";
            setManagerToolStripMenuItem.Size = new Size(82, 24);
            setManagerToolStripMenuItem.Tag = "Manager";
            setManagerToolStripMenuItem.Text = "Manager";
            setManagerToolStripMenuItem.Click += ShowNewForm;
            // 
            // setSalaToolStripMenuItem
            // 
            setSalaToolStripMenuItem.Name = "setSalaToolStripMenuItem";
            setSalaToolStripMenuItem.Size = new Size(63, 24);
            setSalaToolStripMenuItem.Tag = "Salary";
            setSalaToolStripMenuItem.Text = "Salary";
            setSalaToolStripMenuItem.Click += ShowNewForm;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 776);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 19, 0);
            statusStrip.Size = new Size(1224, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(49, 20);
            toolStripStatusLabel.Text = "Status";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { departmentToolStripButton, employeesToolStripButton, toolStripButton3 });
            toolStrip1.Location = new Point(0, 30);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1224, 27);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // departmentToolStripButton
            // 
            departmentToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            departmentToolStripButton.Image = Properties.Resources.icons8_department_24;
            departmentToolStripButton.ImageTransparentColor = Color.Magenta;
            departmentToolStripButton.Name = "departmentToolStripButton";
            departmentToolStripButton.Size = new Size(29, 24);
            departmentToolStripButton.Tag = "Departments";
            departmentToolStripButton.Text = "Departments";
            departmentToolStripButton.Click += ShowNewForm;
            // 
            // employeesToolStripButton
            // 
            employeesToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            employeesToolStripButton.Image = (Image)resources.GetObject("employeesToolStripButton.Image");
            employeesToolStripButton.ImageTransparentColor = Color.Magenta;
            employeesToolStripButton.Name = "employeesToolStripButton";
            employeesToolStripButton.Size = new Size(29, 24);
            employeesToolStripButton.Text = "toolStripButton2";
            employeesToolStripButton.Click += ShowNewForm;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Tag = "About";
            toolStripButton3.Text = "About";
            toolStripButton3.Click += ShowNewForm;
            // 
            // frmEmployeeSystemManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1224, 802);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmEmployeeSystemManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee System Manager";
            Load += frmEmployeeSystemManager_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem departmentsToolStripMenuItem;
        private ToolStripMenuItem editProfileToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton departmentToolStripButton;
        private ToolStripButton employeesToolStripButton;
        private ToolStripButton toolStripButton3;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem viewEmployeesToolStripMenuItem;
        private ToolStripMenuItem viewDepartmentsToolStripMenuItem;
        private ToolStripMenuItem setManagerToolStripMenuItem;
        private ToolStripMenuItem setSalaToolStripMenuItem;
    }
}



