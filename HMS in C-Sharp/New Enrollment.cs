using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using System.Text.RegularExpressions;



namespace HMS_in_C_Sharp
{
    public partial class New_Enrollment : Form
    {

        HMSEntities db = new HMSEntities();
       
        public New_Enrollment()
        {
            InitializeComponent();
        }
  
        private void New_Enrollment_Load(object sender, EventArgs e)
        {
            SetCbRoomType();
            lblAllocationDate.Text = DateTime.Today.ToShortDateString();
            tbDOB.Text = DateTime.Today.ToShortDateString();
            tbName.Focus();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" && tbFatherName.Text == "" && tbDOB.Text == "" && tbCnic.Text == "" && tbResidential.Text == "" && tbMobile.Text == ""  && tbMobile_Emr.Text == "" && tbAddress_Emr.Text == "")
            {

                MessageBox.Show("Please Check All the Fields First", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {

                StudentInfo s = new StudentInfo();
                s.name = tbName.Text;
                s.father_name = tbFatherName.Text;
                s.address_per = tbResidential.Text;
                s.age = int.Parse((DateTime.Today.Year - datepickerDOB.Value.Year).ToString());
                s.mobile = tbMobile.Text;
                s.cnic = tbCnic.Text;
                s.name_emr = tbName_emr.Text;
                s.relationship = cbRelationShip_Emr.SelectedItem.ToString();
                s.mobile_emr = tbMobile_Emr.Text;
                s.address_emr = tbAddress_Emr.Text;
                s.allot_date = DateTime.Today.ToShortDateString();
                s.roomno = AllotRoom.RoomNo;
                s.admission_fees = tbAdmissionFee.Text;
                s.fees = tbFeesPaid.Text;
                s.default_dues = lblRemaingDues.Text;

                if (lblRemaingDues.Text == "0")
                {
                    s.fees_status = true;
                }
                else
                {
                    s.fees_status = false;
                }

                Room r = db.Rooms.Where(v => v.roomno == AllotRoom.RoomNo).FirstOrDefault();
                r.available--;
                db.StudentInfoes.Add(s);
                db.SaveChanges();

                MessageBox.Show("Student Enrolled !!!", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }
        private void datepickerDOB_onValueChanged_1(object sender, EventArgs e)
        {
            tbDOB.Text = datepickerDOB.Value.ToShortDateString();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //-------------------------------------------------------Allot Room-----------------------------------------------------------//
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Allot Room
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //btnConfirmAlloment.Enabled = true;
            string SelectedAllotRoom = "";
            string SelectedRoomType = "";
            string RoomFees = "";
            if (dgvRoomDetails.Rows.Count != 0)
            {
                SelectedAllotRoom = dgvRoomDetails.CurrentRow.Cells[0].Value.ToString();
                SelectedRoomType = dgvRoomDetails.CurrentRow.Cells[2].Value.ToString();
                RoomFees = dgvRoomDetails.CurrentRow.Cells[3].Value.ToString();
            }
            else
                MessageBox.Show("Click on Search Button First to View Available Rooms !!!", "Not Proceed", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            DialogResult dr = MessageBox.Show("Confirm Room Detail. \n \n  \n Room No : " + SelectedAllotRoom + " \n Room Type : " + SelectedRoomType + "\n Fees : " + RoomFees, "Review Detail", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                lblAllotRoom.Text = SelectedAllotRoom;
                lblRoomType.Text = SelectedRoomType;
                lblFees.Text = RoomFees;
                lblRoomFees.Text = RoomFees;

                AllotRoom.RoomNo = SelectedAllotRoom;
                AllotRoom.RoomType = SelectedRoomType;
                AllotRoom.Fees = RoomFees;



            }
            else
                MessageBox.Show("Room Not Selected", "Not Proceed", MessageBoxButtons.OK, MessageBoxIcon.Warning);



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SelectedRoomType = cbRoomType.SelectedItem.ToString();
            string SRB = cbBedRequired.SelectedItem.ToString();
            int SelectedBedRequired = int.Parse(SRB.Split(' ')[0]);
            dgvRoomDetails.Rows.Clear();

            var collection2 = db.Rooms.Select(s => s);
            var collection = db.Rooms.Where(s => s.available >= SelectedBedRequired && s.type == SelectedRoomType).Select(s => s);
            foreach (var item in collection)
            {
                dgvRoomDetails.Rows.Add(item.roomno, item.floor, item.type, item.fees, item.available);
            }

            if (dgvRoomDetails.Rows.Count == 0)
            {
                MessageBox.Show("No Rooms Are Available");
            }
        }

        private void cbBedRequired_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SRT = cbRoomType.SelectedItem.ToString();
            int SelectedRoomType = int.Parse(SRT.Split(' ')[0]);

            string SRB = cbBedRequired.SelectedItem.ToString();
            int SelectedBedRequired = int.Parse(SRB.Split(' ')[0]);

            if (SelectedBedRequired > SelectedRoomType)
            {
                MessageBox.Show("For " + SelectedBedRequired + " Bed You need to Choose Different Room Type !!!", "Change Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        private void SetCbRoomType()
        {
            var res = db.Rooms.Select(s => s.type).Distinct();
            foreach (var item in res)
            {
                cbRoomType.Items.Add(item);
            }
        }
        private void tbAdmissionFee_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void tbFeesPaid_TextChanged(object sender, EventArgs e)
        {

            if (tbFeesPaid.Text != string.Empty)
                lblRemaingDues.Text = (int.Parse(lblRoomFees.Text) - int.Parse(tbFeesPaid.Text)).ToString();
            else
                tbFeesPaid.Text = "0";

        }
        #endregion

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //-------------------------------------------------------Validation-----------------------------------------------------------//
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Validation
        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            ValidateName(tbName);
        }

        public void ValidateName(TextBox tb)
        {
            if (tb.Text == String.Empty)
            {

                errorProvider1.SetError(tb, "Please Enter Name");
                errorProvider2.SetError(tb, "");



            }
            else
            {
                Regex chkName = new Regex(@"^[a-zA-Z\s]+$");




                if (!chkName.IsMatch(tb.Text))
                {
                    errorProvider1.SetError(tb, "");
                    errorProvider2.SetError(tb, "Name Can Only Contains Characters \n E.g Raheel Afzal");
                }

                else
                {
                    errorProvider1.SetError(tb, "");
                    errorProvider2.SetError(tb, "");

                }
            }
        }
        private void ValidateCnic(TextBox tb)
        {
            if (tb.Text == String.Empty)
            {

                errorProvider1.SetError(tb, "Please Enter Cnic");
                errorProvider2.SetError(tb, "");



            }
            else
            {
                //string pattern = @"(^\d{5}-\d{7}-\d{1})$";
                //Match m = Regex.Match(tb.Text, pattern);
                //if(!m.Success)

                Regex chkCnic = new Regex(@"^\d{5}-\d{7}-\d{1}$");

                if (!chkCnic.IsMatch(tb.Text))

                {
                    errorProvider1.SetError(tb, "");
                    errorProvider2.SetError(tb, "Cnic Format is Incorrect \n For Example '12345-1234567-1' \nCnic Must have 13-digits with hyphens");
                }
                else
                {
                    errorProvider1.SetError(tb, "");
                    errorProvider2.SetError(tb, "");

                }


            }
        }

        private void tbFatherName_Validating(object sender, CancelEventArgs e)
        {
            ValidateName(tbFatherName);
        }

        private void datepickerDOB_onValueChanged(object sender, EventArgs e)
        {
            tbDOB.Text = datepickerDOB.Value.ToString("dd-MMMM-yyyy");
        }

        private void tbCnic_Validating(object sender, CancelEventArgs e)
        {
            ValidateCnic(tbCnic);
        }

        private void tbCnic_KeyDown(object sender, KeyEventArgs e)
        {

            string sVal = tbCnic.Text;
            string newst;
            if (!string.IsNullOrEmpty(sVal) && e.KeyCode != Keys.Back)
            {

                if (tbCnic.Text.Length == 5)
                {
                    newst = Regex.Replace(sVal, ".{5}", "$0-");
                    tbCnic.Text = newst;
                }
                if (tbCnic.Text.Length == 13)
                {
                    newst = Regex.Replace(sVal, ".{13}", "$0-");
                    tbCnic.Text = newst;
                }

                tbCnic.SelectionStart = tbCnic.Text.Length;
            }

        }

        private void tbMobile_KeyDown(object sender, KeyEventArgs e)
        {

            string sVal = tbMobile.Text;
            string newst;
            if (!string.IsNullOrEmpty(sVal) && e.KeyCode != Keys.Back)
            {

                if (tbMobile.Text.Length == 4)
                {
                    newst = Regex.Replace(sVal, ".{4}", "$0-");
                    tbMobile.Text = newst;
                }


                tbMobile.SelectionStart = tbMobile.Text.Length;
            }
        }



        private void tbMobile_Emr_KeyDown(object sender, KeyEventArgs e)
        {
            string sVal = tbMobile_Emr.Text;
            string newst;
            if (!string.IsNullOrEmpty(sVal) && e.KeyCode != Keys.Back)
            {

                if (tbMobile_Emr.Text.Length == 4)
                {
                    newst = Regex.Replace(sVal, ".{4}", "$0-");
                    tbMobile_Emr.Text = newst;
                }


                tbMobile_Emr.SelectionStart = tbMobile.Text.Length;
            }
        }


        #endregion

       
    }
}
