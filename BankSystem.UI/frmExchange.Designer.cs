namespace BankSystem.UI
{
    partial class frmExchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExchange));
            cbType = new ComboBox();
            txtAmount = new TextBox();
            label1 = new Label();
            lblRete = new Label();
            lblRate = new TextBox();
            btnCalculate = new Button();
            btnConfirm = new Button();
            btnPrint = new Button();
            lblResult = new Label();
            btnBack = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            label2 = new Label();
            SuspendLayout();
            // 
            // cbType
            // 
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "USD to KHR", "KHR to USD" });
            cbType.Location = new Point(245, 311);
            cbType.Name = "cbType";
            cbType.Size = new Size(283, 45);
            cbType.TabIndex = 0;
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(245, 173);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(283, 43);
            txtAmount.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label1.Location = new Point(116, 173);
            label1.Name = "label1";
            label1.Size = new Size(120, 38);
            label1.TabIndex = 2;
            label1.Text = "Amount";
            // 
            // lblRete
            // 
            lblRete.AutoSize = true;
            lblRete.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblRete.Location = new Point(116, 246);
            lblRete.Name = "lblRete";
            lblRete.Size = new Size(73, 38);
            lblRete.TabIndex = 4;
            lblRete.Text = "Rete";
            // 
            // lblRate
            // 
            lblRate.Location = new Point(242, 243);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(286, 43);
            lblRate.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.HotTrack;
            btnCalculate.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = SystemColors.ButtonHighlight;
            btnCalculate.Location = new Point(245, 406);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(159, 58);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.LimeGreen;
            btnConfirm.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = SystemColors.ButtonHighlight;
            btnConfirm.Location = new Point(71, 406);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(159, 58);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(421, 406);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(159, 58);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblResult.Location = new Point(116, 318);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(93, 38);
            lblResult.TabIndex = 8;
            lblResult.Text = "Result";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(109, 49);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(245, 71);
            label2.Name = "label2";
            label2.Size = new Size(201, 54);
            label2.TabIndex = 11;
            label2.Text = "Exchange";
            // 
            // frmExchange
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 721);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(lblResult);
            Controls.Add(btnPrint);
            Controls.Add(btnConfirm);
            Controls.Add(btnCalculate);
            Controls.Add(lblRete);
            Controls.Add(lblRate);
            Controls.Add(label1);
            Controls.Add(txtAmount);
            Controls.Add(cbType);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "frmExchange";
            Text = "frmExchange";
            Load += frmExchange_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbType;
        private TextBox txtAmount;
        private Label label1;
        private Label lblRete;
        private TextBox lblRate;
        private Button btnCalculate;
        private Button btnConfirm;
        private Button btnPrint;
        private Label lblResult;
        private Button btnBack;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label2;
    }
}