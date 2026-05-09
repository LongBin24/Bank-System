namespace BankSystem.UI
{
    partial class frmCreateStuffAccount
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
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPIN;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBack;

        private void InitializeComponent()
        {
            lblName = new Label();
            txtName = new TextBox();
            lblPIN = new Label();
            txtPIN = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            btnCreate = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(61, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Full Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 23);
            txtName.TabIndex = 1;
            // 
            // lblPIN
            // 
            lblPIN.AutoSize = true;
            lblPIN.Location = new Point(30, 70);
            lblPIN.Name = "lblPIN";
            lblPIN.Size = new Size(26, 15);
            lblPIN.TabIndex = 2;
            lblPIN.Text = "PIN";
            // 
            // txtPIN
            // 
            txtPIN.Location = new Point(130, 67);
            txtPIN.Name = "txtPIN";
            txtPIN.Size = new Size(300, 23);
            txtPIN.TabIndex = 3;
            txtPIN.UseSystemPasswordChar = true;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(30, 110);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(130, 107);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(300, 23);
            txtPhone.TabIndex = 5;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(130, 150);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 30);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(250, 150);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 30);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmCreateStuffAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 220);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblPIN);
            Controls.Add(txtPIN);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(btnCreate);
            Controls.Add(btnBack);
            Name = "frmCreateStuffAccount";
            Text = "Create Staff Account";
            Load += frmCreateStuffAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}