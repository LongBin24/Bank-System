using BankSystem.BLL;
using Telegram.Bot;
using Telegram.Bot.Types;
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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPIN.Text))
            {
                MessageBox.Show("សូមបំពេញព័ត៌មានឱ្យបានគ្រប់គ្រាន់!");
                return;
            }

            if (txtPIN.Text != txtConfirmPIN.Text)
            {
                MessageBox.Show("លេខសម្ងាត់មិនត្រូវគ្នាទេ!");
                return;
            }

            if (decimal.TryParse(txtDeposit.Text, out decimal initialAmount))
            {
                StaffService service = new StaffService();
                bool isSuccess = service.CreateNewCustomer(
                    txtName.Text,
                    txtPIN.Text,
                    txtPhone.Text,
                    initialAmount,
                    cbCurrency.Text
                );

                if (isSuccess)
                {
                    MessageBox.Show("ចុះឈ្មោះជោគជ័យ! សូមប្រើលេខ ID ដែលប្រព័ន្ធផ្ដល់ឱ្យដើម្បី Loginចូល");
                    frmLogin login = new frmLogin();
                    Navigation.SwitchForm(this, login);
                }
                else
                {
                    MessageBox.Show("ការចុះឈ្មោះមានបញ្ហា!");
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string botUsername = "mybank_otp_bot";
            string botUrl = "https://t.me/" + botUsername;
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = botUrl, UseShellExecute = true });

            MessageBox.Show("សូមចុចប៊ូតុង 'START' ក្នុង Telegram រួចត្រឡប់មកចុច OK នៅទីនេះ។");

            TelegramService telegram = new TelegramService();

            string chatId = await telegram.GetLatestChatIdAsync();

            if (chatId != null)
            {
                txtTelegramID.Text = chatId;
                MessageBox.Show("ភ្ជាប់ជោគជ័យ!");
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            Navigation.SwitchForm(this, login);
        }
    }
}
