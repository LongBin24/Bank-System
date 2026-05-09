namespace BankSystem.UI
{
    partial class frmAddStaff
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
            label2 = new Label();
            btnBack = new Button();
            btnSave = new Button();
            txtPhone = new TextBox();
            Phone = new Label();
            txtPIN = new TextBox();
            PIN = new Label();
            txtName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(298, 52);
            label2.Name = "label2";
            label2.Size = new Size(249, 46);
            label2.TabIndex = 23;
            label2.Text = "Add Customer";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonFace;
            btnBack.Location = new Point(204, 326);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(194, 47);
            btnBack.TabIndex = 22;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(422, 325);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(194, 48);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(298, 257);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(322, 43);
            txtPhone.TabIndex = 17;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            Phone.Location = new Point(188, 265);
            Phone.Name = "Phone";
            Phone.Size = new Size(83, 32);
            Phone.TabIndex = 16;
            Phone.Text = "Phone";
            // 
            // txtPIN
            // 
            txtPIN.Location = new Point(298, 195);
            txtPIN.Name = "txtPIN";
            txtPIN.Size = new Size(322, 43);
            txtPIN.TabIndex = 15;
            // 
            // PIN
            // 
            PIN.AutoSize = true;
            PIN.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            PIN.Location = new Point(188, 203);
            PIN.Name = "PIN";
            PIN.Size = new Size(53, 32);
            PIN.TabIndex = 14;
            PIN.Text = "PIN";
            // 
            // txtName
            // 
            txtName.Location = new Point(298, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(322, 43);
            txtName.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.Location = new Point(188, 137);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // frmAddStaff
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 722);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(txtPhone);
            Controls.Add(Phone);
            Controls.Add(txtPIN);
            Controls.Add(PIN);
            Controls.Add(txtName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "frmAddStaff";
            Text = "frmAddStaff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnBack;
        private Button btnSave;
        private TextBox txtPhone;
        private Label Phone;
        private TextBox txtPIN;
        private Label PIN;
        private TextBox txtName;
        private Label label1;
    }
}