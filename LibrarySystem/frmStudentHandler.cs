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
    public partial class frmStudentHandler : Form
    {
        string ID = "";

        public frmStudentHandler()
        {
            InitializeComponent();
            tbIDNumber.ReadOnly = false;
            lblTitle.Text = "Add Student Information";

            using (library_dbEntities db = new library_dbEntities())
            {
                var sec = from s in db.tbl_sec
                          where s.sec_active == 1
                          select s;
                cboSection.DataSource = sec.ToList();
                cboSection.DisplayMember = "sec_details";
                cboSection.ValueMember = "sec_id";

                var yr = from y in db.tbl_yr
                         where y.yr_active == 1
                         select y;
                cboGrade.DataSource = yr.ToList();
                cboGrade.DisplayMember = "yr_details";
                cboGrade.ValueMember = "yr_id";
            }

        }

        public frmStudentHandler(string _ID)
        {
            InitializeComponent();
            this.ID = _ID;
            tbIDNumber.Text = _ID;
            tbIDNumber.ReadOnly = true;
            lblTitle.Text = "Edit Student Information";

            using (library_dbEntities db = new library_dbEntities())
            {
                var sec = from s in db.tbl_sec
                          where s.sec_active == 1
                          select s;
                cboSection.DataSource = sec.ToList();
                cboSection.DisplayMember = "sec_details";
                cboSection.ValueMember = "sec_id";

                var yr = from y in db.tbl_yr
                         where y.yr_active == 1
                         select y;
                cboGrade.DataSource = yr.ToList();
                cboGrade.DisplayMember = "yr_details";
                cboGrade.ValueMember = "yr_id";
            }

            using( library_dbEntities db = new library_dbEntities() )
            {
                tbl_student_info stud = db.tbl_student_info.FirstOrDefault(s => s.stud_id_number == _ID);


                tbFn.Text = stud.stud_fn;
                tbMn.Text = stud.stud_mn;
                tbLn.Text = stud.stud_ln;
                cboGrade.SelectedValue = stud.yr_id;
                cboSection.SelectedValue = stud.sec_id;

                if (stud.rfid_id != null)
                {
                    int rfid = int.Parse(stud.rfid_id);
                    tbl_rfid_tag tag = db.tbl_rfid_tag.FirstOrDefault(t => t.rfid_id == rfid);
                    lblRFID.Text = tag.rfid_tag_id;
                }
            }

        }

        private void frmStudentHandler_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ID == "") //Add
            {
                using (library_dbEntities db = new library_dbEntities())
                {
                    int sec = int.Parse( cboSection.SelectedValue.ToString());
                    int grd = int.Parse( cboGrade.SelectedValue.ToString());
                    tbl_student_info stud = new tbl_student_info 
                    { 
                        stud_id_number = tbIDNumber.Text,
                        stud_fn = tbFn.Text,
                        stud_mn = tbMn.Text,
                        stud_ln = tbLn.Text,
                        stud_active = 1,
                        stud_parent_number = "",
                        sec_id = sec,
                        yr_id = grd

                    };
                    db.tbl_student_info.Add(stud);
                    db.SaveChanges();
                }
                MessageBox.Show(this, "Student information was successfully added.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                using (library_dbEntities db = new library_dbEntities())
                {
                    int sec = int.Parse(cboSection.SelectedValue.ToString());
                    int grd = int.Parse(cboGrade.SelectedValue.ToString());
                    tbl_student_info stud = db.tbl_student_info.FirstOrDefault(s => s.stud_id_number == ID);

                    stud.stud_id_number = tbIDNumber.Text;
                    stud.stud_fn = tbFn.Text;
                    stud.stud_mn = tbMn.Text;
                    stud.stud_ln = tbLn.Text;
                    stud.stud_active = 1;
                    stud.stud_parent_number = "";
                    stud.sec_id = sec;
                    stud.yr_id = grd;
                    db.SaveChanges();
                }
                MessageBox.Show(this, "Student information was successfully editted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
