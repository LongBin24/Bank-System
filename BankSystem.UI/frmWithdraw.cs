using BankSystem.Models;
using BankSystem.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BankSystem.UI
{
    public partial class frmWithdraw : Form
    {

        private BankSystem.Models.User _user;
        private BankService _bankService = new BankService();

        public frmWithdraw(BankSystem.Models.User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void frmWithdraw_Load(object sender, EventArgs e)
        {
            if (_user != null)
            {
                var acc = _bankService.GetAccountByUserId(_user.UserID);
                if (acc != null)
                {
                    lblCurrentBalance.Text = "សមតុល្យបច្ចុប្បន្ន: " + acc.Balance.ToString("N2") + " " + acc.Currency;
                }
            }
        }

        private void btnConfirmWithdraw_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                if (amount <= 0)
                {
                    MessageBox.Show("សូមបញ្ចូលចំនួនទឹកប្រាក់ដែលលើសពី ០!");
                    return;
                }

                string result = _bankService.Withdraw(_user.UserID, amount);

                if (result == "Success")
                {
                    MessageBox.Show("ដកប្រាក់ជោគជ័យ!");


                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();


                    frmCustomerDashboard dashboard = new frmCustomerDashboard(_user);
                    Navigation.SwitchForm(this, dashboard);
                }
                else
                {
                    MessageBox.Show(result, "កំហុស", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("សូមបញ្ចូលចំនួនទឹកប្រាក់ជាលេខ!");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fTitle = new Font("Khmer OS Muol Light", 12, FontStyle.Bold);
            Font fBody = new Font("Khmer OS Battambang", 10, FontStyle.Regular);
            Font fBold = new Font("Khmer OS Battambang", 10, FontStyle.Bold);
            Font fItalic = new Font("Khmer OS Battambang", 10, FontStyle.Italic);

            float y = 50;
            g.DrawString("បង្កាន់ដៃដកប្រាក់ (WITHDRAWAL RECEIPT)", fTitle, Brushes.Black, 80, y);
            y += 50;
            g.DrawString("-----------------------------------------------------", fBody, Brushes.Black, 50, y);
            y += 30;
            g.DrawString("កាលបរិច្ឆេទ: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fBody, Brushes.Black, 50, y);
            y += 30;
            g.DrawString("ឈ្មោះអតិថិជន: " + _user.FullName, fBody, Brushes.Black, 50, y);
            y += 30;
            g.DrawString("លេខគណនី: " + _user.UserID, fBody, Brushes.Black, 50, y);
            y += 40;
            g.DrawString("ចំនួនទឹកប្រាក់ដក: $" + txtAmount.Text, fBold, Brushes.Black, 50, y);
            y += 40;
            g.DrawString("-----------------------------------------------------", fBody, Brushes.Black, 50, y);
            y += 30;
            g.DrawString("សូមអរគុណដែលបានប្រើប្រាស់សេវាកម្មរបស់យើង!", fItalic, Brushes.Black, 80, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmCustomerDashboard dashboard = new frmCustomerDashboard(_user);
            Navigation.SwitchForm(this, dashboard);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            frmWithdraw f = new frmWithdraw(_user);
            Navigation.SwitchForm(this, f);
        }
    }
}