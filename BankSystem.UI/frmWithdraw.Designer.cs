namespace BankSystem.UI
{
    partial class frmWithdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWithdraw));
            txtAmount = new TextBox();
            btnWithdraw = new Button();
            label1 = new Label();
            lblCurrentBalance = new Label();
            btnConfirmWithdraw = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(303, 156);
            txtAmount.Margin = new Padding(6);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(348, 43);
            txtAmount.TabIndex = 0;
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = Color.Orange;
            btnWithdraw.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWithdraw.ForeColor = SystemColors.ControlLightLight;
            btnWithdraw.Location = new Point(424, 268);
            btnWithdraw.Margin = new Padding(6);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(246, 54);
            btnWithdraw.TabIndex = 1;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 159);
            label1.Name = "label1";
            label1.Size = new Size(120, 38);
            label1.TabIndex = 2;
            label1.Text = "Amount";
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentBalance.ForeColor = SystemColors.Highlight;
            lblCurrentBalance.Location = new Point(303, 52);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(265, 46);
            lblCurrentBalance.TabIndex = 3;
            lblCurrentBalance.Text = "CurrentBalance";
            // 
            // btnConfirmWithdraw
            // 
            btnConfirmWithdraw.BackColor = SystemColors.MenuHighlight;
            btnConfirmWithdraw.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmWithdraw.ForeColor = SystemColors.ControlLightLight;
            btnConfirmWithdraw.Location = new Point(166, 268);
            btnConfirmWithdraw.Margin = new Padding(6);
            btnConfirmWithdraw.Name = "btnConfirmWithdraw";
            btnConfirmWithdraw.Size = new Size(246, 54);
            btnConfirmWithdraw.TabIndex = 4;
            btnConfirmWithdraw.Text = "ConfirmWithdraw";
            btnConfirmWithdraw.UseVisualStyleBackColor = false;
            btnConfirmWithdraw.Click += btnConfirmWithdraw_Click;
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
            btnBack.ForeColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(133, 50);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += button1_Click;
            // 
            // frmWithdraw
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 447);
            Controls.Add(btnBack);
            Controls.Add(btnConfirmWithdraw);
            Controls.Add(lblCurrentBalance);
            Controls.Add(label1);
            Controls.Add(btnWithdraw);
            Controls.Add(txtAmount);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "frmWithdraw";
            Text = "frmWithdraw";
            Load += frmWithdraw_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAmount;
        private Button btnWithdraw;
        private Label label1;
        private Label lblCurrentBalance;
        private Button btnConfirmWithdraw;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btnBack;
    }
}