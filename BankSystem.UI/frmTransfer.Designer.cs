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
            SuspendLayout();
            // 
            // txtReceiverID
            // 
            txtReceiverID.Location = new Point(300, 203);
            txtReceiverID.Name = "txtReceiverID";
            txtReceiverID.Size = new Size(280, 43);
            txtReceiverID.TabIndex = 0;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(300, 287);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(280, 43);
            txtAmount.TabIndex = 1;
            // 
            // ReceiverID
            // 
            ReceiverID.AutoSize = true;
            ReceiverID.Location = new Point(146, 203);
            ReceiverID.Name = "ReceiverID";
            ReceiverID.Size = new Size(148, 38);
            ReceiverID.TabIndex = 2;
            ReceiverID.Text = "ReceiverID";
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.Location = new Point(146, 290);
            Amount.Name = "Amount";
            Amount.Size = new Size(116, 38);
            Amount.TabIndex = 3;
            Amount.Text = "Amount";
            // 
            // btnTransfer
            // 
            btnTransfer.Location = new Point(609, 447);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(135, 53);
            btnTransfer.TabIndex = 4;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = true;
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
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 49);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmTransfer
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 655);
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
    }
}