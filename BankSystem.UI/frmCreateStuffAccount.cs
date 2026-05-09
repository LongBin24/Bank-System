using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystem.BLL;
using BankSystem.Models;

namespace BankSystem.UI
{
    public partial class frmCreateStuffAccount : Form
    {
        private User _currentUser;

        public frmCreateStuffAccount()
        {
            InitializeComponent();
        }

        public frmCreateStuffAccount(User currentUser) : this()
        {
            _currentUser = currentUser;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPIN.Text))
                {
                    MessageBox.Show("សូមបំពេញឈ្មោះ និង PIN!");
                    return;
                }

                var user = new User
                {
                    FullName = txtName.Text.Trim(),
                    PIN = txtPIN.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Role = "Staff"
                };

                BankService svc = new BankService();
                bool ok = svc.RegisterStaff(user);

                if (ok)
                {
                    MessageBox.Show("បង្កើតគណនីបុគ្គលិកជោគជ័យ!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ការបង្កើតគណនីបរាជ័យ!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("មានបញ្ហា: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                frmStaffDashboard dashboard = new frmStaffDashboard(_currentUser);
                Navigation.SwitchForm(this, dashboard);
            }
            this.Close();
        }

        private void frmCreateStuffAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
