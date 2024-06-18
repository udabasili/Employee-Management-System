using DBProgrammingDemo9;
using System.Data;

namespace EmployeeManagamentSystem
{
    public partial class frmSalaries : Form
    {

        private int currentEmployeeID;
        private decimal TAX_RATE = 0.15m;

        public frmSalaries()
        {
            InitializeComponent();
        }

        private void frmSalaries_Load(object sender, EventArgs e)
        {
            try
            {
                LoadEmployees();
                LoadSalaries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEmployees()
        {
            try
            {
                string sqlString =
                    $@"SELECT EmployeeID, 
                        CONCAT(FirstName,' ', LastName) AS FullName 
                        FROM Employees";
                DataTable dtEmployees = DataAccess.GetData(sqlString);
                UIUtilities.BindComboBox(cboEmployees, dtEmployees, "FullName", "EmployeeID");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSalaries()
        {
            try
            {
                if (cboEmployees.SelectedIndex == -1 || cboEmployees.SelectedValue == DBNull.Value)
                {
                    return;
                }
                string sqlString =
                    $@"
                        SELECT
                            EmployeeID,
                            CONCAT(FirstName,' ', LastName) as FullName,
                            SalaryBeforeTax,
                            TaxAmount,
                            SalaryAfterTax
                        FROM Employees
                        WHERE EmployeeID = {currentEmployeeID}
    ";
                DataTable dtEmployees = DataAccess.GetData(sqlString);

                if (dtEmployees.Rows.Count == 1)
                {
                    DataRow selectedEmployee = dtEmployees.Rows[0];
                    string fullName = selectedEmployee["FullName"].ToString();
                    decimal salaryBeforeTax = selectedEmployee["SalaryBeforeTax"] != DBNull.Value ? Convert.ToDecimal(selectedEmployee["SalaryBeforeTax"]) : 0;
                    decimal taxAmount = selectedEmployee["TaxAmount"] != DBNull.Value ? Convert.ToDecimal(selectedEmployee["TaxAmount"]) : 0;
                    decimal salaryAfterTax = selectedEmployee["SalaryAfterTax"] != DBNull.Value ? Convert.ToDecimal(selectedEmployee["SalaryAfterTax"]) : 0;

                    txtSalaryAfterTax.Text = salaryAfterTax.ToString("C");
                    txtSalaryBeforeTax.Text = salaryBeforeTax.ToString("C");
                    txtTaxAmount.Text = taxAmount.ToString("C");
                }






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboEmployees.SelectedIndex == -1 || cboEmployees.SelectedValue == DBNull.Value)
                {
                    return;
                }
                currentEmployeeID = Convert.ToInt32(cboEmployees.SelectedValue);
                LoadSalaries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NumericTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (!decimal.TryParse(txtBox.Text, out decimal result))
            {
                e.Cancel = true;
                errProvider.SetError(txtBox, "Please enter a valid number");
            }
            else
            {
                errProvider.SetError(txtBox, "");
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    if (currentEmployeeID == 0)
                    {
                        MessageBox.Show("Please select an employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    decimal salaryBeforeTax = Convert.ToDecimal(txtSalaryBeforeTax.Text);
                    decimal taxAmount = salaryBeforeTax * TAX_RATE;
                    decimal salaryAfterTax = salaryBeforeTax - taxAmount;

                    txtTaxAmount.Text = taxAmount.ToString("C");
                    txtSalaryAfterTax.Text = salaryAfterTax.ToString("C");

                    string sqlString = $@"
                        UPDATE Employees
                        SET
                            SalaryBeforeTax = {salaryBeforeTax},
                            TaxAmount = {taxAmount},
                            SalaryAfterTax = {salaryAfterTax}
                        WHERE EmployeeID = {currentEmployeeID}
                    ";

                    int recordAffected = DataAccess.SendData(sqlString);

                    if (recordAffected == 1)
                    {
                        MessageBox.Show("Salary updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSalaries();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update salary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
