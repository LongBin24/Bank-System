using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BankSystem.DAL;
using BankSystem.BLL;
using BankSystem.Models;

namespace BankSystem.UI
{
    public partial class frmExchange : Form
    {
        private BankSystem.Models.User _user;
        private decimal currentRate = 0;
        private AccountRepository dal = new AccountRepository();

        public frmExchange(BankSystem.Models.User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void frmExchange_Load(object sender, EventArgs e)
        {
            cbType.Items.Clear();
            cbType.Items.Add("USD to KHR");
            cbType.Items.Add("KHR to USD");
            cbType.SelectedIndex = 0;

            printPreviewDialog1.Document = printDocument1;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbType.Text == "USD to KHR")
                    currentRate = dal.GetExchangeRate("USD", "KHR");
                else
                    currentRate = dal.GetExchangeRate("KHR", "USD");

                if (decimal.TryParse(txtAmount.Text, out decimal amount))
                {
                    decimal result = amount * currentRate;
                    lblRate.Text = currentRate.ToString("N2");
                    lblResult.Text = result.ToString("N2") + (cbType.Text == "USD to KHR" ? " KHR" : " USD");
                }
                else
                {
                    MessageBox.Show("សូមបញ្ចូលចំនួនទឹកប្រាក់ជាលេខ!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("មានបញ្ហាបច្ចេកទេស៖ " + ex.Message);
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.Text == "USD to KHR")
                currentRate = dal.GetExchangeRate("USD", "KHR");
            else
                currentRate = dal.GetExchangeRate("KHR", "USD");

            lblRate.Text = "អត្រាបច្ចុប្បន្ន: 1 = " + currentRate.ToString("N2");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("តើអ្នកពិតជាចង់ប្តូរប្រាក់មែនឬទេ?", "បញ្ជាក់", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("ការប្តូរប្រាក់ជោគជ័យ! អ្នកអាចចុចប៊ូតុង Print ដើម្បីយកបង្កាន់ដៃ។");
                btnPrint_Click(null, null);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblResult.Text) || lblResult.Text == "0.00")
            {
                MessageBox.Show("សូមចុចប៊ូតុង Calculate ដើម្បីគណនាលុយជាមុនសិន!");
                return;
            }
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fTitle = new Font("Khmer OS Muol Light", 12, FontStyle.Bold);
            Font fBody = new Font("Khmer OS Battambang", 10, FontStyle.Regular);
            Font fBold = new Font("Khmer OS Battambang", 10, FontStyle.Bold);
            Font fItalic = new Font("Khmer OS Battambang", 10, FontStyle.Italic);

            float y = 50;

            g.DrawString("បង្កាន់ដៃប្តូរប្រាក់ (EXCHANGE RECEIPT)", fTitle, Brushes.Black, 80, y);
            y += 60;
            g.DrawString("---------------------------------------------------------", fBody, Brushes.Black, 50, y);
            y += 30;

            g.DrawString("កាលបរិច្ឆេទ: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fBody, Brushes.Black, 50, y);
            y += 30;
            g.DrawString("ឈ្មោះអតិថិជន: " + _user.FullName, fBody, Brushes.Black, 50, y);
            y += 30;
            g.DrawString("ប្រភេទដូរលុយ: " + cbType.Text, fBody, Brushes.Black, 50, y);
            y += 30;
            g.DrawString("អត្រាប្តូរប្រាក់: 1 = " + currentRate.ToString("N2"), fBody, Brushes.Black, 50, y);
            y += 40;

            g.DrawString("ចំនួនទឹកប្រាក់ប្តូរ: " + txtAmount.Text, fBold, Brushes.Black, 50, y);
            y += 30;
            g.DrawString("ទឹកប្រាក់ទទួលបាន: " + lblResult.Text, fBold, Brushes.Black, 50, y);
            y += 50;

            g.DrawString("---------------------------------------------------------", fBody, Brushes.Black, 50, y);
            y += 30;
            g.DrawString("សូមរក្សាទុកបង្កាន់ដៃនេះជាភស្តុតាង។ អរគុណ!", fItalic, Brushes.Black, 80, y);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCustomerDashboard dashboard = new frmCustomerDashboard(_user);
            Navigation.SwitchForm(this, dashboard);
        }
    }
}