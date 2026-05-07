namespace BankSystem.UI
{
    partial class frmDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeposit));
            lblTitle = new Label();
            lblCurrentBalance = new Label();
            label1 = new Label();
            txtAmount = new TextBox();
            btnConfirmDeposit = new Button();
            btnCancel = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Khmer OS Battambang", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.HotTrack;
            lblTitle.Location = new Point(260, 23);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(315, 62);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ដាក់ប្រាក់ចូលគណនី";
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Font = new Font("Khmer OS Battambang", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentBalance.Location = new Point(56, 115);
            lblCurrentBalance.Margin = new Padding(4, 0, 4, 0);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(236, 41);
            lblCurrentBalance.TabIndex = 1;
            lblCurrentBalance.Text = "សមតុល្យបច្ចុប្បន្ន: 0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Khmer OS Battambang", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 222);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 41);
            label1.TabIndex = 2;
            label1.Text = "បញ្ចូលចំនួនទឹកប្រាក់:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(338, 205);
            txtAmount.Margin = new Padding(4, 3, 4, 3);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(328, 58);
            txtAmount.TabIndex = 3;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // btnConfirmDeposit
            // 
            btnConfirmDeposit.BackColor = Color.LimeGreen;
            btnConfirmDeposit.Font = new Font("Khmer OS Battambang", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmDeposit.ForeColor = SystemColors.ControlLightLight;
            btnConfirmDeposit.Location = new Point(404, 326);
            btnConfirmDeposit.Margin = new Padding(4, 3, 4, 3);
            btnConfirmDeposit.Name = "btnConfirmDeposit";
            btnConfirmDeposit.Size = new Size(276, 58);
            btnConfirmDeposit.TabIndex = 4;
            btnConfirmDeposit.Text = "បញ្ជាក់ការដាក់ប្រាក់";
            btnConfirmDeposit.UseVisualStyleBackColor = false;
            btnConfirmDeposit.Click += btnConfirmDeposit_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Khmer OS Battambang", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ControlLightLight;
            btnCancel.Location = new Point(104, 326);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(276, 58);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "បោះបង់";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(12, 26);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 52);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += button1_Click;
            // 
            // frmDeposit
            // 
            AutoScaleDimensions = new SizeF(16F, 49F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(btnBack);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirmDeposit);
            Controls.Add(txtAmount);
            Controls.Add(label1);
            Controls.Add(lblCurrentBalance);
            Controls.Add(lblTitle);
            Font = new Font("Khmer OS Battambang", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6, 6, 6, 6);
            Name = "frmDeposit";
            Text = "frmDeposit";
            Load += frmDeposit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCurrentBalance;
        private Label label1;
        private TextBox txtAmount;
        private Button btnConfirmDeposit;
        private Button btnCancel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btnBack;
    }
}