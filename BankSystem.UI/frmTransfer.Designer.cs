namespace BankSystem.UI
{
    partial class frmTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransfer));
            txtReceiverID = new TextBox();
            txtAmount = new TextBox();
            ReceiverID = new Label();
            Amount = new Label();
            btnTransfer = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            btnBack = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtReceiverID
            // 
            txtReceiverID.Location = new Point(208, 175);
            txtReceiverID.Name = "txtReceiverID";
            txtReceiverID.Size = new Size(347, 43);
            txtReceiverID.TabIndex = 0;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(208, 243);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(347, 43);
            txtAmount.TabIndex = 1;
            // 
            // ReceiverID
            // 
            ReceiverID.AutoSize = true;
            ReceiverID.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            ReceiverID.Location = new Point(54, 175);
            ReceiverID.Name = "ReceiverID";
            ReceiverID.Size = new Size(150, 38);
            ReceiverID.TabIndex = 2;
            ReceiverID.Text = "ReceiverID";
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            Amount.Location = new Point(54, 246);
            Amount.Name = "Amount";
            Amount.Size = new Size(120, 38);
            Amount.TabIndex = 3;
            Amount.Text = "Amount";
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = SystemColors.MenuHighlight;
            btnTransfer.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransfer.ForeColor = SystemColors.ButtonHighlight;
            btnTransfer.Location = new Point(195, 334);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(280, 53);
            btnTransfer.TabIndex = 4;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage_1;
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
            btnBack.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 49);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(249, 79);
            label2.Name = "label2";
            label2.Size = new Size(176, 54);
            label2.TabIndex = 12;
            label2.Text = "Transfer";
            // 
            // frmTransfer
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 655);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(btnTransfer);
            Controls.Add(Amount);
            Controls.Add(ReceiverID);
            Controls.Add(txtAmount);
            Controls.Add(txtReceiverID);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "frmTransfer";
            Text = "frmTransfer";
            Load += frmTransfer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtReceiverID;
        private TextBox txtAmount;
        private Label ReceiverID;
        private Label Amount;
        private Button btnTransfer;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btnBack;
        private Label label2;
    }
}