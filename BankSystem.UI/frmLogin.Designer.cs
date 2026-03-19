namespace BankSystem.UI
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            txtUserID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPIN = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(604, 458);
            btnLogin.Margin = new Padding(6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(176, 54);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(349, 168);
            txtUserID.Multiline = true;
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(263, 47);
            txtUserID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 171);
            label1.Name = "label1";
            label1.Size = new Size(100, 38);
            label1.TabIndex = 2;
            label1.Text = "UserID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 281);
            label2.Name = "label2";
            label2.Size = new Size(61, 38);
            label2.TabIndex = 4;
            label2.Text = "PIN";
            // 
            // txtPIN
            // 
            txtPIN.Location = new Point(349, 278);
            txtPIN.Multiline = true;
            txtPIN.Name = "txtPIN";
            txtPIN.Size = new Size(263, 47);
            txtPIN.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(402, 43);
            label3.Name = "label3";
            label3.Size = new Size(143, 62);
            label3.TabIndex = 5;
            label3.Text = "Login";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 638);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPIN);
            Controls.Add(label1);
            Controls.Add(txtUserID);
            Controls.Add(btnLogin);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "frmLogin";
            Text = "e";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUserID;
        private Label label1;
        private Label label2;
        private TextBox txtPIN;
        private Label label3;
    }
}
