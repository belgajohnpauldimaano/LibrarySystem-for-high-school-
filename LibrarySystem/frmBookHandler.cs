using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class frmBookHandler : Form
    {
        public frmBookHandler()
        {
            InitializeComponent();

        }
        BookInfo bookinfo;
        public frmBookHandler(BookInfo _bookinfo)
        {
            InitializeComponent();
            bookinfo = _bookinfo;

            lblID.Text = bookinfo.B_id.ToString();
            tbTitle.Text = bookinfo.B_title;
            tbAuthor.Text = bookinfo.B_author;
            tbPublisher.Text = bookinfo.B_publisher;
            tbQty.Text = bookinfo.B_qty.ToString();
            tbAddInfo.Text = bookinfo.B_addinfo;
            tbISBN.Text = bookinfo.B_isbn;
            tbCR.Text = bookinfo.B_cr;
            tbCN.Text = bookinfo.B_callno;
            tbAN.Text = bookinfo.B_acc_no;
            cboCategory.SelectedValue = bookinfo.Bc_id;
        }
        private void frmBookHandler_Load(object sender, EventArgs e)
        {
            using (library_dbEntities db = new library_dbEntities())
            {
                var cat = from c in db.tbl_book_category
                          select c;

                cboCategory.DataSource = cat.ToList();
                cboCategory.DisplayMember = "bc_detail";
                cboCategory.ValueMember = "bc_id";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int bc_id = int.Parse( cboCategory.SelectedValue.ToString() );
            if (bookinfo != null)
            {
                using (library_dbEntities db = new library_dbEntities())
                {
                    tbl_book_info b = db.tbl_book_info.FirstOrDefault(i => i.b_id == bookinfo.B_id);
                    b.b_title = tbTitle.Text.Replace('\'',' ');
                    b.b_author = tbAuthor.Text.Replace('\'', ' ');
                    b.b_publisher = tbPublisher.Text.Replace('\'', ' ');
                    b.b_add_info = tbAddInfo.Text.Replace('\'', ' ');
                    b.b_qty = int.Parse(tbQty.Text);
                    b.b_copyright = int.Parse(tbCR.Text);
                    b.b_call_no = tbCN.Text;
                    b.b_acc_no = tbAN.Text;
                    b.b_isbn = tbISBN.Text;
                    b.bc_id = bc_id;
                    db.SaveChanges();
                }
                MessageBox.Show(this, "Book information successfully editted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                using (library_dbEntities db = new library_dbEntities())
                {
                    tbl_book_info b = new tbl_book_info
                    {
                        b_title = tbTitle.Text,
                        b_author = tbAuthor.Text,
                        b_publisher = tbPublisher.Text,
                        b_add_info = tbAddInfo.Text,
                        b_qty = int.Parse(tbQty.Text),
                        b_copyright = int.Parse(tbCR.Text),
                        b_call_no = tbCN.Text,
                        b_acc_no = tbAN.Text,
                        b_isbn = tbISBN.Text,
                        bc_id = bc_id
                    };
                    db.tbl_book_info.Add(b);
                    db.SaveChanges();
                }
                MessageBox.Show(this, "Book information successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
