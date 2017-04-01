using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;


using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
namespace LibrarySystem
{
    public partial class frmMain : Form
    {
        frmLogin frmLogin;
        string fn;
        int id;
        public frmMain(int _id, string _fn, int _role, Form frm)
        {
            this.frmLogin = (frmLogin)frm;
            InitializeComponent();
            fn = _fn;
            id = _id;

            using (library_dbEntities db = new library_dbEntities())
            {
                var sec = from s in db.tbl_sec
                          where s.sec_active == 1
                          select s;

                cboStudInfoSec.DataSource = sec.ToList();
                cboStudInfoSec.DisplayMember = "sec_details";
                cboStudInfoSec.ValueMember = "sec_id";

                cboReturnedSection.DataSource = sec.ToList();
                cboReturnedSection.DisplayMember = "sec_details";
                cboReturnedSection.ValueMember = "sec_id";

                cboBorrowSection.DataSource = sec.ToList();
                cboBorrowSection.DisplayMember = "sec_details";
                cboBorrowSection.ValueMember = "sec_id";

                var category = from c in db.tbl_book_category
                               select c;
                cboBookInfoCategory.DataSource = category.ToList();
                cboBookInfoCategory.DisplayMember = "bc_detail";
                cboBookInfoCategory.ValueMember = "bc_id";

                cboBookUsageCategory.DataSource = category.ToList();
                cboBookUsageCategory.DisplayMember = "bc_detail";
                cboBookUsageCategory.ValueMember = "bc_id";
            }
            cboStudInfoSec.SelectedIndex = 0;
            cboStudInfoFrom.SelectedIndex = 0;
            cboStudInfoTo.SelectedIndex = 0;
            cboBookInfoCategory.SelectedIndex = 0;
            cboReturnedSection.SelectedIndex = 0;
            cboBookUsageCategory.SelectedIndex = 0;

            pnlStudentInfo.Dock = DockStyle.Fill;
            pnlBookInfo.Dock = DockStyle.Fill;
            tcBookTransaction.Dock = DockStyle.Fill;
            pnlReports.Dock = DockStyle.Fill;
            pnlBookUsage.Dock = DockStyle.Fill;
            pnlReportBack.Dock = DockStyle.Fill;

            pnlStudInfoExpand.Width = 30;
            pnlBookMenu.Width = 30;

            pnlStudentInfo.BringToFront();
            pnlReportBack.BringToFront();

            btnBookStat.BringToFront();
            //btnStudentStat.BringToFront();

            //frmPrint frmPrint = new frmPrint();
            //frmPrint.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show(this,"Logout?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes){
                e.Cancel = true;
                return;
            }
            frmLogin.Show();
            frmLogin.WindowState = FormWindowState.Normal;
        }

        private void searchStudentInfo() 
        {

            int sec = int.Parse(cboStudInfoSec.SelectedValue.ToString());
            int s_from = int.Parse(cboStudInfoFrom.SelectedItem.ToString());
            int s_to = int.Parse(cboStudInfoTo.SelectedItem.ToString());
            using(library_dbEntities db = new library_dbEntities())
            {
                if (chkSection.Checked)
                {
                    var studlist = from s in db.view_students_information
                               where s.sec_id == sec && (s.rfid_tag_id.Contains(tbStudInfoSearch.Text.Trim()) || s.stud_fn.Contains(tbStudInfoSearch.Text.Trim()) || s.stud_ln.Contains(tbStudInfoSearch.Text.Trim())) && (s.yr_details >= s_from && s.yr_details <= s_to)
                               select new { s.stud_id_number, s.stud_fn, s.stud_mn, s.stud_ln, s.yr_details, s.sec_details, s.rfid_tag_id };


                    lvwStudInfo.Items.Clear();

                    foreach (var s in studlist)
                    {
                        lvwStudInfo.Items.Add(s.stud_id_number);
                        lvwStudInfo.Items[lvwStudInfo.Items.Count - 1].SubItems.Add(s.stud_ln + ", " + s.stud_fn + " " + s.stud_mn);
                        lvwStudInfo.Items[lvwStudInfo.Items.Count - 1].SubItems.Add(s.yr_details.ToString());
                        lvwStudInfo.Items[lvwStudInfo.Items.Count - 1].SubItems.Add(s.sec_details.ToString());
                        lvwStudInfo.Items[lvwStudInfo.Items.Count - 1].SubItems.Add(s.rfid_tag_id);
                    }

                    lblStudInfoCount.Text = "Shows " + studlist.Count().ToString() + " records.";
                }
                else
                {
                    var studlist = from s in db.view_students_information
                               where (s.rfid_tag_id.Contains(tbStudInfoSearch.Text.Trim()) || s.stud_fn.Contains(tbStudInfoSearch.Text.Trim()) || s.stud_ln.Contains(tbStudInfoSearch.Text.Trim())) && (s.yr_details >= s_from && s.yr_details <= s_to)
                               select new { s.stud_id_number, s.stud_fn, s.stud_mn, s.stud_ln, s.yr_details, s.sec_details, s.rfid_tag_id };

                    lvwStudInfo.Items.Clear();

                    foreach (var s in studlist)
                    {
                        lvwStudInfo.Items.Add(s.stud_id_number);
                        lvwStudInfo.Items[lvwStudInfo.Items.Count - 1].SubItems.Add(s.stud_ln + ", " + s.stud_fn + " " + s.stud_mn);
                        lvwStudInfo.Items[lvwStudInfo.Items.Count - 1].SubItems.Add(s.yr_details.ToString());
                        lvwStudInfo.Items[lvwStudInfo.Items.Count - 1].SubItems.Add(s.sec_details.ToString());
                        lvwStudInfo.Items[lvwStudInfo.Items.Count - 1].SubItems.Add(s.rfid_tag_id);
                    }
                    lblStudInfoCount.Text = "Shows " + studlist.Count().ToString() + " records.";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pnlStudentInfo.BringToFront();
            searchStudentInfo();
        }

        private void tbStudInfoSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchStudentInfo_Click(object sender, EventArgs e)
        {
            searchStudentInfo();
        }

        private void tbStudInfoSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchStudentInfo();
            }
        }
        bool studInfoExpand = false;
        private void lblStudInfoExpand_Click(object sender, EventArgs e)
        {
            if (studInfoExpand == false)
            {
                while (pnlStudInfoExpand.Width <= 200)
                {
                    pnlStudInfoExpand.Width += 1;
                }
                //lblStudInfoExpand.Text = ">>";
                pnlStudInfoExpand.Width = 200;
                studInfoExpand = true;
            }
            else
            {
                while (pnlStudInfoExpand.Width >= 25)
                {
                    pnlStudInfoExpand.Width -= 1;
                }
                //lblStudInfoExpand.Text = "<<";
                pnlStudInfoExpand.Width = 25;
                studInfoExpand = false;
            }
        }

        private void lblStudInfoExpand_MouseMove(object sender, MouseEventArgs e)
        {
            lblStudInfoExpand.BackColor = Color.Silver;
        }

        private void lblStudInfoExpand_MouseLeave(object sender, EventArgs e)
        {
            lblStudInfoExpand.BackColor = Color.Gainsboro;
        }

        private void btnStudInfoDelete_Click(object sender, EventArgs e)
        {
            if(lvwStudInfo.SelectedItems.Count == 0)
            {
                MessageBox.Show(this,"You must select to the list first","Invalid",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            if(MessageBox.Show(this, "Are you sure you want to delete?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                string id = lvwStudInfo.SelectedItems[0].Text;
                using(library_dbEntities db = new library_dbEntities())
                {
                    tbl_student_info s = db.tbl_student_info.FirstOrDefault( i => i.stud_id_number == id );
                    db.tbl_student_info.Remove(s);
                    db.SaveChanges();
                }
                MessageBox.Show(this,"Information successfully deleted","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnSearchStudentInfo.PerformClick();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnStudInfoEdit_Click(object sender, EventArgs e)
        {
            if (lvwStudInfo.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "You must select to the list first", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string id = lvwStudInfo.SelectedItems[0].Text;
            frmStudentHandler frm = new frmStudentHandler(id);
            frm.ShowDialog();
            btnSearchStudentInfo.PerformClick();
        }

        private void btnStudInfoAdd_Click(object sender, EventArgs e)
        {
            frmStudentHandler frm = new frmStudentHandler();
            frm.ShowDialog();
            btnSearchStudentInfo.PerformClick();
        }
        private void SearchBookInfo() 
        {
            if (chkBookInfoCategory.Checked) 
            {
                int bc_id = int.Parse(cboBookInfoCategory.SelectedValue.ToString());
                using(library_dbEntities db = new library_dbEntities())
                {
                    var book = from b in db.view_book_information
                               where b.bc_id == bc_id && (b.b_title.Contains(tbBookInfoSearch.Text) || b.b_author.Contains(tbBookInfoSearch.Text) || b.b_publisher.Contains(tbBookInfoSearch.Text))
                               select b;
                    lvwBookInfo.Items.Clear();
                    foreach(var b in book)
                    {
                        lvwBookInfo.Items.Add(b.b_id.ToString());
                        lvwBookInfo.Items[lvwBookInfo.Items.Count - 1].SubItems.Add(b.b_title + " " + b.b_add_info);
                        lvwBookInfo.Items[lvwBookInfo.Items.Count - 1].SubItems.Add(b.b_author);
                        lvwBookInfo.Items[lvwBookInfo.Items.Count - 1].SubItems.Add(b.b_publisher);
                        lvwBookInfo.Items[lvwBookInfo.Items.Count - 1].SubItems.Add(b.b_qty.ToString());
                        lvwBookInfo.Items[lvwBookInfo.Items.Count - 1].SubItems.Add(b.bc_detail);
                    }
                    lblBookInfoCount.Text = "Shows " + book.Count().ToString() + " records";
                }
            }
            else
            {
                using (library_dbEntities db = new library_dbEntities())
                {
                    var book = from b in db.view_book_information
                               where (b.b_title.Contains(tbBookInfoSearch.Text) || b.b_author.Contains(tbBookInfoSearch.Text) || b.b_publisher.Contains(tbBookInfoSearch.Text))
                               orderby b.b_title
                               select b;
                    lvwBookInfo.Items.Clear();
                    int x = 0;
                    foreach (var b in book)
                    {
                        x++;
                        lvwBookInfo.Items.Add(b.b_id.ToString());
                        lvwBookInfo.Items[lvwBookInfo.Items.Count - 1].SubItems.Add(b.b_title + " " + b.b_add_info);
                        lvwBookInfo.Items[lvwBookInfo.Items.Count - 1].SubItems.Add(b.b_author);
                        lvwBookInfo.Items[lvwBookInfo.Items.Count - 1].SubItems.Add(b.b_publisher);
                        lvwBookInfo.Items[lvwBookInfo.Items.Count - 1].SubItems.Add(b.b_qty.ToString());
                        lvwBookInfo.Items[lvwBookInfo.Items.Count - 1].SubItems.Add(b.bc_detail);

                        if (b.b_qty == 0 )
                        {
                            lvwBookInfo.Items[lvwBookInfo.Items.Count - 1].ForeColor = Color.Red;
                        }

                        if (x % 2 == 0)
                        {
                            lvwBookInfo.Items[lvwBookInfo.Items.Count - 1].BackColor = Color.Gainsboro;
                        }
                        else
                        {
                            lvwBookInfo.Items[lvwBookInfo.Items.Count - 1].BackColor = Color.White;
                        }

                    }
                    lblBookInfoCount.Text = "Shows " + book.Count().ToString() + " records";
                }
            }
        }
        private void btnBookInfoSearch_Click(object sender, EventArgs e)
        {
            SearchBookInfo();
        }

        private void tbBookInfoSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchBookInfo();
            }
        }

        private void btnBookInfo_Click(object sender, EventArgs e)
        {
            pnlBookInfo.BringToFront();
        }

        private void btnBookTransaction_Click(object sender, EventArgs e)
        {
            tcBookTransaction.BringToFront();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (lvwBookInfo.SelectedItems.Count < 1)
            {
                MessageBox.Show(this, "You must select to the list first", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (int.Parse( lvwBookInfo.SelectedItems[0].SubItems[4].Text) == 0)
            {
                MessageBox.Show(this, "Unable to borrow because of zero number of copies", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BookInfo bookinfo = new BookInfo(int.Parse(lvwBookInfo.SelectedItems[0].Text), lvwBookInfo.SelectedItems[0].SubItems[1].Text, lvwBookInfo.SelectedItems[0].SubItems[2].Text, lvwBookInfo.SelectedItems[0].SubItems[3].Text);
            frmBorrowRFID frm = new frmBorrowRFID(bookinfo);
            frm.ShowDialog();
            SearchBookInfo();
        }

        private void tsmiBorrow_Click(object sender, EventArgs e)
        {
            btnBorrow.PerformClick();
        }

        private void tsmiSearchBook_Click(object sender, EventArgs e)
        {
            btnBookInfoSearch.PerformClick();
        }
        private void SearchBorrowedBook()
        {
            lvwBorrowedBooks.Items.Clear();
            if(chkBorrowSection.Checked)
            {
                
                using (library_dbEntities db = new library_dbEntities())
                {
                    int borrow_secid = int.Parse(cboBorrowSection.SelectedValue.ToString());
                    
                    var vborrow = from vb in db.view_book_borrow_info
                                  where (vb.stud_ln.Contains(tbBoorowSearch.Text) || vb.stud_id_number.Contains(tbBoorowSearch.Text)
                                  || vb.b_author.Contains(tbBoorowSearch.Text) || vb.b_title.Contains(tbBoorowSearch.Text)) &&
                                  (vb.bb_borrowed_date >= dtpBorrowFrom.Value && vb.bb_borrowed_date <= dtpBorrowTo.Value) &&
                                  vb.bb_status == 0 && vb.sec_id == borrow_secid
                                  select vb;

                    int x = 0;
                    foreach (var b in vborrow)
                    {
                        x++;
                        lvwBorrowedBooks.Items.Add(b.bb_id.ToString());
                        lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].SubItems.Add(b.b_id.ToString());
                        lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].SubItems.Add(b.stud_id_number.ToString());
                        lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].SubItems.Add(b.b_title.ToString());
                        lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].SubItems.Add(b.b_author.ToString());
                        lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].SubItems.Add(b.stud_ln.ToString() + ", " + b.stud_fn.ToString());
                        lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].SubItems.Add(b.yr_details.ToString() + " " + b.sec_details.ToString());
                        lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].SubItems.Add(string.Format("{0:dd/MM/yyyy}", b.bb_borrowed_date));
                        lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].SubItems.Add(string.Format("{0:dd/MM/yyyy}", b.bb_due_date));
                        lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].SubItems.Add(b.b_ref_num.ToString());
                        DateTime d = new DateTime();
                        d = DateTime.Now;

                        double n = (b.bb_due_date - d).TotalDays;
                        if (n < 1)
                        {
                            lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].ForeColor = Color.Red;
                        }

                        if (x % 2 == 0)
                        {
                            lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].BackColor = Color.Gainsboro;
                        }
                        else
                        {
                            lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].BackColor = Color.White;
                        }

                        lblBorrowCount.Text = x.ToString();
                    }

                }
            }
            else
            {
            using (library_dbEntities db = new library_dbEntities())
            {
                    var vborrow = from vb in db.view_book_borrow_info
                                  where (vb.stud_ln.Contains(tbBoorowSearch.Text) || vb.stud_id_number.Contains(tbBoorowSearch.Text)
                                  || vb.b_author.Contains(tbBoorowSearch.Text) || vb.b_title.Contains(tbBoorowSearch.Text)) &&
                                  (vb.bb_borrowed_date >= dtpBorrowFrom.Value && vb.bb_borrowed_date <= dtpBorrowTo.Value) &&
                                  vb.bb_status == 0
                                  select vb;
                    int x = 0;
                    if (vborrow != null)
                    {
                        foreach (var b in vborrow)
                        {
                            x++;
                            lvwBorrowedBooks.Items.Add(b.bb_id.ToString());
                            lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].SubItems.Add(b.b_id.ToString());
                            lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].SubItems.Add(b.stud_id_number.ToString());
                            lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].SubItems.Add(b.b_title.ToString());
                            lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].SubItems.Add(b.b_author.ToString());
                            lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].SubItems.Add(b.stud_ln.ToString() + ", " + b.stud_fn.ToString());
                            lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].SubItems.Add(b.yr_details.ToString() + " " + b.sec_details.ToString());
                            lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].SubItems.Add(string.Format("{0:dd/MM/yyyy}", b.bb_borrowed_date));
                            lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].SubItems.Add(string.Format("{0:dd/MM/yyyy}", b.bb_due_date));
                            lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].SubItems.Add(b.b_ref_num.ToString());
                            DateTime d = new DateTime();
                            d = DateTime.Now;

                            double n = (b.bb_due_date - d).TotalDays;
                            if (n < 1)
                            {
                                lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].ForeColor = Color.Red;
                            }

                            if (x % 2 == 0)
                            {
                                lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].BackColor = Color.Gainsboro;
                            }
                            else
                            {
                                lvwBorrowedBooks.Items[lvwBorrowedBooks.Items.Count - 1].BackColor = Color.White;
                            }

                            //lblBorrowCount.Text = vborrow.Count().ToString();
                        }
                    }

                }
            }
        }
        private void btnBorrowSearch_Click(object sender, EventArgs e)
        {
            SearchBorrowedBook();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBorrowSearch.PerformClick();
        }

        private void tsmiBorrowReturn_Click(object sender, EventArgs e)
        {
            btnReturn.PerformClick();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(lvwBorrowedBooks.SelectedItems.Count < 1)
            {
                MessageBox.Show(this, "You must select to the list first", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(MessageBox.Show(this,"Are you sure you want to return the book?","Return",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== System.Windows.Forms.DialogResult.Yes)
            {
                int bb_id = int.Parse(lvwBorrowedBooks.SelectedItems[0].Text);
                int b_id = int.Parse(lvwBorrowedBooks.SelectedItems[0].SubItems[1].Text);
                string stud_id = lvwBorrowedBooks.SelectedItems[0].SubItems[2].Text;
                string ref_num = lvwBorrowedBooks.SelectedItems[0].SubItems[9].Text;
                DateTime rdate = new DateTime();
                rdate = DateTime.Now;
                int dcount = int.Parse((rdate - DateTime.Now).TotalDays.ToString());
                using( library_dbEntities db = new library_dbEntities() )
                {
                    tbl_returned_book rb = new tbl_returned_book 
                    { 
                        b_id = b_id,
                        stud_id_number = stud_id,
                        rb_returned_date = rdate,
                        rb_over_due_days = dcount,
                        ref_num = ref_num
                    };
                    db.tbl_returned_book.Add(rb);
                    db.SaveChanges();

                    tbl_borrowed_book borrow = db.tbl_borrowed_book.FirstOrDefault(b => b.bb_id == bb_id);
                    borrow.bb_status = 1;
                    db.SaveChanges();

                    tbl_book_info book = db.tbl_book_info.FirstOrDefault(b => b.b_id == b_id);
                    book.b_qty += 1;
                    db.SaveChanges();
                }
                MessageBox.Show(this, "Book was successfully returned", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchBorrowedBook();
            }
        }

        private void SearchReturnedBooks()
        {
            lvwReturnedBook.Items.Clear();

            if (chkReturnedSection.Checked)
            {
                using (library_dbEntities db = new library_dbEntities())
                {
                    int sec_id = int.Parse( cboReturnedSection.SelectedValue.ToString());
                    var returned = from r in db.view_book_returned
                                   where (r.rb_returned_date >= dtpReturned.Value && r.rb_returned_date <= dtpReturnedFrom.Value) &&
                                   (r.stud_fn.Contains(tbReturnedSearch.Text) || r.stud_ln.Contains(tbReturnedSearch.Text) || r.b_title.Contains(tbReturnedSearch.Text) || r.b_author.Contains(tbReturnedSearch.Text))
                                   &&  r.sec_id == sec_id
                                   select r;

                    if (returned != null)
                    {
                        int i = 0;
                        foreach (var r in returned)
                        {
                            lvwReturnedBook.Items.Add(r.b_title);
                            lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].SubItems.Add(r.b_author);
                            lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].SubItems.Add(r.rb_returned_date.ToShortDateString());
                            lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].SubItems.Add(r.rb_over_due_days.ToString());
                            lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].SubItems.Add(r.stud_id_number);
                            lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].SubItems.Add(r.stud_ln + ", " + r.stud_fn);
                            //lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].SubItems.Add(r.);
                            lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].SubItems.Add(r.yr_details + " " + r.sec_details);
                            lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].SubItems.Add(r.ref_num);

                            if (i % 2 == 0)
                            {
                                lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].BackColor =  Color.Gainsboro;;
                            }else
                            {
                                lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].BackColor = Color.White;;
                            }
                        }
                    }
                }
            }
            else{

                using (library_dbEntities db = new library_dbEntities())
                {
                    var returned = from r in db.view_book_returned
                                   where (r.rb_returned_date >= dtpReturnedFrom.Value && r.rb_returned_date <= dtpReturned.Value) &&
                                   (r.stud_fn.Contains(tbReturnedSearch.Text) || r.stud_ln.Contains(tbReturnedSearch.Text) || r.b_title.Contains(tbReturnedSearch.Text) || r.b_author.Contains(tbReturnedSearch.Text))
                                   select r;

                    if (returned != null)
                    {
                        int i = 0;
                        foreach (var r in returned)
                        {
                            i++;
                            lvwReturnedBook.Items.Add(r.b_title);
                            lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].SubItems.Add(r.b_author);
                            lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].SubItems.Add(r.rb_returned_date.ToShortDateString());
                            lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].SubItems.Add(r.rb_over_due_days.ToString());
                            lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].SubItems.Add(r.stud_id_number);
                            lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].SubItems.Add(r.stud_ln + ", " + r.stud_fn);
                            //lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].SubItems.Add(r.);
                            lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].SubItems.Add(r.yr_details + " " + r.sec_details);
                            lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].SubItems.Add(r.ref_num);
                            
                            if (i % 2 == 0)
                            {
                                lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].BackColor =  Color.Gainsboro;;
                            }else
                            {
                                lvwReturnedBook.Items[lvwReturnedBook.Items.Count - 1].BackColor = Color.White;;
                            }
                        }
                        
                    }
                }
            }
        }
        private void btnReturnedSearch_Click(object sender, EventArgs e)
        {
            SearchReturnedBooks();
        }

        private void tbReturnedSearch_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void tbReturnedSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchReturnedBooks();
            }
        }
        bool BookMenu = false;
        private void lblBookMenu_Click(object sender, EventArgs e)
        {
            if (BookMenu == false)
            {
                while (pnlBookMenu.Width <= 200)
                {
                    pnlBookMenu.Width += 1;
                }
                //lblStudInfoExpand.Text = ">>";
                pnlBookMenu.Width = 200;
                BookMenu = true;
            }
            else
            {
                while (pnlBookMenu.Width >= 30)
                {
                    pnlBookMenu.Width -= 1;
                }
                //lblStudInfoExpand.Text = "<<";
                pnlBookMenu.Width = 30;
                BookMenu = false;
            }
        }

        private void lblBookMenu_MouseLeave(object sender, EventArgs e)
        {
            lblBookMenu.BackColor = Color.Gainsboro;
        }

        private void lblBookMenu_MouseMove(object sender, MouseEventArgs e)
        {
            lblBookMenu.BackColor = Color.Silver;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            pnlReports.BringToFront();
        }

        private void btnBookStat_Click(object sender, EventArgs e)
        {
            pnlBookUsage.BringToFront();


            using (library_dbEntities db = new library_dbEntities())
            {
            }
        }

        private void btnCloseBookUsage_Click(object sender, EventArgs e)
        {
            pnlBookUsage.SendToBack();
        }
        private void SearchBookUsageStat()
        {
            try
            {
                lvwBookUsageList.Items.Clear();
                using (library_dbEntities db = new library_dbEntities())
                {
                        int catid = int.Parse(cboBookUsageCategory.SelectedValue.ToString());
                        var bookstat = from bs in db.view_bookstat
                                       where (bs.b_title.Contains( tbBookUsageSearch.Text ) || bs.b_author.Contains( tbBookUsageSearch.Text) || bs.b_publisher.Contains(  tbBookUsageSearch.Text) ) && 
                                       (bs.bb_borrowed_date >= (chkBookUsageDate.Checked ?  dtpBookUsageFrom.Value : DateTime.MinValue) &&
                                       bs.bb_borrowed_date <= (chkBookUsageDate.Checked ? dtpBookUsageFrom.Value : DateTime.MaxValue)) &&
                                       (bs.bc_id >= (chkBookUsageCategory.Checked ? catid : 0) && bs.bc_id <= (chkBookUsageCategory.Checked ? catid : 20)) 
                                       orderby bs.count_tbl_borrowed_book_b_id_ descending
                                       select bs;
                        int i = 0;
                        
                        if (bookstat != null)
                        {
                            int[] book_id = new int[bookstat.Count()];
                            foreach (var bs in bookstat)
                            {
                                book_id[i] = bs.b_id;
                                i++;

                                lvwBookUsageList.Items.Add(bs.b_title.ToString());
                                lvwBookUsageList.Items[lvwBookUsageList.Items.Count - 1].SubItems.Add(bs.b_author);
                                lvwBookUsageList.Items[lvwBookUsageList.Items.Count - 1].SubItems.Add(bs.b_publisher);
                                lvwBookUsageList.Items[lvwBookUsageList.Items.Count - 1].SubItems.Add(bs.count_tbl_borrowed_book_b_id_.ToString());
                                lvwBookUsageList.Items[lvwBookUsageList.Items.Count - 1].SubItems.Add(bs.bc_detail.ToString());
                                lvwBookUsageList.Items[lvwBookUsageList.Items.Count - 1].SubItems.Add(String.Format("{0:MM/dd/yyyy}", bs.bb_borrowed_date.ToShortDateString()));
                                if (i % 2 == 0)
                                {
                                    lvwBookUsageList.Items[lvwBookUsageList.Items.Count - 1].BackColor = Color.Gainsboro;
                                }
                                else
                                {
                                    lvwBookUsageList.Items[lvwBookUsageList.Items.Count - 1].BackColor = Color.White;
                                }

                            }
                            if (!System.IO.Directory.Exists(@"C:\ProgramData\Library")) System.IO.Directory.CreateDirectory(@"C:\ProgramData\Library");

                            using(XmlWriter writer = XmlWriter.Create(@"C:\ProgramData\Library\BookUsage.xml"))
                            {
                                writer.WriteStartDocument();
                                writer.WriteStartElement("BookUsage");
                                foreach (var bs in bookstat)
                                {
                                    writer.WriteStartElement("Book");
                                    writer.WriteElementString("BID", bs.b_id.ToString());
                                    writer.WriteElementString("Title", bs.b_title);
                                    writer.WriteElementString("Author", bs.b_author);
                                    writer.WriteElementString("Publisher", bs.b_publisher);
                                    writer.WriteElementString("Borrow_Count", bs.count_tbl_borrowed_book_b_id_.ToString());
                                    writer.WriteElementString("Category", bs.bc_detail);
                                    writer.WriteElementString("Date_Borrowed", String.Format("{0:MM/dd/yyyy}", bs.bb_borrowed_date.ToShortDateString()));
                                    
                                    writer.WriteEndElement();

                                }
                                writer.WriteEndElement();
                                writer.WriteEndDocument();
                            }

                            using (XmlWriter bwritter = XmlWriter.Create(@"C:\ProgramData\Library\BookUsageBorrower.xml"))
                            {
                                bwritter.WriteStartDocument();
                                bwritter.WriteStartElement("BookBorrowers");
                                foreach(var bs in book_id)
                                {
                                    var borrower = from b in db.view_book_borrow_info
                                               where (b.bb_borrowed_date >= (chkBookUsageDate.Checked ? dtpBookUsageFrom.Value : DateTime.MinValue) &&
                                                b.bb_borrowed_date <= (chkBookUsageDate.Checked ? dtpBookUsageFrom.Value : DateTime.MaxValue)) &&
                                                b.b_id == bs
                                               select b;

                                    foreach (var b in borrower)
                                    {
                                        bwritter.WriteStartElement("Borrower");

                                        bwritter.WriteElementString("ID_Number", b.stud_id_number);
                                        bwritter.WriteElementString("Student_Name", b.stud_ln + ", " + b.stud_fn);
                                        bwritter.WriteElementString("Yr_Section", b.yr_details + " - " + b.sec_details);
                                        bwritter.WriteElementString("BookID", b.b_id.ToString());

                                        bwritter.WriteEndElement();
                                    }
                                }
                                bwritter.WriteEndElement();
                                bwritter.WriteEndDocument();
                            }
                            lblBookUsageCount.Text = "Shows " + bookstat.Count().ToString() + " number of record(s).";
                        }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this,ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        private void btnBookUsageSearch_Click(object sender, EventArgs e)
        {
            SearchBookUsageStat();
        }

        private void tbBookUsageSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchBookUsageStat();
            }
        }

        private void btnBookUsagePrint_Click(object sender, EventArgs e)
        {
            try
            { 
                using(frmPrint frm = new frmPrint())
                {
                    ReportDocument rd = new ReportDocument();
                    ParameterValues crpv = new ParameterValues();
                    ParameterValues crpv1 = new ParameterValues();
                    ParameterDiscreteValue tbPeriod = new ParameterDiscreteValue();
                    ParameterDiscreteValue tbPrep = new ParameterDiscreteValue();

                    rd.Load(AppDomain.CurrentDomain.BaseDirectory.ToString() + @"Reports\rptBookUsage.rpt");
                    tbPeriod.Value = "";
                    if (chkBookUsageDate.Checked)
                    {
                        tbPeriod.Value = "Range from " + String.Format("{0:MM/dd/yyyy}", dtpBookUsageFrom.Value) + " to " + String.Format("{0:MM/dd/yyyy}", dtpBookUsageTo.Value) +"."; 
                    }

                    tbPrep.Value = "Prepared by " + fn;

                    crpv1.Add(tbPeriod);
                    crpv.Add(tbPrep);
                    rd.DataDefinition.ParameterFields["tbPeriod"].ApplyCurrentValues(crpv1);
                    rd.DataDefinition.ParameterFields["tbPrep"].ApplyCurrentValues(crpv);
                    frm.crvReport.ReportSource = rd;
                    frm.ShowDialog();
                    rd.Dispose();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            frmBookHandler frmbook = new frmBookHandler();
            frmbook.Show();
        }

        private void btnBookEdit_Click(object sender, EventArgs e)
        {
            if (lvwBookInfo.SelectedItems.Count < 1)
            {
                MessageBox.Show(this, "You must select to the list first", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using(library_dbEntities db = new library_dbEntities())
            {
                int b_id =  int.Parse(lvwBookInfo.SelectedItems[0].Text);
                tbl_book_info b_info = db.tbl_book_info.FirstOrDefault(b => b.b_id == b_id);
                BookInfo bookInfo = new BookInfo(b_id, b_info.b_title, b_info.b_add_info, b_info.b_author, b_info.b_publisher, b_info.b_qty, b_info.b_copyright.ToString(), b_info.b_call_no, b_info.b_acc_no, b_info.b_isbn, b_info.bc_id);

                frmBookHandler frmbook = new frmBookHandler(bookInfo);
                frmbook.Show();
            }
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            if (lvwBookInfo.SelectedItems.Count < 1)
            {
                MessageBox.Show(this, "You must select to the list first", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show(this, "Are you sure you want to delete? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                using (library_dbEntities db = new library_dbEntities())
                {
                    int b_id = int.Parse(lvwBookInfo.SelectedItems[0].Text);
                    tbl_book_info b_info = db.tbl_book_info.FirstOrDefault(b => b.b_id == b_id);
                    db.tbl_book_info.Remove(b_info);
                    db.SaveChanges();
                }
            }
        }

        private void tsmiSearchBookAdd_Click(object sender, EventArgs e)
        {
            btnBookAdd.PerformClick();
        }

        private void tsmiSearchBookEdit_Click(object sender, EventArgs e)
        {
            btnBookEdit.PerformClick();
        }

        private void tsmiSearchBookDelete_Click(object sender, EventArgs e)
        {
            btnBookDelete.PerformClick();
        }

        private void lblChangeUserInfo_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(id);
            frm.ShowDialog();
        }
    }
}
