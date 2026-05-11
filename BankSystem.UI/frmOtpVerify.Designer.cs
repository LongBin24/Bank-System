namespace BankSystem.UI
{
    partial class frmOtpVerify
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
            txtInputOtp = new TextBox();
            label1 = new Label();
            btnVerify = new Button();
            SuspendLayout();
            // 
            // txtInputOtp
            // 
            txtInputOtp.Location = new Point(629, 173);
            txtInputOtp.Name = "txtInputOtp";
            txtInputOtp.Size = new Size(382, 43);
            txtInputOtp.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 176);
            label1.Name = "label1";
            label1.Size = new Size(347, 38);
            label1.TabIndex = 1;
            label1.Text = "បញ្ចូលលេខCode OTP 6ខ្ទង់";
            // 
            // btnVerify
            // 
            btnVerify.Location = new Point(815, 316);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(180, 49);
            btnVerify.TabIndex = 2;
            btnVerify.Text = "ផ្ទៀងផ្ទាត់";
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += btnVerify_Click;
            // 
            // frmOtpVerify
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(btnVerify);
            Controls.Add(label1);
            Controls.Add(txtInputOtp);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "frmOtpVerify";
            Text = "frmOtpVerify";
            Load += frmOtpVerify_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInputOtp;
        private Label label1;
        private Button btnVerify;
    }
}