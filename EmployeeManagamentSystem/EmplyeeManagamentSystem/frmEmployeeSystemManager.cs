namespace EmployeeManagamentSystem
{
    public partial class frmEmployeeSystemManager : Form
    {

        public frmEmployeeSystemManager()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            object tag = null;
            if (sender is ToolStripMenuItem)
            {
                tag = ((ToolStripMenuItem)sender).Tag;
            }
            else if (sender is ToolStripButton)
            {
                tag = ((ToolStripButton)sender).Tag;
            }


            Form? childForm = null;


            switch (tag.ToString())
            {
                case "Employees":
                    childForm = new frmEmployeeMaintenance();
                    break;
                case "Departments":
                    childForm = new frmDepartmentMaintenance();
                    break;
                case "Edit Profile":
                    childForm = new frmEditProfile();
                    break;
                case "About":
                    childForm = new frmAbout();
                    break;
                case "View Departments":
                    childForm = new frmViewDepartments();
                    break;
                case "View Employees":
                    childForm = new frmViewEmployees();
                    break;
                case "Salary":
                    childForm = new frmSalaries();
                    break;
                case "Manager":
                    childForm = new frmManager();
                    break;
                default:
                    MessageBox.Show($"I was called by {sender}");
                    break;


            }
            if (childForm != null)
            {

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm.Text == childForm.Text)
                    {
                        frm.Activate();
                        return;
                    }


                }
                if (childForm is frmEditProfile ||
                    childForm is frmAbout ||
                    childForm is frmViewDepartments ||
                    childForm is frmViewEmployees
                    )
                {
                    childForm.MdiParent = this;
                }
                childForm.Show();
                childForm.Location = new Point(0, 0);
                toolStripStatusLabel.Text = childForm.Text + " is showing";

            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmEmployeeSystemManager_Load(object sender, EventArgs e)
        {
            try
            {
                Authorization.SetFormAccessCurrentUser();

                if (!Authorization.ShowEmployeeEditorForm())
                {
                    employeesToolStripMenuItem.Visible = false;
                }

                if (!Authorization.ShowDepartmentEditorForm())
                {
                    departmentsToolStripMenuItem.Visible = false;
                }

                if (!Authorization.ShowEmployeeViewerForm())
                {
                    viewEmployeesToolStripMenuItem.Visible = false;
                    employeesToolStripButton.Visible = false;
                }

                if (!Authorization.ShowDepartmentViewerForm())
                {
                    viewDepartmentsToolStripMenuItem.Visible = false;
                    departmentToolStripButton.Visible = false;
                }

                if (!Authorization.ShowEditProfileForm())
                {
                    editProfileToolStripMenuItem.Visible = false;
                }

                if (!Authorization.ShowEmployeeViewerForm())
                {
                    viewEmployeesToolStripMenuItem.Visible = false;
                    employeesToolStripButton.Visible = false;
                }

                if (!Authorization.ShowDepartmentViewerForm())
                {
                    viewDepartmentsToolStripMenuItem.Visible = false;
                    departmentToolStripButton.Visible = false;
                }

                if (!Authorization.ShowManagerForm())
                {
                    setManagerToolStripMenuItem.Visible = false;
                }

                if (!Authorization.ShowSalaryForm())
                {
                    setSalaToolStripMenuItem.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
