using System;
using System.Windows.Forms;
using BankSystem.BLL;   
using BankSystem.Models;

namespace BankSystem.UI
{
    public partial class frmAddCustomer : Form
    {
        private BankSystem.Models.User _currentUser;
        public frmAddCustomer(BankSystem.Models.User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPIN.Text))
                {
                    MessageBox.Show("សូមបំពេញឈ្មោះ និងលេខសម្ងាត់!");
                    return;
                }

                StaffService staff = new StaffService();

                if (decimal.TryParse(txtDeposit.Text, out decimal initialDeposit))
                {
                    bool success = staff.CreateNewCustomer(
                        txtName.Text,
                        txtPIN.Text,
                        txtPhone.Text,
                        initialDeposit,
                        cbCurrency.Text
                    );

                    if (success)
                    {
                        MessageBox.Show("បង្កើតគណនីអតិថិជនជោគជ័យ!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ការបង្កើតគណនីបរាជ័យ!");
                    }
                }
                else
                {
                    MessageBox.Show("សូមបញ្ចូលចំនួនទឹកប្រាក់ជាលេខ!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("មានបញ្ហា៖ " + ex.Message);
            }
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmStaffDashboard dashboard = new frmStaffDashboard(_currentUser);
            Navigation.SwitchForm(this, dashboard);

        }
    }
}