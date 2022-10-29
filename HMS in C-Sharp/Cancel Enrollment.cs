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
    public partial class Cancel_Enrollment : Form
    {
        HMSEntities db = new  HMSEntities();
        StudentInfo std = new StudentInfo();
        
        public Cancel_Enrollment()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnCancelEnrollment_Click(object sender, EventArgs e)
        {
            string Fees = dgvStudentDetails.CurrentRow.Cells[4].Value.ToString();
            string Cnic = dgvStudentDetails.CurrentRow.Cells[2].Value.ToString();

            std = db.StudentInfoes.Where(s => s.cnic == Cnic).FirstOrDefault(); // All data of student which is selected


            

          /*  DateTime duration1 = Convert.ToDateTime(std.allot_date);
            double days = DateTime.Today.Subtract(duration1).TotalDays;
            double months = days / 30;
            double RemainingDays = days % 30;

            string T_Months = months.ToString().Split('.')[0];
            string T_Days = RemainingDays.ToString().Split('.')[0];

            string duration = T_Months + " Months " + T_Days + " Days"; */   // student leave krny k bd duration count ho gi

            if (Fees == "Pending")
            {
                MessageBox.Show("Clear the Dues Before Cancel Enrollment...", "Fees Are Pending", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {

                std = db.StudentInfoes.Where(s => s.cnic == Cnic).FirstOrDefault();


                db.OldStudents.Add(MoveData());   // yahan sy dusry table my data jy ga
           
                db.StudentInfoes.Remove(std);
                db.SaveChanges();

                string room = dgvStudentDetails.CurrentRow.Cells[3].Value.ToString();

                Room r = db.Rooms.Where(s => s.roomno == room).FirstOrDefault();
                r.available++;
                db.SaveChanges();
                dgvStudentDetails.Rows.Clear();
                ShowData();
            }
        }
        private void ShowData()
        {
            string Name = tbName.Text;
            string AllotRoom = tbAllotRoom.Text;
            string FeesStatus;

            dgvStudentDetails.Rows.Clear();




            var v = db.StudentInfoes.Where(s => s.name == Name || s.roomno == AllotRoom).Select(s => s);

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
                dgvStudentDetails.Rows.Add(item.name, item.father_name, item.cnic, item.roomno, FeesStatus);
            }
        }
        private OldStudent MoveData()
        {
            OldStudent old = new OldStudent();
            old.name = std.name;
            old.father_name = std.father_name;
            old.age=std.age;
            old.cnic=std.cnic;
       //     old.address_temp=std.address_temp;
       //     old.phone_home=Convert.ToInt64(std.phone_home);
            old.mobile= std.mobile;
            old.address_per=std.address_per;
            old.relationship=std.relationship;
            old.mobile_emr= std.mobile_emr;
            old.address_emr=std.address_emr;
            old.roomno=std.roomno;
            old.allot_date=std.allot_date;
            old.checkout_date = DateTime.Today.ToShortDateString();
            old.fees_status=std.fees_status;
            
            return old;
        }
        
    }
}
