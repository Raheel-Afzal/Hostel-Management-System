using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_in_C_Sharp
{
    public partial class ViewRecordStudent : Form
    {
        HMSEntities db = new HMSEntities();
        StudentInfo s = new StudentInfo();
        public ViewRecordStudent()
        {
            InitializeComponent();
        }
        private void ViewRecordStudent_Load(object sender, EventArgs e)
        {
            lblCancelAllotDate.Visible = false;
            dgvOldStudent.Visible = false;
            panelDetail.Visible = false;

            var students = db.StudentInfoes.Select(r => r);
            lblTotalStudents.Text = students.Count().ToString();

            ViewAllData();
        }
        private void btnViewAllStudents_Click(object sender, EventArgs e)
        {

            ViewAllData();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            panelDetail.Visible = false;
        }

       

        private void btnDetail_Click(object sender, EventArgs e)
        {

             lblCancelAllotDate.Visible = true;
            
            if(dgvOldStudent.Visible == true)
            {
                string Cnic = dgvOldStudent.CurrentRow.Cells[2].Value.ToString();

                OldStudent Oldstd = db.OldStudents.Where(s => s.cnic == Cnic).FirstOrDefault();

                DateTime zeroTime = new DateTime(1, 1, 1);
                DateTime AllotDate = Convert.ToDateTime(Oldstd.allot_date);
                DateTime OutDate = Convert.ToDateTime(Oldstd.checkout_date);

                TimeSpan t = OutDate.Subtract(AllotDate);


                int years = (zeroTime + t).Year - 1;
                int Months = (zeroTime + t).Month - 1;
                int Days = (zeroTime + t).Day - 1;

                string FeesStatus;

                if (Oldstd.fees_status == true)
                {
                    FeesStatus = "Cleared";
                }
                else
                {
                    FeesStatus = "Dues Pending";
                }

                lblName.Text = Oldstd.name;
                lblFatherName.Text = Oldstd.father_name;
                lblAge.Text = Oldstd.age.ToString();
                lblCnic.Text = Oldstd.cnic.ToString();
                lblResidential.Text = Oldstd.address_temp;
                lblRelationShip.Text = Oldstd.relationship;
                lblPhone_Home.Text = Oldstd.phone_home.ToString();
                lblMobile.Text = Oldstd.mobile.ToString();
                lblAddress_per.Text = Oldstd.address_per;
                lblMobile_Emr.Text = Oldstd.mobile_emr.ToString();
                lblAddress_Emr.Text = Oldstd.address_emr;
                lblAllotRoom.Text = Oldstd.roomno;
                lblFeesStatus.Text = FeesStatus;
                lblAllot_Date.Text = Oldstd.allot_date;
                lblCancelAllotDate.Text = "Cancel Allotment Date: " + Oldstd.checkout_date;

                if (years > 0)
                {
                    lblDuration.Text = years + " Years " + Months + " Months " + Days + " Days";
                }
                else if (Months > 0)
                {
                    lblDuration.Text = Months + " Months " + Days + " Days";

                }
                else
                    lblDuration.Text = Days + " Days";

            }
            else
            {
                string Cnic = dgvStudentDetails.CurrentRow.Cells[2].Value.ToString();

                StudentInfo std = db.StudentInfoes.Where(s => s.cnic == Cnic).FirstOrDefault();

                DateTime zeroTime = new DateTime(1, 1, 1);
                DateTime AllotDate = Convert.ToDateTime(std.allot_date);
                DateTime Today = Convert.ToDateTime(DateTime.Today.ToString("dd-MMM-yy"));

                TimeSpan t = Today.Subtract(AllotDate);


                int years = (zeroTime + t).Year - 1;
                int Months = (zeroTime + t).Month - 1;
                int Days = (zeroTime + t).Day - 1;





                /* DateTime duration1 = Convert.ToDateTime(std.allot_date);
                 double days = DateTime.Today.Subtract(duration1).TotalDays;
                 double months = days/30;
                 double RemainingDays = days % 30;

                 string T_Months = months.ToString().Split('.')[0];
                 string T_Days = RemainingDays.ToString().Split('.')[0];

     */

                string FeesStatus;
                if (std.fees_status == true)
                {
                    FeesStatus = "Paid";
                }
                else
                {
                    FeesStatus = "Pending";
                }
                lblName.Text = std.name;
                lblFatherName.Text = std.father_name;
                lblAge.Text = std.age.ToString();
                lblCnic.Text = std.cnic.ToString();
       //         lblResidential.Text = std.address_temp;
                lblRelationShip.Text = std.relationship;
            //    lblPhone_Home.Text = std.phone_home.ToString();
                lblMobile.Text = std.mobile.ToString();
                lblAddress_per.Text = std.address_per;
                lblMobile_Emr.Text = std.mobile_emr.ToString();
                lblAddress_Emr.Text = std.address_emr;
                lblAllotRoom.Text = std.roomno;
                lblFeesStatus.Text = FeesStatus;
                lblAllot_Date.Text = std.allot_date;

                if (years > 0)
                {
                    lblDuration.Text = years + " Years " + Months + " Months " + Days + " Days";
                }
                else if (Months > 0)
                {
                    lblDuration.Text = Months + " Months " + Days + " Days";

                }
                else
                    lblDuration.Text = Days + " Days";

            }

            panelDetail.Visible = true;
        }

        private void ViewAllData()
        {
            string FeesStatus;


            dgvStudentDetails.Rows.Clear();

            var v = db.StudentInfoes.Select(s => s);


            foreach (var item in v)

            {


                if (item.fees_status == true)
                {
                    FeesStatus = "Paid";
                }
                else
                {
                    FeesStatus = "Pending";
                }
                dgvStudentDetails.Rows.Add(item.name, item.father_name, item.cnic,item.roomno, FeesStatus);
            }
        }
       

        private void btnViewOld_Click(object sender, EventArgs e)
        {
            dgvOldStudent.Visible = true;
            lblCancelAllotDate.Visible = false;

            var v = db.OldStudents.Select(s => s);


            foreach (var item in v)
            {

                dgvOldStudent.Rows.Add(item.name, item.father_name, item.cnic, item.allot_date, item.checkout_date);
            }
        }
    }

   
}
