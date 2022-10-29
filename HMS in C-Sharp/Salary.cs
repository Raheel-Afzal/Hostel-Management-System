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
    public partial class Salary : Form
    {
        HMSEntities db = new HMSEntities();
        Employee emp = new Employee();

        DateTime ThisMonth = Convert.ToDateTime(DateTime.Now.ToString("01-MM-yyyy"));
        public Salary()
        {
            InitializeComponent();
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            btnPay.Visible = false;

            lblMonth.Text = ThisMonth.ToString();
            ShowAllData();

            Report();
        }
      

        private void cbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSalary.Rows.Clear();

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


                FilterData(false);

            }
            else
            {
                btnPay.Visible = false;

            }
        }
        private void FilterData(bool value)
        {
            var res = db.Employees.Where(s => s.SalaryStatus == value).Select(s => s);

            foreach (var item in res)
            {

                string SalaryStatus;

                if (item.SalaryStatus == true)
                {
                    SalaryStatus = "Paid";
                }
                else
                {
                    SalaryStatus = "Pending";
                }

                dgvSalary.Rows.Add(item.Name, item.FatherName, item.tittle, item.Job.pay, SalaryStatus);
            }
        }
        private void ShowAllData()
        {


            var sdt = db.Employees.Select(s => s);

            foreach (var item in sdt)
            {
                string SalaryStatus;

                if (item.SalaryStatus == true)
                {
                    SalaryStatus = "Paid";
                }
                else
                {
                    SalaryStatus = "Pending";
                }
                dgvSalary.Rows.Add(item.Name, item.FatherName, item.tittle, item.Job.pay, SalaryStatus);
            }

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string name = dgvSalary.CurrentRow.Cells[0].Value.ToString();
            string fname = dgvSalary.CurrentRow.Cells[1].Value.ToString();

            emp = db.Employees.Where(s => s.Name == name && s.FatherName == fname).FirstOrDefault();
            emp.SalaryStatus = true;
            db.SaveChanges();

            dgvSalary.Rows.Clear();
            FilterData(false);

            Report();
        }
        private void Report()
        {
            var Report = db.EarningReports.Select(s => s).ToList();

            var res = db.Employees.Where(s => s.SalaryStatus == true).Select(s => s);

            int TotalSalaryPaid = 0;

            foreach (var item in res)
            {
                TotalSalaryPaid += Convert.ToInt32(item.Job.pay);
            }

            for (int i = 0; i < Report.Count(); i++)
            {
                if (Report[i].Month == ThisMonth)
                {
                    Report[i].SalaryPaid = TotalSalaryPaid.ToString();
                    db.SaveChanges();

                    EarningReport rep1 = db.EarningReports.Where(s => s.Month == ThisMonth).FirstOrDefault();
                    lblSalary.Text = rep1.SalaryPaid;
                    return;
                }

            }
            EarningReport er = new EarningReport();

            er.Month = Convert.ToDateTime(DateTime.Now.ToString("01-MM-yyyy"));
            er.SalaryPaid = TotalSalaryPaid.ToString();
            db.EarningReports.Add(er);
            db.SaveChanges();

            EarningReport rep = db.EarningReports.Where(s => s.Month == ThisMonth).FirstOrDefault();
            if(rep != default)
            {
                lblSalary.Text = rep.SalaryPaid;
            }
            
        }
    }

}

