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
            lblWelcome.Text =_currentStaff.FullName;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer f = new frmAddCustomer(_currentStaff);
            Navigation.SwitchForm(this, f);
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
       
            frmCustomerList listForm = new frmCustomerList(_currentStaff);
            Navigation.SwitchForm(this, listForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        private void frmStaffDashboard_Load(object sender, EventArgs e)
        {
                    
        }
    }
}
