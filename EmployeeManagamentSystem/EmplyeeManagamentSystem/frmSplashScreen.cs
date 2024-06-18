namespace EmployeeManagamentSystem
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {

            try
            {
                lblVersion.Text = Application.ProductVersion;
                lblProductName.Text = Application.ProductName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void tmrProgressBar_Tick(object sender, EventArgs e)
        {


            try
            {
                pgrLoadProgress.Increment(1);
                lblProgress.Text = pgrLoadProgress.Value.ToString() + "%";

                if (pgrLoadProgress.Value == pgrLoadProgress.Maximum)
                {

                    tmrProgressBar.Enabled = false;

                    tmrProgressBar.Stop();

                    frmLogin frmLogin = new frmLogin();
                    frmLogin.FormClosed += frmClosed;
                    frmLogin.Show();

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
