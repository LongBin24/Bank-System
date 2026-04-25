using BankSystem.BLL;
using BankSystem.Models;

namespace BankSystem.UI
{
    public partial class frmEditCustomer : Form
    {
        public frmEditCustomer()
        {
            InitializeComponent();
        }

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {

        }
        private User _customerToEdit;
        private User _staff;
        private StaffService _staffService = new StaffService();


        public frmEditCustomer(User customer, User staff)
        {
            InitializeComponent();
            _customerToEdit = customer;
            _staff = staff;


            lblID.Text = "ID: " + _customerToEdit.UserID;
            txtName.Text = _customerToEdit.FullName;
            txtPhone.Text = _customerToEdit.Phone;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _customerToEdit.FullName = txtName.Text;
            _customerToEdit.Phone = txtPhone.Text;

            if (_staffService.UpdateCustomer(_customerToEdit))
            {
                MessageBox.Show("កែប្រែព័ត៌មានជោគជ័យ!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //frmCustomerList customerListForm = new frmCustomerList(_staff);
            //Navigation.SwitchForm(this, customerListForm);
            Close();
        }
    }
}
