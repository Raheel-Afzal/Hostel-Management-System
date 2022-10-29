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
    public partial class View_Employee_Record : Form
    {
        HMSEntities db = new HMSEntities();
        public View_Employee_Record()
        {
            InitializeComponent();
        }

        private void View_Employee_Record_Load(object sender, EventArgs e)
        {
            btnTerminate.Visible = false;
            panelDetail.Visible = false;

            var employees= db.Employees.Select(s => s);
            lblTotalEmployee.Text= employees.Count().ToString();
            ShowAllData();
            
        }
        private void ShowAllData()
        {
            var res = db.Employees.Select(s => s);
            foreach (var item in res)
            {
                dgvEmploymentDetails.Rows.Add(item.Name, item.FatherName, item.Cnic, item.tittle, item.Job.pay);
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            ShowData_in_Panel();

        }

        private void picBack_Click(object sender, EventArgs e)
        {
            panelDetail.Visible = false;
            btnTerminate.Visible = false;
        }
        private void PanelTerminate_Click(object sender, EventArgs e)
        {
            ShowData_in_Panel();
            btnTerminate.Visible = true;
        }
        private void btnTerminate_Click(object sender, EventArgs e)
        {
            string Cnic = lblCnic.Text;
            Employee emp = db.Employees.Where(s => s.Cnic == Cnic).FirstOrDefault();
            db.Employees.Remove(emp);
            db.SaveChanges();

            MessageBox.Show(lblName.Text + " Has Been Terminated.");

            panelDetail.Visible = false;

            dgvEmploymentDetails.Rows.Clear();
            ShowAllData();
        }

        private void ShowData_in_Panel()
        {
            string Cnic = dgvEmploymentDetails.CurrentRow.Cells[2].Value.ToString();

            Employee emp = db.Employees.Where(s => s.Cnic == Cnic).FirstOrDefault();

            DateTime duration1 = Convert.ToDateTime(emp.Allot_Date);
            double days = DateTime.Today.Subtract(duration1).TotalDays;
            double months = days / 30;
            double RemainingDays = days % 30;

            string T_Months = months.ToString().Split('.')[0];
            string T_Days = RemainingDays.ToString().Split('.')[0];



            string SalaryStatus;
            if (emp.SalaryStatus == true)
            {
                SalaryStatus = "Paid";
            }
            else
            {
                SalaryStatus = "Pending";
            }

            lblName.Text = emp.Name;
            lblFatherName.Text = emp.FatherName;
            lblAge.Text = emp.Age.ToString();
            lblCnic.Text = emp.Cnic.ToString();
            lblResidential.Text = emp.Address;
            lblMobile.Text = emp.Mobile.ToString();
            lblTittle.Text = emp.tittle;
            lblSalaryStatus.Text = SalaryStatus;
            lblAllot_Date.Text = emp.Allot_Date;
            lblDuration.Text = T_Months + " Months " + T_Days + " Days";
            lblSalary.Text = emp.Job.pay.ToString();

            panelDetail.Visible = true;
        }
        
    }
}
