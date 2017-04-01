namespace LibrarySystem
{
    partial class frmBookHandler
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAddInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCR = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAN = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(470, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 31);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(560, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 31);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboCategory.Location = new System.Drawing.Point(441, 47);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(203, 27);
            this.cboCategory.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "No. of Copies";
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(116, 183);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(203, 27);
            this.tbQty.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Publisher";
            // 
            // tbPublisher
            // 
            this.tbPublisher.Location = new System.Drawing.Point(116, 139);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(203, 27);
            this.tbPublisher.TabIndex = 5;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Author";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(116, 96);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(203, 27);
            this.tbAuthor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(116, 50);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(203, 27);
            this.tbTitle.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbAN);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbCN);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbISBN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbAddInfo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbCR);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.cboCategory);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbQty);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbPublisher);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAuthor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTitle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 317);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Additional Info";
            // 
            // tbAddInfo
            // 
            this.tbAddInfo.Location = new System.Drawing.Point(441, 139);
            this.tbAddInfo.Name = "tbAddInfo";
            this.tbAddInfo.Size = new System.Drawing.Size(203, 27);
            this.tbAddInfo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Copyright";
            // 
            // tbCR
            // 
            this.tbCR.Location = new System.Drawing.Point(441, 96);
            this.tbCR.Name = "tbCR";
            this.tbCR.Size = new System.Drawing.Size(203, 27);
            this.tbCR.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 82);
            this.panel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(656, 82);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Book Infomation";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "ISBN";
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(116, 227);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(203, 27);
            this.tbISBN.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(337, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Call No";
            // 
            // tbCN
            // 
            this.tbCN.Location = new System.Drawing.Point(441, 185);
            this.tbCN.Name = "tbCN";
            this.tbCN.Size = new System.Drawing.Size(203, 27);
            this.tbCN.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Account No";
            // 
            // tbAN
            // 
            this.tbAN.Location = new System.Drawing.Point(441, 229);
            this.tbAN.Name = "tbAN";
            this.tbAN.Size = new System.Drawing.Size(203, 27);
            this.tbAN.TabIndex = 26;
            // 
            // frmBookHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(656, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmBookHandler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book";
            this.Load += new System.EventHandler(this.frmBookHandler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAddInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAN;
    }
}