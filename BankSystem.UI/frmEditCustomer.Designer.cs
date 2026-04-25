namespace BankSystem.UI
{
    partial class frmEditCustomer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtName = new TextBox();
            lblID = new Label();
            lblNameTitle = new Label();
            label1 = new Label();
            txtPhone = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(241, 139);
            txtName.Name = "txtName";
            txtName.Size = new Size(427, 43);
            txtName.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(419, 35);
            lblID.Name = "lblID";
            lblID.Size = new Size(44, 38);
            lblID.TabIndex = 1;
            lblID.Text = "ID";
            // 
            // lblNameTitle
            // 
            lblNameTitle.AutoSize = true;
            lblNameTitle.Location = new Point(99, 142);
            lblNameTitle.Name = "lblNameTitle";
            lblNameTitle.Size = new Size(91, 38);
            lblNameTitle.TabIndex = 2;
            lblNameTitle.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 225);
            label1.Name = "label1";
            label1.Size = new Size(96, 38);
            label1.TabIndex = 4;
            label1.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(241, 222);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(427, 43);
            txtPhone.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(241, 430);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(138, 49);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(530, 440);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 49);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(138, 49);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmEditCustomer
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 639);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(lblNameTitle);
            Controls.Add(lblID);
            Controls.Add(txtName);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "frmEditCustomer";
            Text = "frmEditCustomer";
            Load += frmEditCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblID;
        private Label lblNameTitle; 
        private Label label1;
        private TextBox txtPhone;
        private Button btnCancel;
        private Button btnSave;
        private Button btnBack;
    }
}