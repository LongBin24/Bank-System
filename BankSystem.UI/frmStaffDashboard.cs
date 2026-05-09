using BankSystem.Models;

namespace BankSystem.UI
{
    public partial class frmStaffDashboard : Form
    {
        private BankSystem.Models.User _currentStaff;

        public frmStaffDashboard(BankSystem.Models.User staff)
        {
            InitializeComponent();
            _currentStaff = staff;
            lblWelcome.Text = _currentStaff.FullName;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer f = new frmAddCustomer(_currentStaff);
            Navigation.SwitchForm(this, f);
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {

            frmCustomerList listForm = new frmCustomerList(_currentStaff, "Customer");
            Navigation.SwitchForm(this, listForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmStaffDashboard_Load(object sender, EventArgs e)
        {

        }

        private void staffListBtn_Click(object sender, EventArgs e)
        {
            frmCustomerList liststaff = new frmCustomerList(_currentStaff, "Staff");
            Navigation.SwitchForm(this, liststaff);
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmAddStaff f = new frmAddStaff(_currentStaff);
            Navigation.SwitchForm(this, f);
        }
    }
}
