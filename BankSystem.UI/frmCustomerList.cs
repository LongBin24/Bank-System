using System;
using System.Data;
using System.Windows.Forms;
using BankSystem.BLL;
using BankSystem.Models;

namespace BankSystem.UI
{
    public partial class frmCustomerList : Form
    {
        private StaffService _staffService = new StaffService();
        private BankSystem.Models.User _currentUser;
        public frmCustomerList(BankSystem.Models.User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            try
            {
                DataTable dt = _staffService.GetCustomerList();

                if (dt != null)
                {
                    dgvCustomers.DataSource = dt;
                    FormatGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("មិនអាចទាញយកទិន្នន័យបានទេ៖ " + ex.Message);
            }
        }

        private void FormatGrid()
        {

            if (dgvCustomers.Columns.Count > 0)
            {
                if (dgvCustomers.Columns.Contains("UserID")) dgvCustomers.Columns["UserID"].HeaderText = "លេខសម្គាល់";
                if (dgvCustomers.Columns.Contains("FullName")) dgvCustomers.Columns["FullName"].HeaderText = "ឈ្មោះអតិថិជន";
                if (dgvCustomers.Columns.Contains("Phone")) dgvCustomers.Columns["Phone"].HeaderText = "លេខទូរស័ព្ទ";
                if (dgvCustomers.Columns.Contains("Balance"))
                {
                    dgvCustomers.Columns["Balance"].HeaderText = "សមតុល្យ";
                    dgvCustomers.Columns["Balance"].DefaultCellStyle.Format = "N2";
                    dgvCustomers.Columns["Balance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvCustomers.Columns.Contains("Currency")) dgvCustomers.Columns["Currency"].HeaderText = "ប្រភេទលុយ";
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

                string name = row.Cells["FullName"].Value?.ToString() ?? "N/A";
                string balance = row.Cells["Balance"].Value?.ToString() ?? "0";
                string currency = row.Cells["Currency"].Value?.ToString() ?? "";

                MessageBox.Show("អ្នកបានជ្រើសរើសអតិថិជន៖ " + name + "\nសមតុល្យ៖ " + balance + " " + currency);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (dgvCustomers.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;

                dv.RowFilter = string.Format("FullName LIKE '%{0}%'", txtSearch.Text.Replace("'", "''"));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmStaffDashboard dashboard = new frmStaffDashboard(_currentUser);
            Navigation.SwitchForm(this, dashboard);
        }
        //Button Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                int id = (int)dgvCustomers.CurrentRow.Cells["UserID"].Value;
                if (MessageBox.Show("តើអ្នកពិតជាចង់លុបអតិថិជននេះមែនទេ?", "បញ្ជាក់", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (_staffService.DeleteCustomer(id))
                    {
                        MessageBox.Show("បានលុបជោគជ័យ!");
                        LoadCustomerData();
                    }
                    else
                    {
                        MessageBox.Show("មានបញ្ហាក្នុងការលុបអតិថិជន!");
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCustomer addfrm = new frmAddCustomer(_currentUser);
            Navigation.SwitchForm(this, addfrm);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                User userToUpdate = new User
                {
                    UserID = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["UserID"].Value),
                    FullName = dgvCustomers.CurrentRow.Cells["FullName"].Value.ToString(),
                    Phone = dgvCustomers.CurrentRow.Cells["Phone"].Value.ToString()
                };
                if (_staffService.UpdateCustomer(userToUpdate))
                {
                    MessageBox.Show("បានUpdateជោគជ័យ!");
                    LoadCustomerData();
                }
                else
                {
                    MessageBox.Show("មានបញ្ហាក្នុងការUpdateអតិថិជន!");
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fTitle = new Font("Khmer OS Muol Light", 14, FontStyle.Bold);
            Font fHeader = new Font("Khmer OS Battambang", 10, FontStyle.Bold);
            Font fBody = new Font("Khmer OS Battambang", 10);

            float y = 50;
            g.DrawString("របាយការណ៍បញ្ជីអតិថិជនទាំងអស់", fTitle, Brushes.Black, 200, y);
            y += 60;

            g.DrawString("ID", fHeader, Brushes.Black, 50, y);
            g.DrawString("ឈ្មោះអតិថិជន", fHeader, Brushes.Black, 100, y);
            g.DrawString("លេខទូរស័ព្ទ", fHeader, Brushes.Black, 350, y);
            g.DrawString("សមតុល្យ", fHeader, Brushes.Black, 550, y);
            y += 30;
            g.DrawLine(Pens.Black, 50, y, 750, y);
            y += 10;

            foreach (DataGridViewRow row in dgvCustomers.Rows)
            {
                g.DrawString(row.Cells["UserID"].Value.ToString(), fBody, Brushes.Black, 50, y);
                g.DrawString(row.Cells["FullName"].Value.ToString(), fBody, Brushes.Black, 100, y);
                g.DrawString(row.Cells["Phone"].Value.ToString(), fBody, Brushes.Black, 350, y);
                g.DrawString(row.Cells["Balance"].Value.ToString(), fBody, Brushes.Black, 550, y);
                y += 25;
            }
        }
    }
}