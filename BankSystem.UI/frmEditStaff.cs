using BankSystem.BLL;
using BankSystem.Models;
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
    public partial class frmEditStaff : Form
    {
        private User _staffToEdit;
        private User _admin;
        private StaffService _staffService = new StaffService();
        public frmEditStaff(User staffToEdit, User admin)
        {
            InitializeComponent();
            _staffToEdit = staffToEdit;
            _admin = admin;

            lblID.Text = "លេខសម្គាល់បុគ្គលិក: " + _staffToEdit.UserID;
            txtName.Text = _staffToEdit.FullName;
            txtPhone.Text = _staffToEdit.Phone;
        }

        private void frmEditStaff_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _staffToEdit.FullName = txtName.Text;
            _staffToEdit.Phone = txtPhone.Text;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("សូមបញ្ចូលឈ្មោះបុគ្គលិក!");
                return;
            }

            if (_staffService.UpdateStaffInfo(_staffToEdit))
            {
                MessageBox.Show("កែប្រែព័ត៌មានបុគ្គលិកជោគជ័យ!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("ការកែប្រែបរាជ័យ!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
