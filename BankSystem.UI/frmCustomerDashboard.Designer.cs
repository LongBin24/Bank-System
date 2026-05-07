namespace BankSystem.UI
{
    partial class frmCustomerDashboard
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
            lblWelcome = new Label();
            lblAccountID = new Label();
            lblBalance = new Label();
            btnWithdraw = new Button();
            btnDeposit = new Button();
            btnTransfer = new Button();
            btnExchange = new Button();
            btnHistory = new Button();
            btnLogout = new Button();
            lblCustomerName = new Label();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Khmer OS Battambang", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.DarkBlue;
            lblWelcome.Location = new Point(323, 9);
            lblWelcome.Margin = new Padding(6, 0, 6, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(97, 36);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // lblAccountID
            // 
            lblAccountID.AutoSize = true;
            lblAccountID.BackColor = Color.WhiteSmoke;
            lblAccountID.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountID.ForeColor = Color.DarkBlue;
            lblAccountID.Location = new Point(29, 167);
            lblAccountID.Name = "lblAccountID";
            lblAccountID.Size = new Size(96, 20);
            lblAccountID.TabIndex = 1;
            lblAccountID.Text = "AccountID";
            lblAccountID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.BackColor = Color.WhiteSmoke;
            lblBalance.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = Color.DarkBlue;
            lblBalance.Location = new Point(29, 61);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(172, 46);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "Balance";
            lblBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWithdraw.Location = new Point(114, 334);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(144, 49);
            btnWithdraw.TabIndex = 3;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click_1;
            // 
            // btnDeposit
            // 
            btnDeposit.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeposit.Location = new Point(276, 333);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(144, 49);
            btnDeposit.TabIndex = 4;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransfer.Location = new Point(436, 331);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(144, 51);
            btnTransfer.TabIndex = 5;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click_1;
            // 
            // btnExchange
            // 
            btnExchange.BackColor = Color.Orange;
            btnExchange.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExchange.ForeColor = SystemColors.ControlLightLight;
            btnExchange.Location = new Point(600, 240);
            btnExchange.Name = "btnExchange";
            btnExchange.Size = new Size(150, 54);
            btnExchange.TabIndex = 6;
            btnExchange.Text = "Exchange";
            btnExchange.UseVisualStyleBackColor = false;
            btnExchange.Click += btnExchange_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.DodgerBlue;
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = SystemColors.Window;
            btnHistory.Location = new Point(600, 167);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(150, 54);
            btnHistory.TabIndex = 7;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(637, 390);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(133, 51);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Khmer OS Battambang", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(522, 61);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(139, 72);
            lblCustomerName.TabIndex = 9;
            lblCustomerName.Text = "Name";
            // 
            // frmCustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(lblCustomerName);
            Controls.Add(btnLogout);
            Controls.Add(btnHistory);
            Controls.Add(btnExchange);
            Controls.Add(btnTransfer);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdraw);
            Controls.Add(lblBalance);
            Controls.Add(lblAccountID);
            Controls.Add(lblWelcome);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
            Name = "frmCustomerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCustomerDashboard";
            Load += frmCustomerDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblAccountID;
        private Label lblBalance;
        private Button btnWithdraw;
        private Button btnDeposit;
        private Button btnTransfer;
        private Button btnExchange;
        private Button btnHistory;
        private Button btnLogout;
        private Label lblCustomerName;
    }
}