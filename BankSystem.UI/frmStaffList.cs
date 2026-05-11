using BankSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystem.Models;
namespace BankSystem.UI
{
    public partial class frmStaffList : Form
    {
        private User _currentUser;
        private StaffService _staffService = new StaffService();
        public frmStaffList()
        {
            InitializeComponent();
        }

        private void frmStaffList_Load(object sender, EventArgs e)
        {
            LoadStaffData();
        }
        private void LoadStaffData()
        {
            StaffService service = new StaffService();
            dgvStaff.DataSource = service.GetUserList(role: "Staff");


            dgvStaff.Columns["UserID"].HeaderText = "លេខសម្គាល់";
            dgvStaff.Columns["FullName"].HeaderText = "ឈ្មោះបុគ្គលិក";
            dgvStaff.Columns["Phone"].HeaderText = "លេខទូរស័ព្ទ";
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddStaff f = new frmAddStaff(_currentUser);
            Navigation.SwitchForm(this, f);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow != null)
            {
                User selectedStaff = new User
                {
                    UserID = Convert.ToInt32(dgvStaff.CurrentRow.Cells["UserID"].Value),
                    FullName = dgvStaff.CurrentRow.Cells["FullName"].Value.ToString(),
                    Phone = dgvStaff.CurrentRow.Cells["Phone"].Value.ToString()
                };

                frmEditStaff editForm = new frmEditStaff(selectedStaff, _currentUser);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadStaffData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvStaff.CurrentRow.Cells["UserID"].Value);
                string name = dgvStaff.CurrentRow.Cells["FullName"].Value.ToString();

                if (MessageBox.Show($"តើអ្នកពិតជាចង់លុបបុគ្គលិកឈ្មោះ {name} មែនទេ?", "បញ្ជាក់",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (_staffService.RemoveStaff(id))
                    {
                        MessageBox.Show("លុបបុគ្គលិកជោគជ័យ!");
                        LoadStaffData();
                    }
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
            Font fBody = new Font("Khmer OS Battambang", 10);
            float y = 50;

            g.DrawString("របាយការណ៍បញ្ជីបុគ្គលិកធនាគារ", fTitle, Brushes.Black, 200, y);
            y += 60;

            // គូរក្បាលតារាង
            g.DrawString("ID", fBody, Brushes.Black, 50, y);
            g.DrawString("ឈ្មោះពេញ", fBody, Brushes.Black, 150, y);
            g.DrawString("លេខទូរស័ព្ទ", fBody, Brushes.Black, 450, y);
            y += 30;
            g.DrawLine(Pens.Black, 50, y, 750, y);

            // ទាញពី Grid មក Print
            foreach (DataGridViewRow row in dgvStaff.Rows)
            {
                y += 25;
                g.DrawString(row.Cells["UserID"].Value.ToString(), fBody, Brushes.Black, 50, y);
                g.DrawString(row.Cells["FullName"].Value.ToString(), fBody, Brushes.Black, 150, y);
                g.DrawString(row.Cells["Phone"].Value.ToString(), fBody, Brushes.Black, 450, y);
            }
        }
     }
    }
