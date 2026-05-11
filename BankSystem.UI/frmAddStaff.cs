using BankSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.UI
{
    public partial class frmAddStaff : Form
    {
        private BankSystem.Models.User _currentUser;
        public frmAddStaff(BankSystem.Models.User user)
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
                if (txtPIN.Text != txtConfirmPIN.Text)
                {
                    MessageBox.Show("លេខសម្ងាត់មិនត្រូវគ្នាទេ!");
                    return;
                }

                StaffService staff = new StaffService();

                bool success = staff.CreateNewStaff(
                    txtName.Text,
                    txtPIN.Text,
                    txtPhone.Text
                );

                if (success)
                {
                    MessageBox.Show("បន្ថែមបុគ្គលិកថ្មីជោគជ័យ!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("មានបញ្ហា មិនអាចបន្ថែមបានឡើយ!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("មានបញ្ហា៖ " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmStaffDashboard form = new frmStaffDashboard(_currentUser);
            Navigation.SwitchForm(this, form);
        }
    }
}
