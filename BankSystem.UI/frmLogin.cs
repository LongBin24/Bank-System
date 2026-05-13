using BankSystem.BLL;
using BankSystem.Models;
using Telegram.Bot;
using System.Linq;
using System.Threading.Tasks;


namespace BankSystem.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            AuthService auth = new AuthService();
            BankSystem.Models.User user = auth.Authenticate(txtUserID.Text, txtPIN.Text);

            if (user != null)
            {

                string otpCode = new Random().Next(100000, 999999).ToString();

                TelegramService telegram = new TelegramService();
                await telegram.SendOtpAsync(user.TelegramChatID, otpCode);

                frmOtpVerify otpForm = new frmOtpVerify(user, otpCode);
                Navigation.SwitchForm(this, otpForm);
            }
            else
            {
                MessageBox.Show("លេខសម្គាល់ ឬលេខសម្ងាត់មិនត្រឹមត្រូវ!");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            Navigation.SwitchForm(this, registerForm);
        }
    }
}
