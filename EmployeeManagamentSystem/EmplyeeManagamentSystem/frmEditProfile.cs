using DBProgrammingDemo9;
using System.ComponentModel;
using System.Data;
using System.Net.Mail;

namespace EmployeeManagamentSystem
{
    public partial class frmEditProfile : Form
    {
        int currentUserId = UIUtilities.CurrentUserID;

        public frmEditProfile()
        {
            InitializeComponent();
        }

        private void frmEditProfile_Load(object sender, EventArgs e)
        {
            try
            {
                GetCurrentUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GetCurrentUser()
        {

            string userQuery = $@"SELECT Username FROM Users WHERE UserId = '{currentUserId}'";
            DataTable dtUser = DataAccess.GetData(userQuery);
            if (dtUser.Rows.Count == 1)
            {
                DataRow dr = dtUser.Rows[0];
                txtUsername.Text = dr["Username"].ToString();
            }
            string query =
                $@"
                    SELECT
                    EmployeeID,
                    Employees.FirstName,
                    Employees.LastName,
                    Employees.Email,
                    Users.Username,
                    Employees.DateOfBirth,
                    Employees.EmploymentDate
                FROM Employees
                    INNER JOIN Users
                    ON Employees.UserID = Users.UserID
                WHERE Users.UserID = {currentUserId};
                 ";
            dtUser = DataAccess.GetData(query);
            if (dtUser.Rows.Count > 0)
            {
                DataRow dr = dtUser.Rows[0];
                txtEmployeeID.Text = dr["EmployeeID"].ToString();
                txtFirstname.Text = dr["FirstName"].ToString();
                txtLastName.Text = dr["LastName"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                txtUsername.Text = dr["Username"].ToString();
                dtpDateOfBirth.Value = Convert.ToDateTime(dr["DateOfBirth"]);
                dtpEmployemntDate.Value = Convert.ToDateTime(dr["EmploymentDate"]);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

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
                    GetCurrentUser();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateEmployee()
        {
            string query = $@"
                INSERT INTO Employees
                (FirstName, LastName, Email, DateOfBirth, EmploymentDate, UserID)
                VALUES
                ('{txtFirstname.Text}', '{txtLastName.Text}', '{txtEmail.Text}', '{dtpDateOfBirth.Value}', '{dtpEmployemntDate.Value}', {UIUtilities.CurrentUserID});
            ";
            int rowsAffected = DataAccess.SendData(query);
            if (rowsAffected == 1)
            {
                MessageBox.Show("Employee Created Successfully");
            }
            else
            {
                MessageBox.Show("Employee Creation Failed");
            }
        }

        private void SaveEmployeeChanges()
        {
            string query = $@"
                UPDATE Employees
                SET
                FirstName = '{txtFirstname.Text}',
                LastName = '{txtLastName.Text}',
                Email = '{txtEmail.Text}',
                DateOfBirth = '{dtpDateOfBirth.Value}',
                EmploymentDate = '{dtpEmployemntDate.Value}'
                WHERE UserId = {currentUserId};
            ;";
            if (txtUsername.Text != string.Empty)
            {
                query += $@"
                    UPDATE Users
                    SET
                    Username = '{txtUsername.Text}',
                    Email = '{txtEmail.Text}'
                    WHERE UserID = {currentUserId};
                ;";
            }
            int rowsAffected = DataAccess.SendData(query);
            if (rowsAffected == 2)
            {
                MessageBox.Show("Employee Updated Successfully");
                GetCurrentUser();
            }
            else
            {
                MessageBox.Show("Employee Update Failed");
            }
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
    }
}
