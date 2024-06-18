using DBProgrammingDemo9;
using System.Data;

namespace EmployeeManagamentSystem
{
    public partial class frmViewDepartments : Form
    {
        public frmViewDepartments()
        {
            InitializeComponent();
        }

        private void frmViewDepartments_Load(object sender, EventArgs e)
        {
            try
            {

                string sqlString = "SELECT * FROM Departments";

                DataTable dtDepartments = DataAccess.GetData(sqlString);
                dgvDepartments.DataSource = dtDepartments;

                dgvDepartments.Columns[0].HeaderText = "Department ID";
                dgvDepartments.AutoResizeColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
