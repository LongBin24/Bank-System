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
            label2 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(202, 236);
            txtName.Name = "txtName";
            txtName.Size = new Size(385, 43);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(202, 173);
            lblID.Name = "lblID";
            lblID.Size = new Size(47, 38);
            lblID.TabIndex = 1;
            lblID.Text = "ID";
            // 
            // lblNameTitle
            // 
            lblNameTitle.AutoSize = true;
            lblNameTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameTitle.Location = new Point(79, 241);
            lblNameTitle.Name = "lblNameTitle";
            lblNameTitle.Size = new Size(93, 38);
            lblNameTitle.TabIndex = 2;
            lblNameTitle.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 307);
            label1.Name = "label1";
            label1.Size = new Size(97, 38);
            label1.TabIndex = 4;
            label1.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(202, 302);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(385, 43);
            txtPhone.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(206, 397);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(138, 55);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LimeGreen;
            btnSave.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(378, 397);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 55);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(138, 49);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(215, 76);
            label2.Name = "label2";
            label2.Size = new Size(289, 54);
            label2.TabIndex = 8;
            label2.Text = "Edit Customer";
            // 
            // frmEditCustomer
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 639);
            Controls.Add(label2);
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
        private Label label2;
    }
}