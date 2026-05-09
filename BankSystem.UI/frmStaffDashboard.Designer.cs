namespace BankSystem.UI
{
    partial class frmStaffDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddCustomer = new Button();
            btnViewList = new Button();
            btnLogout = new Button();
            lblWelcome = new Label();
            staffListBtn = new Button();
            btnAddStaff = new Button();
            SuspendLayout();
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = SystemColors.MenuHighlight;
            btnAddCustomer.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCustomer.ForeColor = SystemColors.ButtonHighlight;
            btnAddCustomer.Location = new Point(59, 294);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(201, 55);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "AddCustomer";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnViewList
            // 
            btnViewList.BackColor = Color.Gold;
            btnViewList.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewList.ForeColor = SystemColors.ButtonHighlight;
            btnViewList.Location = new Point(281, 294);
            btnViewList.Name = "btnViewList";
            btnViewList.Size = new Size(201, 55);
            btnViewList.TabIndex = 1;
            btnViewList.Text = "ViewList";
            btnViewList.UseVisualStyleBackColor = false;
            btnViewList.Click += btnViewList_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(506, 294);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(201, 55);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.HotTrack;
            lblWelcome.Location = new Point(305, 98);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(197, 54);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Welcome";
            // 
            // staffListBtn
            // 
            staffListBtn.BackColor = Color.Gold;
            staffListBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            staffListBtn.ForeColor = SystemColors.ButtonHighlight;
            staffListBtn.Location = new Point(281, 365);
            staffListBtn.Name = "staffListBtn";
            staffListBtn.Size = new Size(201, 55);
            staffListBtn.TabIndex = 4;
            staffListBtn.Text = "ViewStaffList";
            staffListBtn.UseVisualStyleBackColor = false;
            staffListBtn.Click += staffListBtn_Click;
            // 
            // btnAddStaff
            // 
            btnAddStaff.BackColor = SystemColors.MenuHighlight;
            btnAddStaff.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStaff.ForeColor = SystemColors.ButtonHighlight;
            btnAddStaff.Location = new Point(59, 365);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new Size(201, 55);
            btnAddStaff.TabIndex = 5;
            btnAddStaff.Text = "AddStaff";
            btnAddStaff.UseVisualStyleBackColor = false;
            btnAddStaff.Click += btnAddStaff_Click;
            // 
            // frmStaffDashboard
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 724);
            Controls.Add(btnAddStaff);
            Controls.Add(staffListBtn);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogout);
            Controls.Add(btnViewList);
            Controls.Add(btnAddCustomer);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "frmStaffDashboard";
            Text = "frmStaffDashboard";
            Load += frmStaffDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddCustomer;
        private Button btnViewList;
        private Button btnLogout;
        private Label lblWelcome;
        private Button staffListBtn;
        private Button button1;
        private Button btnAddStaff;
    }
}