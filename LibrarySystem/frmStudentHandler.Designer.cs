namespace LibrarySystem
{
    partial class frmStudentHandler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIDNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFn = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.cboSection = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRFID = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRFID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 82);
            this.panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(623, 82);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add Student Information";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.lblRFID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnRFID);
            this.groupBox1.Controls.Add(this.cboSection);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboGrade);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbLn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbMn);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbFn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbIDNumber);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 258);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tbIDNumber
            // 
            this.tbIDNumber.Location = new System.Drawing.Point(109, 50);
            this.tbIDNumber.Name = "tbIDNumber";
            this.tbIDNumber.ReadOnly = true;
            this.tbIDNumber.Size = new System.Drawing.Size(168, 27);
            this.tbIDNumber.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Firstname";
            // 
            // tbFn
            // 
            this.tbFn.Location = new System.Drawing.Point(109, 96);
            this.tbFn.Name = "tbFn";
            this.tbFn.Size = new System.Drawing.Size(168, 27);
            this.tbFn.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 19);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Middlename";
            // 
            // tbMn
            // 
            this.tbMn.Location = new System.Drawing.Point(109, 139);
            this.tbMn.Name = "tbMn";
            this.tbMn.Size = new System.Drawing.Size(168, 27);
            this.tbMn.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lastname";
            // 
            // tbLn
            // 
            this.tbLn.Location = new System.Drawing.Point(109, 183);
            this.tbLn.Name = "tbLn";
            this.tbLn.Size = new System.Drawing.Size(168, 27);
            this.tbLn.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Grade";
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboGrade.Location = new System.Drawing.Point(364, 47);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(243, 27);
            this.cboGrade.TabIndex = 10;
            // 
            // cboSection
            // 
            this.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSection.FormattingEnabled = true;
            this.cboSection.Location = new System.Drawing.Point(364, 93);
            this.cboSection.Name = "cboSection";
            this.cboSection.Size = new System.Drawing.Size(243, 27);
            this.cboSection.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Section";
            // 
            // btnRFID
            // 
            this.btnRFID.Location = new System.Drawing.Point(523, 132);
            this.btnRFID.Name = "btnRFID";
            this.btnRFID.Size = new System.Drawing.Size(84, 31);
            this.btnRFID.TabIndex = 13;
            this.btnRFID.Text = "Reader...";
            this.btnRFID.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "RFID";
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.Location = new System.Drawing.Point(360, 142);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(0, 19);
            this.lblRFID.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(523, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 31);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(433, 215);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 31);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmStudentHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(623, 340);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentHandler";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.frmStudentHandler_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIDNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFn;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.ComboBox cboSection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRFID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}