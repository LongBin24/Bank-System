namespace BankSystem.UI
{
    partial class frmEditStaff
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
            lblTitle = new Label();
            txtName = new TextBox();
            lblID = new Label();
            label1 = new Label();
            label2 = new Label();
            txtPhone = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(654, 48);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(294, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "កែប្រែព័ត៌មានបុគ្គលិក";
            // 
            // txtName
            // 
            txtName.Location = new Point(591, 293);
            txtName.Name = "txtName";
            txtName.Size = new Size(479, 43);
            txtName.TabIndex = 1;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(439, 196);
            lblID.Name = "lblID";
            lblID.Size = new Size(52, 38);
            lblID.TabIndex = 2;
            lblID.Text = "ID ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(421, 293);
            label1.Name = "label1";
            label1.Size = new Size(139, 38);
            label1.TabIndex = 3;
            label1.Text = "ឈ្មោះពេញ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(404, 375);
            label2.Name = "label2";
            label2.Size = new Size(156, 38);
            label2.TabIndex = 5;
            label2.Text = "លេខទូរស័ព្ទ";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(591, 370);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(479, 43);
            txtPhone.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(863, 482);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(207, 50);
            btnSave.TabIndex = 6;
            btnSave.Text = "រក្សាទុក";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(591, 482);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(207, 50);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "បោះបង់";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmEditStaff
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(txtPhone);
            Controls.Add(label1);
            Controls.Add(lblID);
            Controls.Add(txtName);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "frmEditStaff";
            Text = "frmEditStaff";
            Load += frmEditStaff_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtName;
        private Label lblID;
        private Label label1;
        private Label label2;
        private TextBox txtPhone;
        private Button btnSave;
        private Button btnCancel;
    }
}