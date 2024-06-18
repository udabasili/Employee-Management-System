using DBProgrammingDemo9;
using System.Data;

namespace EmployeeManagamentSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                //verify the username and password from the database
                string sql = $"SELECT * FROM Users WHERE Username = '{username}' AND Password = '{password}'";
                DataTable dt = DataAccess.GetData(sql);

                if (dt.Rows.Count == 1)
                {
                    //login successful
                    UIUtilities.CurrentUserID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                    frmEmployeeSystemManager frmEmployeeSystemManager = new frmEmployeeSystemManager();
                    frmEmployeeSystemManager.Show();
                    this.Hide();
                }
                else
                {
                    throw new Exception("Invalid username or password");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lnkRegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();

            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //set default values
            txtUsername.Text = "admin";
            txtPassword.Text = "admin";
        }
    }
}
