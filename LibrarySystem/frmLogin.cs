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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            focusOnOff((TextBox)sender, true);
        }
        private void focusOnOff(TextBox tb, Boolean focus) {
            if (focus == true)
            {
                if (tb.Text == "Username" || tb.Text == "Password")
                {
                    tb.Text = "";
                    tb.ForeColor = Color.DimGray;
                }
            }
            else
            {
                if (tb.Text == "")
                {
                    tb.ForeColor = Color.Gainsboro;
                    tb.Text = tb.Tag.ToString();
                }
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            focusOnOff((TextBox)sender, false);
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            focusOnOff((TextBox)sender, false);
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            focusOnOff((TextBox)sender, true);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using(library_dbEntities db = new library_dbEntities())
            {
                tbl_user user = db.tbl_user.FirstOrDefault(u => u.un == tbUsername.Text &&  u.pw == tbPassword.Text);
                if(user == null){
                    MessageBox.Show(this,"Invalid username or password","Invalid",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                
                frmMain frm = new frmMain(user.u_id, user.fn, user.role, this);
                frm.Show();
                tbUsername.Text = "Username";
                tbPassword.Text = "Password";
                this.Hide();
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
