namespace StaffManagement
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Timbre Kampuchea", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(333, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Timbre Kampuchea", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(156, 87);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(74, 24);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Staff ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Timbre Kampuchea", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(156, 134);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 24);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Staff Name";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Timbre Kampuchea", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.Location = new System.Drawing.Point(156, 216);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(74, 24);
            this.lblPos.TabIndex = 3;
            this.lblPos.Text = "Position";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Timbre Kampuchea", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(156, 261);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(60, 24);
            this.lblSalary.TabIndex = 4;
            this.lblSalary.Text = "Salary";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Timbre Kampuchea", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(156, 176);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(70, 24);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(306, 87);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(301, 24);
            this.txtID.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(306, 134);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 24);
            this.txtName.TabIndex = 10;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(306, 176);
            this.txtGender.Multiline = true;
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(301, 26);
            this.txtGender.TabIndex = 11;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(306, 216);
            this.txtPosition.Multiline = true;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(301, 27);
            this.txtPosition.TabIndex = 12;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(306, 261);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(301, 24);
            this.txtSalary.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(661, 81);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 30);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(661, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 29);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lime;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(661, 176);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 26);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReport.Location = new System.Drawing.Point(661, 257);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(127, 31);
            this.btnReport.TabIndex = 17;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(661, 216);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 28);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseMnemonic = false;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 538);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnClear;
    }
}

