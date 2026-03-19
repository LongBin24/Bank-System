namespace BankSystem.UI
{
    partial class frmAddCustomer
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
            label1 = new Label();
            txtName = new TextBox();
            txtPIN = new TextBox();
            PIN = new Label();
            txtPhone = new TextBox();
            Phone = new Label();
            txtDeposit = new TextBox();
            label4 = new Label();
            btnSave = new Button();
            cbCurrency = new ComboBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 139);
            label1.Name = "label1";
            label1.Size = new Size(91, 38);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(311, 136);
            txtName.Name = "txtName";
            txtName.Size = new Size(297, 43);
            txtName.TabIndex = 1;
            // 
            // txtPIN
            // 
            txtPIN.Location = new Point(311, 202);
            txtPIN.Name = "txtPIN";
            txtPIN.Size = new Size(297, 43);
            txtPIN.TabIndex = 3;
            // 
            // PIN
            // 
            PIN.AutoSize = true;
            PIN.Location = new Point(176, 205);
            PIN.Name = "PIN";
            PIN.Size = new Size(61, 38);
            PIN.TabIndex = 2;
            PIN.Text = "PIN";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(311, 264);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(297, 43);
            txtPhone.TabIndex = 5;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Location = new Point(176, 267);
            Phone.Name = "Phone";
            Phone.Size = new Size(96, 38);
            Phone.TabIndex = 4;
            Phone.Text = "Phone";
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(311, 325);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(297, 43);
            txtDeposit.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(176, 328);
            label4.Name = "label4";
            label4.Size = new Size(112, 38);
            label4.TabIndex = 6;
            label4.Text = "Deposit";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(654, 459);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 48);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbCurrency
            // 
            cbCurrency.FormattingEnabled = true;
            cbCurrency.Items.AddRange(new object[] { "USD", "KHR" });
            cbCurrency.Location = new Point(176, 380);
            cbCurrency.Name = "cbCurrency";
            cbCurrency.Size = new Size(433, 45);
            cbCurrency.TabIndex = 9;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(26, 36);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(92, 47);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmAddCustomer
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 722);
            Controls.Add(btnBack);
            Controls.Add(cbCurrency);
            Controls.Add(btnSave);
            Controls.Add(txtDeposit);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(Phone);
            Controls.Add(txtPIN);
            Controls.Add(PIN);
            Controls.Add(txtName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "frmAddCustomer";
            Text = "frmAddCustomer";
            Load += frmAddCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtPIN;
        private Label PIN;
        private TextBox txtPhone;
        private Label Phone;
        private TextBox txtDeposit;
        private Label label4;
        private Button btnSave;
        private ComboBox cbCurrency;
        private Button btnBack;
    }
}