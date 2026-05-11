using BankSystem.BLL;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using BankSystem.Models;

namespace BankSystem.UI
{
    public partial class frmTransfer : Form
    {
        private BankSystem.Models.User _sender;
        private TransferReceipt currentReceipt;
        private int currentRefNo = 0;

        public frmTransfer(BankSystem.Models.User user)
        {
            InitializeComponent();
            _sender = user;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amt) && int.TryParse(txtReceiverID.Text, out int rid))
            {
                BankService bank = new BankService();

                currentReceipt = bank.ProcessTransfer(_sender.UserID, rid, amt);

                if (currentReceipt != null)
                {
                    currentRefNo = currentReceipt.ReferenceNo;
                    MessageBox.Show("ផ្ទេរប្រាក់ជោគជ័យ!");

                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("ការផ្ទេរប្រាក់បរាជ័យ! សូមពិនិត្យលេខគណនីអ្នកទទួល ឬសមតុល្យលុយ។");
                }
            }
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            if (currentReceipt == null) return;

            Graphics g = e.Graphics;

            Font fTitle = new Font("Khmer OS Muol Light", 12, FontStyle.Bold);
            Font fBody = new Font("Khmer OS Battambang", 10);
            Font fBold = new Font("Khmer OS Battambang", 10, FontStyle.Bold);
            Font fItalic = new Font("Khmer OS Battambang", 10, FontStyle.Italic);

            float y = 50;

            g.DrawString("បង្កាន់ដៃផ្ទេរប្រាក់ (TRANSFER RECEIPT)", fTitle, Brushes.Black, 80, y);
            y += 50;
            g.DrawString("-----------------------------------------------------", fBody, Brushes.Black, 50, y);
            y += 30;

            g.DrawString("លេខប្រតិបត្តិការ (Ref No): " + currentReceipt.ReferenceNo.ToString("D8"), fBold, Brushes.Black, 50, y);
            y += 30;
            g.DrawString("កាលបរិច្ឆេទ: " + currentReceipt.Date.ToString("dd/MM/yyyy HH:mm"), fBody, Brushes.Black, 50, y);
            y += 40;

            g.DrawString("អ្នកផ្ញើ (From): " + currentReceipt.SenderName, fBody, Brushes.Black, 50, y);
            y += 30;
            g.DrawString("អ្នកទទួល (To): " + currentReceipt.ReceiverName, fBody, Brushes.Black, 50, y);
            y += 30;

            g.DrawString("ចំនួនទឹកប្រាក់: $" + currentReceipt.Amount.ToString("N2"), fBold, Brushes.Black, 50, y);
            y += 40;

            g.DrawString("-----------------------------------------------------", fBody, Brushes.Black, 50, y);
            y += 30;

            g.DrawString("សូមរក្សាទុកបង្កាន់ដៃនេះ ជាភស្តុតាង។ អរគុណ!", fItalic, Brushes.Black, 80, y);
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCustomerDashboard dashboard = new frmCustomerDashboard(_sender);
            Navigation.SwitchForm(this, dashboard);
            this.Hide();
        }
    }
}