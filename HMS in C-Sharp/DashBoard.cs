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
    public partial class DashBoard : Form
    {
        HMSEntities db = new HMSEntities();
        DateTime ThisMonth = Convert.ToDateTime(DateTime.Now.ToString("01-MM-yyyy"));


        int ThisMonthBills = 0;
        int ThisMonthMess = 0;
        int ThisMonthFees = 0;
        int ThisMonthSalaryPaid = 0;

      


        public DashBoard()
        {
            InitializeComponent();
            
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            #region LoadData_inComboBox
            var List = db.EarningReports.Select(s => s.Month).ToList();
            List<string> Year = new List<string>();

            foreach (var item in List)
            {
                string year = (item.ToString().Split(' ')[0]);
    //            string splitdata = year.ToString().Split('/')[2];
            //    Year.Add(splitdata);
            }

            var DistinctYear = Year.Select(s => s).Distinct();

            foreach (var item in DistinctYear)
            {
                cbFromYear.Items.Add(item);
                cbToYear.Items.Add(item);
            }
            #endregion

            EarningReport ThisMonthRep = db.EarningReports.Where(s => s.Month == ThisMonth).FirstOrDefault();
            if (ThisMonthRep != default)
            {
                lblBills.Text = "Amount: " + (Convert.ToInt32(ThisMonthRep.Internet) + Convert.ToInt32(ThisMonthRep.Electricity) + Convert.ToInt32(ThisMonthRep.Gas)).ToString();
                lblMess.Text = "Amount: " + (Convert.ToInt32(ThisMonthRep.Mess)).ToString();
                lblFees.Text = "Amount: " + (Convert.ToInt32(ThisMonthRep.Fees)).ToString();
                lblSalary.Text = "Amount: " + (Convert.ToInt32(ThisMonthRep.SalaryPaid)).ToString();

                ThisMonthBills = Convert.ToInt32(lblBills.Text.Split(':')[1]);
                ThisMonthMess = Convert.ToInt32(lblMess.Text.Split(':')[1]);
                ThisMonthSalaryPaid = Convert.ToInt32(lblSalary.Text.Split(':')[1]);
                ThisMonthFees = Convert.ToInt32(lblFees.Text.Split(':')[1]);

                double Expenses = ThisMonthBills + ThisMonthMess + ThisMonthSalaryPaid;



                lblPendingFees.Text = db.StudentInfoes.Where(s => s.fees_status == false).Select(s => s).Count().ToString();
                lblPendingSalary.Text = db.Employees.Where(s => s.SalaryStatus == false).Select(s => s).Count().ToString();
                lblTotalStudents.Text = db.StudentInfoes.Count().ToString();
                lblTotalEmployees.Text = db.Employees.Count().ToString();
                //lblEarningThisMonth.Text = ThisMonth;



                lblNetEarning.Text = "Amount: " + (ThisMonthFees - Expenses).ToString();
                double NetEarning = Convert.ToInt32(lblNetEarning.Text.Split(':')[1]);



                chart1.Series["S1"].IsValueShownAsLabel = true;
                chart1.Series["S1"].Points.AddXY("Expenses", Expenses);
                chart1.Series["S1"].Points.AddXY("Profit", NetEarning);
                chart1.Series["S1"].Points.AddXY("Fees", ThisMonthFees);

            }

        }

       
      

        private void btnEarning_Click(object sender, EventArgs e)
        {
            
            
           
            
        }

       

        string FromPickedMonth = "";
        string FromPickedYear = "";
        

        string ToPickedMonth = "";
        string ToPickedYear = "";
        

        

       

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int t_Salary = 0, t_Bill = 0, t_Mess = 0, t_Fees = 0;

            DateTime FromMonth = Convert.ToDateTime("01-" + FromPickedMonth + "-" + FromPickedYear);
            DateTime ToMonth = Convert.ToDateTime("01-" + ToPickedMonth + "-" + ToPickedYear);

            groupBox1.Text = FromMonth.ToString("MMM-yyyy") + "  to  " + ToMonth.ToString("MMM-yyyy");

            var RangeDate = db.EarningReports.Where(s => s.Month >= FromMonth && s.Month <= ToMonth).ToList();

            foreach (var item in RangeDate)
            {

                t_Salary += Convert.ToInt32(item.SalaryPaid);
                t_Bill += Convert.ToInt32(item.Internet) + Convert.ToInt32(item.Mess) + Convert.ToInt32(item.Gas) + Convert.ToInt32(item.Electricity);
                t_Mess += Convert.ToInt32(item.Mess);
                t_Fees += Convert.ToInt32(item.Fees);

            }

            int t_NetEarning = t_Fees - (t_Salary + t_Bill + t_Mess) ;

            lblBills.Text = "Amount: " + t_Bill.ToString();
            lblMess.Text = "Amount: " + t_Mess.ToString();
            lblSalary.Text = "Amount: " + t_Salary.ToString();
            lblFees.Text = "Amount: " + t_Fees.ToString();
            lblNetEarning.Text = "Amount: " + t_NetEarning.ToString();


            chart1.Series["S1"].Points.Clear();
            chart1.Series["S1"].IsValueShownAsLabel = true;
            chart1.Series["S1"].Points.AddXY("Expenses", t_Salary + t_Bill + t_Mess);
            chart1.Series["S1"].Points.AddXY("Profit", t_NetEarning);
            chart1.Series["S1"].Points.AddXY("Fees", t_Fees);
        }

        private void cbFromMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            FromPickedMonth = cbFromMonth.Text;
        }

        private void cbFromYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            FromPickedYear = cbFromYear.SelectedItem.ToString();
        }

        private void cbToMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToPickedMonth = cbToMonth.SelectedItem.ToString();
        }

        private void cbToYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToPickedYear = cbToYear.SelectedItem.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
