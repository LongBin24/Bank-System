using BankSystem.BLL;
using BankSystem.DAL;
using BankSystem.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace BankSystem.UI
{
    public partial class frmDeposit : Form
    {

        private BankSystem.Models.User _user;
        private BankService _bankService = new BankService();

        public frmDeposit(BankSystem.Models.User user)
        {
            InitializeComponent();
            _user = user;
        }
        private void btnConfirmDeposit_Click_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                if (amount <= 0)
                {
                    MessageBox.Show("សូមបញ្ចូលចំនួនទឹកប្រាក់លើសពី ០!");
                    return;
                }
                string result = _bankService.Deposit(_user.UserID, amount);

                if (result == "Success")
                {
                    MessageBox.Show("ដាក់ប្រាក់ជោគជ័យ!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            var acc = _bankService.GetAccountByUserId(_user.UserID);
            if (acc != null)
            {
                lblCurrentBalance.Text = "សមតុល្យបច្ចុប្បន្ន: " + acc.Balance.ToString("N2") + " " + acc.Currency;
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomerDashboard dashboard = new frmCustomerDashboard(_user);
            Navigation.SwitchForm(this, dashboard);
            this.Hide();
        }
    }
}
