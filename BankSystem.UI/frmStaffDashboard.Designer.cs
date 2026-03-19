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
            SuspendLayout();
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(66, 305);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(201, 51);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "AddCustomer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnViewList
            // 
            btnViewList.Location = new Point(305, 305);
            btnViewList.Name = "btnViewList";
            btnViewList.Size = new Size(201, 51);
            btnViewList.TabIndex = 1;
            btnViewList.Text = "ViewList";
            btnViewList.UseVisualStyleBackColor = true;
            btnViewList.Click += btnViewList_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(541, 305);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(201, 51);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(305, 98);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(132, 38);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Welcome";
            // 
            // frmStaffDashboard
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 724);
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
    }
}