namespace LibrarySystem
{
    partial class frmBorrowRFID
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelx = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblYrSec = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBPublisher = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBAuthor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBtitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRFID = new System.Windows.Forms.Label();
            this.tmrRead = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tbRefNum = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.labelx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 61);
            this.panel1.TabIndex = 2;
            // 
            // labelx
            // 
            this.labelx.BackColor = System.Drawing.Color.Transparent;
            this.labelx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelx.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelx.Location = new System.Drawing.Point(0, 0);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(476, 61);
            this.labelx.TabIndex = 2;
            this.labelx.Text = "Borrow Book";
            this.labelx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblBDate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.btnBorrow);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblRFID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(476, 390);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblRDate
            // 
            this.lblRDate.AutoSize = true;
            this.lblRDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblRDate.Location = new System.Drawing.Point(122, 314);
            this.lblRDate.Name = "lblRDate";
            this.lblRDate.Size = new System.Drawing.Size(0, 19);
            this.lblRDate.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.Location = new System.Drawing.Point(24, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date Return";
            // 
            // lblBDate
            // 
            this.lblBDate.AutoSize = true;
            this.lblBDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblBDate.Location = new System.Drawing.Point(122, 290);
            this.lblBDate.Name = "lblBDate";
            this.lblBDate.Size = new System.Drawing.Size(0, 19);
            this.lblBDate.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F);
            this.label10.Location = new System.Drawing.Point(21, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "Date Borrow";
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(12, 347);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(287, 35);
            this.lblMsg.TabIndex = 13;
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.btnBorrow.Enabled = false;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.Color.White;
            this.btnBorrow.Location = new System.Drawing.Point(305, 343);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(80, 41);
            this.btnBorrow.TabIndex = 7;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(386, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 41);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblIDNumber);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblYrSec);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 109);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student\'s Information";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNumber.Location = new System.Drawing.Point(112, 22);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(0, 26);
            this.lblIDNumber.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID Number";
            // 
            // lblYrSec
            // 
            this.lblYrSec.AutoSize = true;
            this.lblYrSec.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYrSec.Location = new System.Drawing.Point(112, 76);
            this.lblYrSec.Name = "lblYrSec";
            this.lblYrSec.Size = new System.Drawing.Size(0, 26);
            this.lblYrSec.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Year Section";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(112, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 26);
            this.lblName.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbRefNum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblBPublisher);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblBAuthor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblBtitle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 156);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Information";
            // 
            // lblBPublisher
            // 
            this.lblBPublisher.AutoSize = true;
            this.lblBPublisher.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPublisher.Location = new System.Drawing.Point(112, 90);
            this.lblBPublisher.Name = "lblBPublisher";
            this.lblBPublisher.Size = new System.Drawing.Size(0, 26);
            this.lblBPublisher.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Publisher";
            // 
            // lblBAuthor
            // 
            this.lblBAuthor.AutoSize = true;
            this.lblBAuthor.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBAuthor.Location = new System.Drawing.Point(112, 64);
            this.lblBAuthor.Name = "lblBAuthor";
            this.lblBAuthor.Size = new System.Drawing.Size(0, 26);
            this.lblBAuthor.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Author";
            // 
            // lblBtitle
            // 
            this.lblBtitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtitle.Location = new System.Drawing.Point(112, 17);
            this.lblBtitle.Name = "lblBtitle";
            this.lblBtitle.Size = new System.Drawing.Size(329, 51);
            this.lblBtitle.TabIndex = 1;
            this.lblBtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFID.Location = new System.Drawing.Point(220, 206);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(0, 26);
            this.lblRFID.TabIndex = 12;
            this.lblRFID.TextChanged += new System.EventHandler(this.lblRFID_TextChanged);
            // 
            // tmrRead
            // 
            this.tmrRead.Interval = 500;
            this.tmrRead.Tick += new System.EventHandler(this.tmrRead_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reference";
            // 
            // tbRefNum
            // 
            this.tbRefNum.Location = new System.Drawing.Point(106, 123);
            this.tbRefNum.Name = "tbRefNum";
            this.tbRefNum.Size = new System.Drawing.Size(189, 27);
            this.tbRefNum.TabIndex = 7;
            // 
            // frmBorrowRFID
            // 
            this.AcceptButton = this.btnBorrow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(476, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmBorrowRFID";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrower Book";
            this.Load += new System.EventHandler(this.frmBorrowRFID_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBPublisher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblYrSec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer tmrRead;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblRDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbRefNum;
        private System.Windows.Forms.Label label2;
    }
}