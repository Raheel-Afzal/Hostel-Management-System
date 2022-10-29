using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HMS_in_C_Sharp
{
    public partial class Fees : Form
    {
        HMSEntities db = new HMSEntities();
        StudentInfo StdInfo = new StudentInfo();

        DateTime ThisMonth = Convert.ToDateTime(DateTime.Now.ToString("01-MM-yyyy"));

        public Fees()
        {
            InitializeComponent();
        }

        private void Fees_Load(object sender, EventArgs e)
        {
            panelClearDues.Hide();
            btnPay.Visible = false;
            btnCancelEnrollment.Visible = false;

            lblMonth.Text = ThisMonth.ToString();
           
            ShowAllData();
            Report();
            








        }
       
        private void cbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFees.Rows.Clear();

            if (cbSortBy.SelectedIndex == 0)
            {

                ShowAllData();
            }

            if (cbSortBy.SelectedIndex == 1)
            {

                FilterData(true);

            }
            if (cbSortBy.SelectedIndex == 2)
            {
                btnPay.Visible = true;
                btnCancelEnrollment.Visible = true;

                FilterData(false);

            }
            else
            {
                btnPay.Visible = false;
                btnCancelEnrollment.Visible = false;
            }






        }


        private void btnPay_Click(object sender, EventArgs e)
        {

            
            panelClearDues.Show();

            string name = dgvFees.CurrentRow.Cells[0].Value.ToString();
            string fname = dgvFees.CurrentRow.Cells[1].Value.ToString();
            string AllotRoom = dgvFees.CurrentRow.Cells[3].Value.ToString();
            string DefaultDues = dgvFees.CurrentRow.Cells[6].Value.ToString();

            
            lblName.Text = name;
            lblFatherName.Text = fname;
            lblAllotRoom.Text = AllotRoom;
            lblDefaultDues.Text = DefaultDues;



        }
        private void tbSubmitDues_TextChanged(object sender, EventArgs e)
        {
            int  DefaultDues = int.Parse(dgvFees.CurrentRow.Cells[6].Value.ToString());

            if (tbSubmitDues.Text != string.Empty)
            {
                lblDefaultDues.Text =  (DefaultDues - int.Parse(tbSubmitDues.Text)).ToString();
            }
            else
                tbSubmitDues.Text = "0";
            
        }
        private void btnPayDues_Click(object sender, EventArgs e)
        {
            StdInfo = db.StudentInfoes.Where(s => s.name == lblName.Text && s.father_name == lblFatherName.Text).FirstOrDefault();
            StdInfo.default_dues = lblDefaultDues.Text;
            if(lblDefaultDues.Text == "0")
            {
                StdInfo.fees_status = true;
                StdInfo.fees = tbSubmitDues.Text;
            }

            db.SaveChanges();

            dgvFees.Rows.Clear();
            FilterData(false);

            Report();
            tbSubmitDues.Text = "0";
            panelClearDues.Hide();
        }
        private void ShowAllData()
        {


            var sdt = db.StudentInfoes.Select(s => s);

            foreach (var item in sdt)
            {
                string FeesStatus;

                if (item.fees_status == true)
                {
                    FeesStatus = "Paid";
                }
                else
                {
                    FeesStatus = "Pending";
                }
                dgvFees.Rows.Add(item.name, item.father_name, item.cnic,item.roomno,item.admission_fees, item.Room.fees,item.default_dues,FeesStatus);
            }

        }
        private void FilterData(bool value)
        {
            var sdt = db.StudentInfoes.Where(s => s.fees_status == value).Select(s => s);

            foreach (var item in sdt)
            {
                string FeesStatus;

                if (item.fees_status == true)
                {
                    FeesStatus = "Paid";
                }
                else
                {
                    FeesStatus = "Pending";
                }

                dgvFees.Rows.Add(item.name, item.father_name, item.cnic, item.roomno, item.admission_fees,item.Room.fees, item.default_dues, FeesStatus);
            }
        }

        private void Report()
        {
            var Report = db.EarningReports.Select(s => s).ToList();

            var res = db.StudentInfoes.Where(s => s.fees_status == true).Select(s => s);

            int TotalFees = 0;

            foreach (var item in res)
            {
                TotalFees += Convert.ToInt32(item.Room.fees);
            }

            for (int i = 0; i < Report.Count(); i++)
            {
                if (Report[i].Month == ThisMonth)
                {
                    Report[i].Fees = TotalFees.ToString();
                    db.SaveChanges();

                    EarningReport rep1 = db.EarningReports.Where(s => s.Month == ThisMonth).FirstOrDefault();
                    lblEarnig.Text = rep1.Fees;
                    return;
                }

            }
            EarningReport er = new EarningReport();

            er.Month = Convert.ToDateTime(DateTime.Now.ToString("01-MM-yyyy"));
            er.Fees = TotalFees.ToString();
            db.EarningReports.Add(er);
            db.SaveChanges();

            EarningReport rep = db.EarningReports.Where(s => s.Month == ThisMonth).FirstOrDefault();
            if (rep != default)
            {
                lblEarnig.Text = rep.Fees;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelClearDues.Hide();

        }

        private void btnFeesReset_Click(object sender, EventArgs e)
        {

            var stdList = db.StudentInfoes.Select(s => s).ToList();
            for (int i = 0; i < stdList.Count(); i++)
            {
                
                int defaultDues = int.Parse(stdList[i].default_dues);
                int roomFees = int.Parse(stdList[i].Room.fees.ToString());
                int newDefaultDues = defaultDues + roomFees;

                
                stdList[i].default_dues = newDefaultDues.ToString();
                stdList[i].fees = "0";
                stdList[i].fees_status = false;
                db.SaveChanges();
            }
            dgvFees.Rows.Clear();
            ShowAllData();
        }
    }
}


