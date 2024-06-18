using DBProgrammingDemo9;
using System.ComponentModel;
using System.Data;

namespace EmployeeManagamentSystem
{
    public partial class frmDepartmentMaintenance : Form
    {
        public frmDepartmentMaintenance()
        {
            InitializeComponent();
        }


        int currentRecord = 0;
        int currentDepartmentId = 0;
        int firstDepartmentId = 0;
        int lastDepartmentId = 0;
        int? previousDepartmentId;
        int? nextDepartmentId;

        #region Event Listeners

        private void frmDepartmentMaintenance_Load(object sender, EventArgs e)
        {

            try
            {
                LoadFirstDepartment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Adding a new Department";
            toolStripStatusLabel2.Text = "";

            ClearControls(grpDepartments.Controls);

            btnSave.Text = "Create";

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;

            NavigationState(false);




        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to delete this Department?", "Delete Department", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = $"DELETE FROM Departments WHERE DepartmentID = {currentDepartmentId};";
                    int rowAffected = DataAccess.SendData(sql);

                    if (rowAffected == 1)
                    {
                        MessageBox.Show($"Records Deleted: {rowAffected}");
                        NavigationState(true);
                        LoadFirstDepartment();
                    }
                    else
                    {
                        MessageBox.Show("Department deletion failed");
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ProgressBar();

                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (txtDepartmentID.Text != string.Empty)
                    {
                        SaveDepartmentChanges();
                    }
                    else
                    {
                        CreateDepartment();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDepartmentDetails();

                btnSave.Text = "Save";
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;

                toolStripStatusLabel2.Text = string.Empty;
                prgBar.Value = 0;

                NavigationState(true);
                NextPreviousButtonManagement();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region [Retrieves]

        private void LoadFirstDepartment()
        {
            string sql = "SELECT * FROM Departments ORDER BY DepartmentID ASC;";
            currentDepartmentId = (int)DataAccess.GetValue(sql);
            LoadDepartmentDetails();
        }

        private void LoadDepartmentDetails()
        {
            //Clear any errors in the error provider
            errProvider.Clear();

            string[] sqlStatements = new string[]
            {
                $"SELECT * FROM Departments WHERE DepartmentId = {currentDepartmentId}",

                $@"
                SELECT
                    (SELECT TOP(1)
                        DepartmentId as FirstDepartmentId
                    FROM Departments
                    ORDER BY DepartmentID
                        ) as FirstDepartmentId,
                    NavInfo.PreviousDepartmentId,
                    NavInfo.NextDepartmentId,
                    (SELECT TOP(1)
                        DepartmentId as LastDepartmentId
                    FROM Departments
                    ORDER BY DepartmentID Desc
                        ) as LastDepartmentId,
                    NavInfo.RowNumber
                FROM
                    (
                    SELECT
                        DepartmentId,
                        DepartmentName,
                        LEAD(DepartmentId) OVER(ORDER BY DepartmentID) AS NextDepartmentId,
                        LAG(DepartmentId) OVER(ORDER BY DepartmentID) AS PreviousDepartmentId,
                        ROW_NUMBER() OVER(ORDER BY DepartmentID) AS 'RowNumber'
                    FROM Departments
                ) AS NavInfo
                WHERE NavInfo.DepartmentId = {currentDepartmentId}
                ORDER BY NavInfo.DepartmentName"
                .Replace(System.Environment.NewLine," "),

                "SELECT COUNT(DepartmentId) as DepartmentCount FROM Departments"
            };

            DataSet ds = new DataSet();
            ds = DataAccess.GetData(sqlStatements);

            DataRow selectedDepartment = ds.Tables[0].Rows[0];

            txtDepartmentID.Text = selectedDepartment["DepartmentId"].ToString();
            txtDepartmentName.Text = selectedDepartment["DepartmentName"].ToString();
            txtDescription.Text = selectedDepartment["Description"].ToString();

            firstDepartmentId = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstDepartmentId"]);
            previousDepartmentId = ds.Tables[1].Rows[0]["PreviousDepartmentId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousDepartmentId"]) : (int?)null;
            nextDepartmentId = ds.Tables[1].Rows[0]["NextDepartmentId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextDepartmentId"]) : (int?)null;
            lastDepartmentId = Convert.ToInt32(ds.Tables[1].Rows[0]["LastDepartmentId"]);
            currentRecord = Convert.ToInt32(ds.Tables[1].Rows[0]["RowNumber"]);

            int totalDepartmentCount = (int)ds.Tables[2].Rows[0]["DepartmentCount"];

            toolStripStatusLabel1.Text = $"Displaying Department {currentRecord} of {totalDepartmentCount}";
            NextPreviousButtonManagement();
        }

        #endregion

        #region [Validation Events and Methods]

        private void cmb_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            string errMsg = string.Empty;
            bool failedValidation = false;

            if (cmb.SelectedIndex == -1 || String.IsNullOrEmpty(cmb.SelectedValue.ToString()))
            {
                errMsg = $"{cmb.Tag} is required";
                failedValidation = true;
            }

            e.Cancel = failedValidation;
            errProvider.SetError(cmb, errMsg);
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            UIUtilities.TextValidating(sender, e, errProvider);
        }



        #endregion

        #region [Navigation Helpers]

        private void NextPreviousButtonManagement()
        {
            btnPrevious.Enabled = previousDepartmentId != null;
            btnNext.Enabled = nextDepartmentId != null;
        }

        private void NavigationState(bool enableState)
        {
            btnFirst.Enabled = enableState;
            btnLast.Enabled = enableState;
            btnNext.Enabled = enableState;
            btnPrevious.Enabled = enableState;
        }
        private void Navigation_Handler(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                toolStripStatusLabel2.Text = string.Empty;

                switch (b.Name)
                {
                    case "btnFirst":
                        currentDepartmentId = firstDepartmentId;
                        toolStripStatusLabel2.Text = "The first Department is currently displayed";
                        break;
                    case "btnLast":
                        currentDepartmentId = lastDepartmentId;
                        toolStripStatusLabel2.Text = "The last Department is currently displayed";
                        break;
                    case "btnPrevious":
                        currentDepartmentId = previousDepartmentId.Value;

                        if (currentRecord == 1)
                            toolStripStatusLabel2.Text = "The first Department is currently displayed";
                        break;
                    case "btnNext":
                        currentDepartmentId = nextDepartmentId.Value;

                        break;
                }

                LoadDepartmentDetails();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion


        #region [Form Helpers]

        private void ClearControls(Control.ControlCollection controls)
        {
            foreach (Control ctl in controls)
            {
                switch (ctl)
                {
                    case TextBox txt:
                        txt.Clear();
                        break;
                    case CheckBox chk:
                        chk.Checked = false;
                        break;
                    case GroupBox gB:
                        ClearControls(gB.Controls);
                        break;
                }
            }
        }

        private void ProgressBar()
        {
            this.toolStripStatusLabel3.Text = "Processing...";
            prgBar.Value = 0;
            this.statusStrip1.Refresh();

            while (prgBar.Value < prgBar.Maximum)
            {
                Thread.Sleep(10);
                prgBar.Value += 1;
            }

            prgBar.Value = 100;

            this.toolStripStatusLabel3.Text = "Processed";
        }

        public void CreateDepartment()
        {
            string departmentName = txtDepartmentName.Text;
            string departmentDescription = txtDescription.Text;
            string sql = $"INSERT INTO Departments (DepartmentName, Description) VALUES ('{departmentName}', '{departmentDescription}');";

            int rowAffected = DataAccess.SendData(sql);

            if (rowAffected == 1)
            {
                MessageBox.Show($"Records Created: {rowAffected}");

                btnAdd.Enabled = true;
                btnDelete.Enabled = true;


                NavigationState(true);
                LoadFirstDepartment();
            }
            else
            {
                MessageBox.Show("Department creation failed");
            }
        }

        public void SaveDepartmentChanges()
        {
            String sql =
                    @$"UPDATE Departments 
                    SET DepartmentName = '{txtDepartmentName.Text}', 
                    Description = '{txtDescription.Text}' 
                    WHERE DepartmentID = {currentDepartmentId};";

            sql = DataAccess.SQLCleaner(sql);

            int rowAffected = DataAccess.SendData(sql);

            if (rowAffected == 1)
            {
                MessageBox.Show($"Records Updated: {rowAffected}");

                btnAdd.Enabled = true;
                btnDelete.Enabled = true;

                NavigationState(true);
                LoadFirstDepartment();
            }
            else
            {
                MessageBox.Show("Department update failed");
            }
        }

        #endregion

    }
}
