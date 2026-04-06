using StaffManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static StaffManagement.Form1;


namespace StaffManagement
{
    public partial class ReportForm : Form
    {
        private List<Form1.Staff> staffList;

        public ReportForm(List<Form1.Staff> staffList)
        {
            InitializeComponent();
            this.staffList = staffList;
        }

        private void ReportForm_Load_1(object sender, EventArgs e)
        {
            listBoxReport.Items.Clear();

            if (staffList != null && staffList.Count > 0)
            {
                foreach (var staff in staffList)
                {
                    listBoxReport.Items.Add(staff.ToString());
                }

                int totalStaff = staffList.Count;
                double totalSalary = staffList.Sum(s => s.Salary);
                double averageSalary = staffList.Average(s => s.Salary);
                lblTotalStaff.Text = $"Total Staff: {totalStaff}";
                lblTotalSalary.Text = $"Total Salary: {totalSalary}";
                lblAverageSalary.Text = $"Average Salary: {averageSalary:F2}";
            }
            else
            {
                lblTotalStaff.Text = "Total Staff: 0";
                lblTotalSalary.Text = "Total Salary: 0";
                lblAverageSalary.Text = "Average Salary: 0";
            }
        }
    }
}
