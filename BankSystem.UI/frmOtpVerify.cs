using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace BankSystem.UI
{
    public partial class frmOtpVerify : Form
    {
        private BankSystem.Models.User _user;
        private string _correctOtp;
        public frmOtpVerify(BankSystem.Models.User user, string otp)
        {
            InitializeComponent();
            _user = user;
            _correctOtp = otp;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {


            if (txtInputOtp.Text == _correctOtp)
            {
                MessageBox.Show("ផ្ទៀងផ្ទាត់ជោគជ័យ!");

                if (_user.Role == "Staff")
                {
                    frmStaffDashboard staffDash = new frmStaffDashboard(_user);
                    Navigation.SwitchForm(this, staffDash);
                }
                else if (_user.Role == "Customer")
                {
                    frmCustomerDashboard custDash = new frmCustomerDashboard(_user);
                    Navigation.SwitchForm(this, custDash);
                }
            }
            else
            {
                MessageBox.Show("លេខ OTP មិនត្រឹមត្រូវទេ!");
            }
        }

        private void frmOtpVerify_Load(object sender, EventArgs e)
        {

        }
    }
}
