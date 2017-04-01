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
    public partial class frmUserInfo : Form
    {
        int id;
        public frmUserInfo(int _id)
        {
            InitializeComponent();

            //cboRole.SelectedIndex = 0;
            id = _id;

            using ( library_dbEntities db = new library_dbEntities() )
            {
                tbl_user user = db.tbl_user.FirstOrDefault(u => u.u_id == id);

                lblID.Text = user.u_id.ToString();
                tbUsername.Text = user.un;
                tbPassword.Text = user.pw;
                tbFullname.Text = user.fn;
                //if (user.role == 1)
                //{
                //    cboRole.SelectedIndex =  1;
                //}
                //else
                //{
                //    cboRole.SelectedIndex = 0;
                //}
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (library_dbEntities db = new library_dbEntities())
            {
                tbl_user user = db.tbl_user.FirstOrDefault(u => u.u_id == id);

                user.un = tbUsername.Text.Trim();
                user.pw = tbPassword.Text.Trim();
                user.fn = tbFullname.Text.Trim();
                //user.role = cboRole.SelectedIndex;

                db.SaveChanges();
            }
            MessageBox.Show(this, "User information successfully editted","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
