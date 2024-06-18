using DBProgrammingDemo9;
using System.ComponentModel;
using System.Data;
using System.Net.Mail;

namespace EmployeeManagamentSystem
{
    public partial class frmEmployeeMaintenance : Form
    {
        public frmEmployeeMaintenance()
        {
            InitializeComponent();
        }

        int currentRecord = 0;
        int currentEmployeeId = 0;
        int firstEmployeeId = 0;
        int lastEmployeeId = 0;
        int? previousEmployeeId;
        int? nextEmployeeId;

        #region Event Listeners


        private void frmEmployeeMaintenance_Load(object sender, EventArgs e)
        {
            LoadDepartments();

            LoadFirstEmployee();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Adding a new Employee";
            toolStripStatusLabel2.Text = "";

            ClearControls(grpEmployees.Controls);

            btnSave.Text = "Create";

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;

            NavigationState(false);


        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    string sql = $"DELETE FROM Employees WHERE EmployeeID = {currentEmployeeId};";
                    int rowAffected = DataAccess.SendData(sql);

                    if (rowAffected == 1)
                    {
                        MessageBox.Show("Employee Deleted");
                        LoadFirstEmployee();
                    }
                    else
                    {
                        MessageBox.Show("Employee Deletion Failed");
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

                // TODO: Test for Validation of Controls
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (txtEmployeeID.Text != string.Empty)
                    {
                        SaveEmployeeChanges();
                    }
                    else
                    {
                        CreateEmployee();

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
                LoadEmployeeDetails();

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

        private void LoadDepartments()
        {
            string sql = "SELECT DepartmentID, DepartmentName FROM Departments";
            DataTable dtDepartments = DataAccess.GetData(sql);
            UIUtilities.BindComboBox(cboDepartments, dtDepartments, "DepartmentName", "DepartmentID");


        }

        private void LoadFirstEmployee()
        {
            string sql = "SELECT * FROM Employees ORDER BY EmployeeID ASC;";
            currentEmployeeId = (int)DataAccess.GetValue(sql);
            LoadEmployeeDetails();
        }

        private void LoadEmployeeDetails()
        {
            //Clear any errors in the error provider
            errProvider.Clear();

            string[] sqlStatements = new string[]
            {
                $"SELECT * FROM Employees WHERE EmployeeId = {currentEmployeeId}",
                $@"
                
                    SELECT
                        NavInfo.DepartmentID,
                        (SELECT TOP(1)
                            EmployeeId as FirstEmployeeId
                        FROM Employees
                        ORDER BY EmployeeID
                            ) as FirstEmployeeId,
                        NavInfo.PreviousEmployeeId,
                        NavInfo.NextEmployeeId,
                        (SELECT TOP(1)
                            EmployeeId as LastEmployeeId
                        FROM Employees
                        ORDER BY EmployeeID Desc
                            ) as LastEmployeeId,
                        NavInfo.RowNumber
                    FROM
                        (
                        SELECT
                            EmployeeId,
                            FirstName,
                            LastName,
                            Email,
                            DateOfBirth,
                            DepartmentID,
                            EmploymentDate,
                            LEAD(EmployeeId) OVER(ORDER BY EmployeeID) AS NextEmployeeId,
                            LAG(EmployeeId) OVER(ORDER BY EmployeeID) AS PreviousEmployeeId,
                            ROW_NUMBER() OVER(ORDER BY EmployeeID) AS 'RowNumber'
                        FROM Employees
                    ) AS NavInfo
                        INNER JOIN Departments
                        ON NavInfo.DepartmentID = Departments.DepartmentID
                    WHERE NavInfo.EmployeeId = {currentEmployeeId}
                    ORDER BY NavInfo.EmployeeID"
                .Replace(System.Environment.NewLine," "),

                "SELECT COUNT(EmployeeId) as EmployeeCount FROM Employees"
            };

            DataSet ds = new DataSet();
            ds = DataAccess.GetData(sqlStatements);

            // From the first table 
            DataRow selectedEmployee = ds.Tables[0].Rows[0];

            txtEmployeeID.Text = selectedEmployee["EmployeeId"].ToString();
            txtFirstname.Text = selectedEmployee["FirstName"].ToString();
            txtLastName.Text = selectedEmployee["LastName"].ToString();
            txtEmail.Text = selectedEmployee["Email"].ToString();
            dtpDateOfBirth.Value = (DateTime)selectedEmployee["DateOfBirth"];
            dtpEmployemntDate.Value = (DateTime)selectedEmployee["EmploymentDate"];
            cboDepartments.SelectedValue = selectedEmployee["DepartmentID"];



            firstEmployeeId = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstEmployeeId"]);
            previousEmployeeId = ds.Tables[1].Rows[0]["PreviousEmployeeId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousEmployeeId"]) : (int?)null;
            nextEmployeeId = ds.Tables[1].Rows[0]["NextEmployeeId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextEmployeeId"]) : (int?)null;
            lastEmployeeId = Convert.ToInt32(ds.Tables[1].Rows[0]["LastEmployeeId"]);
            currentRecord = Convert.ToInt32(ds.Tables[1].Rows[0]["RowNumber"]);

            int totalEmployeeCount = (int)ds.Tables[2].Rows[0]["EmployeeCount"];

            //Which item we are on in the count
            toolStripStatusLabel1.Text = $"Displaying Employee {currentRecord} of {totalEmployeeCount}";
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

        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string? txtBoxName = txt.Tag.ToString();
            string errMsg = string.Empty;
            bool failedValidation = false;

            if (txt.Text == string.Empty)
            {
                errMsg = $"{txtBoxName} is required";
                failedValidation = true;
            }
            else if (txt.Name == "txtEmail")
            {
                if (!IsValidEmail(txt.Text))
                {
                    errMsg = "Invalid Email Address";
                    failedValidation = true;
                }
            }

            e.Cancel = failedValidation;

            errProvider.SetError(txt, errMsg);
        }


        #endregion

        #region [Navigation Helpers]

        private void NextPreviousButtonManagement()
        {
            btnPrevious.Enabled = previousEmployeeId != null;
            btnNext.Enabled = nextEmployeeId != null;
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
                        currentEmployeeId = firstEmployeeId;
                        toolStripStatusLabel2.Text = "The first Employee is currently displayed";
                        break;
                    case "btnLast":
                        currentEmployeeId = lastEmployeeId;
                        toolStripStatusLabel2.Text = "The last Employee is currently displayed";
                        break;
                    case "btnPrevious":
                        currentEmployeeId = previousEmployeeId.Value;

                        if (currentRecord == 1)
                            toolStripStatusLabel2.Text = "The first Employee is currently displayed";
                        break;
                    case "btnNext":
                        currentEmployeeId = nextEmployeeId.Value;

                        break;
                }

                LoadEmployeeDetails();
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
                    case DateTimePicker dtp:
                        dtp.Value = DateTime.Now;
                        break;
                    case ComboBox cbo:
                        cbo.SelectedIndex = -1;
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

        public void CreateEmployee()
        {

            string email = txtEmail.Text;
            string firstName = txtFirstname.Text;
            string lastName = txtLastName.Text;
            DateTime dob = dtpDateOfBirth.Value;
            DateTime employmentDate = dtpEmployemntDate.Value;
            int departmentId = (int)cboDepartments.SelectedValue;

            string sql = $"INSERT INTO Employees (DepartmentID, FirstName, LastName, DateOfBirth, EmploymentDate, Email) VALUES ({departmentId}, '{firstName}', '{lastName}', '{dob}', '{employmentDate}', '{email}');";


            int rowAffected = DataAccess.SendData(sql);

            if (rowAffected == 1)
            {
                MessageBox.Show($"Records Created: {rowAffected}");

                btnAdd.Enabled = true;
                btnDelete.Enabled = true;


                NavigationState(true);
                LoadFirstEmployee();
            }
            else
            {
                MessageBox.Show("Employee creation failed");
            }
        }

        public void SaveEmployeeChanges()
        {
            int employeeId = Convert.ToInt32(txtEmployeeID.Text);
            string email = txtEmail.Text;
            string firstName = txtFirstname.Text;
            string lastName = txtLastName.Text;
            DateTime dateOfBirth = dtpDateOfBirth.Value;
            DateTime employmentDate = dtpEmployemntDate.Value;
            int departmentId = (int)cboDepartments.SelectedValue;

            string employeeSQL =
                @$"
                UPDATE Employees SET DepartmentID = {departmentId}, 
                FirstName = '{firstName}', 
                LastName = '{lastName}', 
                DateOfBirth = '{dateOfBirth}', 
                EmploymentDate = '{employmentDate}', 
                Email = '{email}' 
                WHERE EmployeeID = {currentEmployeeId};";

            employeeSQL = DataAccess.SQLCleaner(employeeSQL);

            int rowAffected = DataAccess.SendData(employeeSQL);

            if (rowAffected == 1)
            {
                MessageBox.Show($"Records Updated: {rowAffected}");

                btnAdd.Enabled = true;
                btnDelete.Enabled = true;

                NavigationState(true);
                LoadFirstEmployee();
            }
            else
            {
                MessageBox.Show("Employee update failed");
            }
        }

        #endregion

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {

        }
    }
}
