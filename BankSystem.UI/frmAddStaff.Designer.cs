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
            txtConfirmPIN = new TextBox();
            label3 = new Label();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(298, 52);
            label2.Name = "label2";
            label2.Size = new Size(232, 46);
            label2.TabIndex = 23;
            label2.Text = "បន្ថែមបុគ្គលិក";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonFace;
            btnBack.Location = new Point(93, 448);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(194, 47);
            btnBack.TabIndex = 22;
            btnBack.Text = "ត្រឡប់ក្រោយ";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(573, 448);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(194, 48);
            btnSave.TabIndex = 20;
            btnSave.Text = "រក្សាទុក";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(335, 199);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(322, 43);
            txtPhone.TabIndex = 17;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            Phone.Location = new Point(163, 207);
            Phone.Name = "Phone";
            Phone.Size = new Size(135, 32);
            Phone.TabIndex = 16;
            Phone.Text = "លេខទូរស័ព្ទ";
            // 
            // txtPIN
            // 
            txtPIN.Location = new Point(335, 265);
            txtPIN.Name = "txtPIN";
            txtPIN.Size = new Size(322, 43);
            txtPIN.TabIndex = 15;
            // 
            // PIN
            // 
            PIN.AutoSize = true;
            PIN.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            PIN.Location = new Point(163, 273);
            PIN.Name = "PIN";
            PIN.Size = new Size(136, 32);
            PIN.TabIndex = 14;
            PIN.Text = "លេខសម្ងាត់";
            // 
            // txtName
            // 
            txtName.Location = new Point(335, 137);
            txtName.Name = "txtName";
            txtName.Size = new Size(322, 43);
            txtName.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.Location = new Point(163, 137);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 12;
            label1.Text = "ឈ្មោះពេញ";
            // 
            // txtConfirmPIN
            // 
            txtConfirmPIN.Location = new Point(335, 327);
            txtConfirmPIN.Name = "txtConfirmPIN";
            txtConfirmPIN.Size = new Size(322, 43);
            txtConfirmPIN.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.Location = new Point(93, 335);
            label3.Name = "label3";
            label3.Size = new Size(206, 32);
            label3.TabIndex = 24;
            label3.Text = "បញ្ជាក់លេខសម្ងាត់";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 192, 0);
            btnCancel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonFace;
            btnCancel.Location = new Point(336, 449);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(194, 47);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "បោះបង់";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmAddStaff
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 722);
            Controls.Add(btnCancel);
            Controls.Add(txtConfirmPIN);
            Controls.Add(label3);
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
            Margin = new Padding(6);
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
        private TextBox txtConfirmPIN;
        private Label label3;
        private Button btnCancel;
    }
}