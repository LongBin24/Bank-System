using System;
using System.Windows.Forms;
using BankSystem.Models;
using BankSystem.BLL;  

namespace BankSystem.UI
{
    public partial class frmCustomerDashboard : Form
    {

        private BankSystem.Models.User _currentCustomer;
        private BankService _bankService = new BankService();

        public frmCustomerDashboard(BankSystem.Models.User user)
        {
            InitializeComponent();
            _currentCustomer = user;
        }


        private void frmCustomerDashboard_Load(object sender, EventArgs e)
        {
            if (_currentCustomer != null)
            {
                lblCustomerName.Text = _currentCustomer.FullName;
                lblAccountID.Text = "លេខគណនី: " + _currentCustomer.UserID;


                RefreshBalance();
            }
        }


        public void RefreshBalance()
        {

            var acc = _bankService.GetAccountByUserId(_currentCustomer.UserID);
            if (acc != null)
            {
                lblBalance.Text = acc.Balance.ToString("N2") + " " + acc.Currency;
            }
            else
            {
                lblBalance.Text = "0.00";
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            frmDeposit f = new frmDeposit(_currentCustomer);
            Navigation.SwitchForm(this, f);
            RefreshBalance();
        }

        private void btnTransfer_Click_1(object sender, EventArgs e)
        {
            frmTransfer f = new frmTransfer(_currentCustomer);
            Navigation.SwitchForm(this, f);
            RefreshBalance();
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            frmExchange f = new frmExchange(_currentCustomer);
            Navigation.SwitchForm(this, f);
            RefreshBalance();
        }

        private void btnWithdraw_Click_1(object sender, EventArgs e)
        {
            frmWithdraw f = new frmWithdraw(_currentCustomer);
            Navigation.SwitchForm(this, f);
            RefreshBalance();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
            BankSystem.UI.frmLogin loginForm = new BankSystem.UI.frmLogin();
            Navigation.SwitchForm(this, loginForm);
        }

        private void btnHistory_Click_1(object sender, EventArgs e)
        {
            frmHistory f = new frmHistory(_currentCustomer);
            Navigation.SwitchForm(this, f);
        }
    }
}