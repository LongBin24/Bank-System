using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffManagement
{
    public partial class Form1 : Form
    {
        private StaffStore store = new StaffStore();
        private int currentIndex = -1; 

        public Form1()
        {
            InitializeComponent();
        }

        public class Staff
        {
            public string StaffID { get; set; }
            public string StaffName { get; set; }
            public string Gender { get; set; }
            public string Position { get; set; }
            public double Salary { get; set; }

            public Staff(string id, string name, string gender, string position, double salary)
            {
                StaffID = id;
                StaffName = name;
                Gender = gender;
                Position = position;
                Salary = salary;
            }

            public override string ToString()
            {
                return $"{StaffID} | {StaffName} | {Gender} | {Position} | {Salary}";
            }
        }

        public class StaffStore
        {
            public List<Staff> StaffList = new List<Staff>();

            public void Add(Staff s)
            {
                StaffList.Add(s);
            }

            public void Delete(string id)
            {
                Staff staff = StaffList.Find(s => s.StaffID == id);
                if (staff != null)
                    StaffList.Remove(staff);
            }

            public void Update(Staff updated)
            {
                Staff s = StaffList.Find(x => x.StaffID == updated.StaffID);
                if (s != null)
                {
                    s.StaffName = updated.StaffName;
                    s.Gender = updated.Gender;
                    s.Position = updated.Position;
                    s.Salary = updated.Salary;
                }
            }
        }
        private Staff GetStaff()
        {
            return new Staff(
                txtID.Text,
                txtName.Text,
                txtGender.Text,
                txtPosition.Text,
                double.Parse(txtSalary.Text)
            );
        }

        private void DisplayList()
        {
            if (currentIndex >= 0 && currentIndex < store.StaffList.Count)
            {
                var staff = store.StaffList[currentIndex];
                txtID.Text = staff.StaffID;
                txtName.Text = staff.StaffName;
                txtGender.Text = staff.Gender;
                txtPosition.Text = staff.Position;
                txtSalary.Text = staff.Salary.ToString();
            }
            else
            {
                txtID.Clear();
                txtName.Clear();
                txtGender.Clear();
                txtPosition.Clear();
                txtSalary.Clear();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            store.Add(GetStaff());
            currentIndex = store.StaffList.Count - 1; 
            DisplayList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            store.Delete(txtID.Text);
            currentIndex = store.StaffList.Count - 1;
            DisplayList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            store.Update(GetStaff());
            DisplayList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtGender.Clear();
            txtPosition.Clear();
            txtSalary.Clear();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm(store.StaffList); 
            report.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
   
        }
    }
}
