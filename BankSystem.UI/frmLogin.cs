using BankSystem.BLL;
using BankSystem.Models;


namespace BankSystem.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AuthService auth = new AuthService();
            BankSystem.Models.User user = auth.Authenticate(txtUserID.Text, txtPIN.Text);

            if (user != null)
            {
                if (user.Role == "Staff")
                {
                    BankSystem.UI.frmStaffDashboard dashboard = new BankSystem.UI.frmStaffDashboard(user);

                    this.Hide();

                    dashboard.Show();
                }
                else if (user.Role == "Customer")
                {
                    if (user.Role == "Staff")
                    {
                        frmStaffDashboard staffDash = new frmStaffDashboard(user);
                        Navigation.SwitchForm(this, staffDash);
                    }
                    else if (user.Role == "Customer")
                    {

                        frmCustomerDashboard custDash = new frmCustomerDashboard(user);
                        Navigation.SwitchForm(this, custDash);
                    }
                }
            }
            else
            {
                MessageBox.Show("លេខសម្គាល់ ឬលេខសម្ងាត់មិនត្រឹមត្រូវ!");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
