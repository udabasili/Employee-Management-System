using DBProgrammingDemo9;
using System.Data;

namespace EmployeeManagamentSystem
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void lnkLoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();

            this.Hide();
        }

        public void GetRoles()
        {
            string sql = "SELECT RoleID, RoleName FROM Roles;";
            DataTable dtRoles = DataAccess.GetData(sql);
            if (dtRoles.Rows.Count == 0)
            {
                MessageBox.Show("No roles found in the database. Please add roles first.");
                return;
            }

            UIUtilities.BindComboBox(cmbRoles, dtRoles, "RoleName", "RoleID");

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            try
            {
                GetRoles();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtValidation(object sender)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrEmpty(txt.Text))
            {
                errProvider.SetError(txt, "This field is required.");
            }
            else
            {
                errProvider.SetError(txt, "");
            }
        }

        private bool CreateAccount()

        {
            bool userCreated = false;

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            DateTime createdAt = DateTime.Now;
            DataRow dataRow = ((DataRowView)cmbRoles.SelectedItem).Row;
            int roleID = (int)dataRow["RoleID"];


            string sql = $"INSERT INTO Users (Username, Password, Email, Role, CreatedAt) VALUES ('{username}', '{password}', '{email}', {roleID}, '{createdAt}');";

            int rowAffected = DataAccess.SendData(sql);

            if (rowAffected == 1)
            {
                MessageBox.Show($"Records Created: {rowAffected}");
                // get the user id
                sql = $"SELECT UserID FROM Users WHERE Username = '{username}';";
                DataTable dt = DataAccess.GetData(sql);
                int userId = (int)dt.Rows[0]["UserID"];

                UIUtilities.CurrentUserID = userId;
                userCreated = true;


            }
            else
            {
                MessageBox.Show("Product creation failed");
            }
            return userCreated;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    bool userCreated = CreateAccount();
                    if (userCreated)
                    {
                        frmEmployeeSystemManager frmEmployeeSystemManager = new frmEmployeeSystemManager();
                        frmEmployeeSystemManager.Show();
                        this.Hide();
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            txtValidation(sender);
            if (sender == txtEmail)
            {
                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    errProvider.SetError(txtEmail, "Invalid email address.");
                }
                else
                {
                    errProvider.SetError(txtEmail, "");
                }
            }
        }

        private void cmbRoles_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            UIUtilities.ComboBoxValidating(sender, e, errProvider);
        }
    }
}
