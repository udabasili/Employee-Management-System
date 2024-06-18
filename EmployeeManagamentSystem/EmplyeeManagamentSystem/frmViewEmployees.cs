using DBProgrammingDemo9;
using System.Data;

namespace EmployeeManagamentSystem
{
    public partial class frmViewEmployees : Form
    {
        public frmViewEmployees()
        {
            InitializeComponent();
        }

        private void LoadDepartments()
        {
            string sqlString = "SELECT * FROM Departments";

            DataTable dtDepartments = DataAccess.GetData(sqlString);
            //insert a new row at the at select index 1 that says all departments
            DataRow dr = dtDepartments.NewRow();
            dr["DepartmentID"] = 0;
            dr["DepartmentName"] = "All Departments";
            dtDepartments.Rows.InsertAt(dr, 0);
            UIUtilities.BindComboBox(cboDepartment, dtDepartments, "DepartmentName", "DepartmentID");


        }

        private void frmViewEmployees_Load(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel1.Text = "";
                toolStripStatusLabel2.Text = "";
                LoadDepartments();

                string sqlString = "SELECT * FROM Employees";
                DataTable dtDepartments = DataAccess.GetData(sqlString);
                dgvEmployees.DataSource = dtDepartments;

                dgvEmployees.Columns[0].HeaderText = "Employee ID";

                dgvEmployees.AutoResizeColumns();

                toolStripStatusLabel1.Text = "Total Employees: " + dtDepartments.Rows.Count;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel2.Text = "";

                if (cboDepartment.SelectedIndex == -1 || cboDepartment.SelectedValue == DBNull.Value)
                {
                    return;
                }
                string sqlString = "SELECT * FROM Employees WHERE DepartmentID = " + cboDepartment.SelectedValue;
                if (cboDepartment.SelectedIndex == 1)
                {
                    sqlString = "SELECT * FROM Employees";
                }
                DataTable dtDepartments = DataAccess.GetData(sqlString);
                dgvEmployees.DataSource = dtDepartments;

                dgvEmployees.Columns[0].HeaderText = "Employee ID";

                dgvEmployees.AutoResizeColumns();
                toolStripStatusLabel1.Text = "Total Employees: " + dtDepartments.Rows.Count;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try

            {
                if (e.RowIndex == -1)
                {
                    return;
                }

                toolStripStatusLabel2.Text = "Record " + (e.RowIndex + 1) + " of " + dgvEmployees.Rows.Count;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
