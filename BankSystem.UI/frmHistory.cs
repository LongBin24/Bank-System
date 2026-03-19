using BankSystem.BLL;
using BankSystem.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankSystem.UI
{
    public partial class frmHistory : Form
    {
        private User _user;

        public frmHistory(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (_user == null) return;

            BankService service = new BankService();
            var history = service.GetTransactionHistory(_user.UserID);

            dgvHistory.DataSource = history;

            if (dgvHistory.Columns["ID"] != null) dgvHistory.Columns["ID"].HeaderText = "លេខប្រតិបត្តិការ";
            if (dgvHistory.Columns["Type"] != null) dgvHistory.Columns["Type"].HeaderText = "ប្រភេទ";
            if (dgvHistory.Columns["Amount"] != null) dgvHistory.Columns["Amount"].HeaderText = "ចំនួនទឹកប្រាក់";
            if (dgvHistory.Columns["Date"] != null) dgvHistory.Columns["Date"].HeaderText = "កាលបរិច្ឆេទ";
            if (dgvHistory.Columns["Date"] != null) dgvHistory.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string type = dgvHistory.Rows[e.RowIndex].Cells["Type"].Value.ToString();
                MessageBox.Show("ប្រតិបត្តិការប្រភេទ: " + type);
            }
        }
        private void dgvHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvHistory.Columns[e.ColumnIndex].Name == "Type")
            {
                if (e.Value != null)
                {
                    string type = e.Value.ToString();
                    if (type == "Withdraw") e.CellStyle.ForeColor = Color.Red;
                    else if (type == "Transfer") e.CellStyle.ForeColor = Color.Blue;
                    else if (type == "Deposit") e.CellStyle.ForeColor = Color.Green;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCustomerDashboard dashboard = new frmCustomerDashboard(_user);
            Navigation.SwitchForm(this, dashboard); 
            this.Close();
        }
    }
}