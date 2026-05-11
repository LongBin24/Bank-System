namespace BankSystem.UI
{
    partial class frmRegister
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
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPIN = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtConfirmPIN = new TextBox();
            label5 = new Label();
            txtDeposit = new TextBox();
            cbCurrency = new ComboBox();
            label6 = new Label();
            button1 = new Button();
            btnLinkTelegram = new Button();
            txtTelegramID = new TextBox();
            btnback = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(551, 153);
            txtName.Name = "txtName";
            txtName.Size = new Size(489, 43);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 153);
            label1.Name = "label1";
            label1.Size = new Size(139, 38);
            label1.TabIndex = 1;
            label1.Text = "ឈ្មោះពេញ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 418);
            label2.Name = "label2";
            label2.Size = new Size(160, 38);
            label2.TabIndex = 3;
            label2.Text = "លេខសម្ងាត់";
            label2.Click += label2_Click;
            // 
            // txtPIN
            // 
            txtPIN.Location = new Point(551, 413);
            txtPIN.Name = "txtPIN";
            txtPIN.Size = new Size(489, 43);
            txtPIN.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 227);
            label3.Name = "label3";
            label3.Size = new Size(156, 38);
            label3.TabIndex = 5;
            label3.Text = "លេខទូរស័ព្ទ";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(551, 224);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(489, 43);
            txtPhone.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(255, 482);
            label4.Name = "label4";
            label4.Size = new Size(243, 38);
            label4.TabIndex = 7;
            label4.Text = "បញ្ជាក់លេខសម្ងាត់";
            label4.Click += label4_Click;
            // 
            // txtConfirmPIN
            // 
            txtConfirmPIN.Location = new Point(551, 477);
            txtConfirmPIN.Name = "txtConfirmPIN";
            txtConfirmPIN.Size = new Size(489, 43);
            txtConfirmPIN.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(299, 301);
            label5.Name = "label5";
            label5.Size = new Size(199, 38);
            label5.TabIndex = 8;
            label5.Text = "ប្រាក់កក់ដំបូង";
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(551, 298);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(489, 43);
            txtDeposit.TabIndex = 9;
            // 
            // cbCurrency
            // 
            cbCurrency.FormattingEnabled = true;
            cbCurrency.Items.AddRange(new object[] { "USD", "KHR" });
            cbCurrency.Location = new Point(551, 347);
            cbCurrency.Name = "cbCurrency";
            cbCurrency.Size = new Size(151, 45);
            cbCurrency.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 354);
            label6.Name = "label6";
            label6.Size = new Size(157, 38);
            label6.TabIndex = 11;
            label6.Text = "ប្រភេទលុយ";
            // 
            // button1
            // 
            button1.Location = new Point(1050, 700);
            button1.Name = "button1";
            button1.Size = new Size(204, 50);
            button1.TabIndex = 12;
            button1.Text = "បង្កើតគណនី";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnLinkTelegram
            // 
            btnLinkTelegram.Location = new Point(551, 539);
            btnLinkTelegram.Name = "btnLinkTelegram";
            btnLinkTelegram.Size = new Size(151, 51);
            btnLinkTelegram.TabIndex = 13;
            btnLinkTelegram.Text = "Telegram";
            btnLinkTelegram.UseVisualStyleBackColor = true;
            btnLinkTelegram.Click += button2_Click;
            // 
            // txtTelegramID
            // 
            txtTelegramID.Location = new Point(721, 543);
            txtTelegramID.Name = "txtTelegramID";
            txtTelegramID.Size = new Size(319, 43);
            txtTelegramID.TabIndex = 14;
            // 
            // btnback
            // 
            btnback.Location = new Point(99, 60);
            btnback.Name = "btnback";
            btnback.Size = new Size(185, 46);
            btnback.TabIndex = 15;
            btnback.Text = "ត្រឡប់ក្រោយ";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(btnback);
            Controls.Add(txtTelegramID);
            Controls.Add(btnLinkTelegram);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(cbCurrency);
            Controls.Add(txtDeposit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtConfirmPIN);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(txtPIN);
            Controls.Add(label1);
            Controls.Add(txtName);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "frmRegister";
            Text = "frmRegister";
            Load += frmRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtPIN;
        private Label label3;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtConfirmPIN;
        private Label label5;
        private TextBox txtDeposit;
        private ComboBox cbCurrency;
        private Label label6;
        private Button button1;
        private Button btnLinkTelegram;
        private TextBox txtTelegramID;
        private Button btnback;
    }
}