using DBProgrammingDemo9;
using System.ComponentModel;
using System.Data;

namespace EmployeeManagamentSystem
{
    public partial class frmManager : Form
    {
        int selectedDepartmentID;
        public frmManager()
        {
            InitializeComponent();
        }

        private void frmManager_Load(object sender, EventArgs e)
        {

            LoadEmployees();
            LoadDepartments();
        }

        private void LoadEmployees()
        {
            try
            {
                string sqlString =
                    $@"SELECT EmployeeID, 
                        CONCAT(FirstName, ' ', LastName) AS EmployeeName 
                        FROM Employees;";
                DataTable dtEmployees = DataAccess.GetData(sqlString);
                UIUtilities.BindComboBox(cboNewManager, dtEmployees, "EmployeeName", "EmployeeID");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDepartmentCurrentManager()
        {
            try
            {
                string sqlString =
                    $@"
                       SELECT
                            (SELECT CONCAT(FirstName, ' ', LastName)
                            FROM Employees
                            WHERE Employees.EmployeeID = Departments.ManagerID) as CurrentManager
                        FROM Departments
                        WHERE DepartmentID = {selectedDepartmentID};
                    ";
                DataTable dtDepartments = DataAccess.GetData(sqlString);
                string currentManager = dtDepartments.Rows[0]["CurrentManager"] != DBNull.Value ? dtDepartments.Rows[0]["CurrentManager"].ToString() : "No Manager";
                txtCurrentManager.Text = currentManager;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void LoadDepartments()
        {
            try
            {



                string sqlString =
                    $@"
                        SELECT
                            Departments.DepartmentID,
                            Departments.DepartmentName
                        FROM Departments

                    ";
                DataTable dtDepartments = DataAccess.GetData(sqlString);
                if (dtDepartments.Rows.Count > 0)
                {
                    UIUtilities.BindComboBox(cboDepartments, dtDepartments, "DepartmentName", "DepartmentID");


                }
                else
                {
                    MessageBox.Show("No department found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void cbo_Validating(object sender, CancelEventArgs eventArgs)
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            try
            {
                if (cboDepartments.SelectedIndex == -1 || cboDepartments.SelectedValue == DBNull.Value)
                {
                    MessageBox.Show("Please select a department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cboNewManager.SelectedIndex == -1 || cboNewManager.SelectedValue == DBNull.Value)
                {
                    MessageBox.Show("Please select a manager", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int newManagerID = Convert.ToInt32(cboNewManager.SelectedValue);
                int departmentID = Convert.ToInt32(cboDepartments.SelectedValue);
                string sqlString = $@"
                    UPDATE Employees SET DepartmentID = {departmentID} WHERE EmployeeID = {newManagerID};
                    UPDATE Departments SET ManagerID = {newManagerID} WHERE DepartmentID = {departmentID};
                ";
                int recordAffected = DataAccess.SendData(sqlString);

                if (recordAffected == 2)
                {
                    MessageBox.Show("Manager added successfully");
                    LoadDepartmentCurrentManager();
                }
                else
                {

                    MessageBox.Show("Failed to add manager");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cboDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboDepartments.SelectedIndex == -1 || cboDepartments.SelectedValue == DBNull.Value)
                {
                    return;
                }

                selectedDepartmentID = Convert.ToInt32(cboDepartments.SelectedValue);
                LoadDepartmentCurrentManager();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
