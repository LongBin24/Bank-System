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

        /// <summary>
        /// Validates all input fields before processing
        /// </summary>
        private bool ValidateInput()
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Staff ID is required and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Staff Name is required and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGender.Text))
            {
                MessageBox.Show("Gender is required and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGender.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                MessageBox.Show("Position is required and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPosition.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                MessageBox.Show("Salary is required and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalary.Focus();
                return false;
            }

            // Validate Salary is numeric and positive
            if (!double.TryParse(txtSalary.Text, out double salary))
            {
                MessageBox.Show("Salary must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalary.Focus();
                return false;
            }

            if (salary < 0)
            {
                MessageBox.Show("Salary cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalary.Focus();
                return false;
            }

            // Validate Staff ID length and format
            if (txtID.Text.Length > 20)
            {
                MessageBox.Show("Staff ID cannot exceed 20 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
                return false;
            }

            // Validate Name length
            if (txtName.Text.Length > 50)
            {
                MessageBox.Show("Staff Name cannot exceed 50 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Retrieves staff information from form inputs with error handling
        /// </summary>
        private Staff GetStaff()
        {
            if (!ValidateInput())
                return null;

            try
            {
                return new Staff(
                    txtID.Text.Trim(),
                    txtName.Text.Trim(),
                    txtGender.Text.Trim(),
                    txtPosition.Text.Trim(),
                    double.Parse(txtSalary.Text)
                );
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid data format. Please check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
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
            try
            {
                Staff staff = GetStaff();
                if (staff == null)
                    return;

                // Check for duplicate Staff ID
                if (store.StaffList.Any(s => s.StaffID == staff.StaffID))
                {
                    MessageBox.Show($"A staff member with ID '{staff.StaffID}' already exists.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Focus();
                    return;
                }

                store.Add(staff);
                currentIndex = store.StaffList.Count - 1;
                DisplayList();
                MessageBox.Show("Staff member added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(null, null); // Clear form after successful add
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding staff member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Please enter a Staff ID to delete.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Focus();
                    return;
                }

                Staff staffToDelete = store.StaffList.FirstOrDefault(s => s.StaffID == txtID.Text);
                if (staffToDelete == null)
                {
                    MessageBox.Show($"Staff member with ID '{txtID.Text}' not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show($"Are you sure you want to delete staff member '{staffToDelete.StaffName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    store.Delete(txtID.Text);

                    // Properly adjust currentIndex after deletion
                    if (currentIndex >= store.StaffList.Count && store.StaffList.Count > 0)
                    {
                        currentIndex = store.StaffList.Count - 1;
                    }
                    else if (store.StaffList.Count == 0)
                    {
                        currentIndex = -1;
                    }

                    DisplayList();
                    MessageBox.Show("Staff member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting staff member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Please enter a Staff ID to update.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Focus();
                    return;
                }

                Staff existingStaff = store.StaffList.FirstOrDefault(s => s.StaffID == txtID.Text);
                if (existingStaff == null)
                {
                    MessageBox.Show($"Staff member with ID '{txtID.Text}' not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Staff staff = GetStaff();
                if (staff == null)
                    return;

                store.Update(staff);
                DisplayList();
                MessageBox.Show("Staff member updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating staff member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtGender.Clear();
            txtPosition.Clear();
            txtSalary.Clear();
            txtID.Focus();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                ReportForm report = new ReportForm(store.StaffList);
                report.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Event handler for label click - can be removed if not needed
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize form - can add default data or UI setup here if needed
            txtID.Focus();
        }
    }
}
