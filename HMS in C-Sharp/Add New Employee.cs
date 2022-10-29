using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace HMS_in_C_Sharp
{
    public partial class Add_New_Employee : Form
    {
        HMSEntities db = new HMSEntities();
        Employee emp = new Employee();
        public Add_New_Employee()
        {
            InitializeComponent();
        }

        private void AddNewJob_Click(object sender, EventArgs e)
        {
           
            Add_Job a = new Add_Job()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            a.ShowDialog();

        }

        private void Add_New_Employee_Load(object sender, EventArgs e)
        {
            picDelete.Visible = false;
            picEdit.Visible = false;

            SetCbRole();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            emp.Name = tbName.Text;
            emp.FatherName = tbFatherName.Text;
            emp.Age = int.Parse((DateTime.Today.Year - datepickerDOB.Value.Year).ToString());
            emp.Cnic = tbCnic.Text;
            emp.Address = tbResidential.Text;
            emp.Mobile = Convert.ToInt64(tbMobile.Text);
            emp.tittle = cbRole.SelectedItem.ToString();
            emp.SalaryStatus = false;
            emp.Allot_Date = DateTime.Today.ToString("dd-MMM-yy");

            db.Employees.Add(emp);
            db.SaveChanges();
        }

        private void cbRole_Click(object sender, EventArgs e)
        {
            SetCbRole();
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            picDelete.Visible = true;
            picEdit.Visible = true;
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            string Tittle = cbRole.SelectedItem.ToString();

            if (MessageBox.Show("Are You Sure You Want to Remove "+ Tittle + " \n All Person Who are "+Tittle+" will be Removed..!!!", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Job job = db.Jobs.Where(j => j.tittle == Tittle).FirstOrDefault();

                var res = db.Employees.Where(emp => emp.tittle == Tittle).Select(emp => emp);
                foreach (var item in res)
                {
                    db.Employees.Remove(item);
                }

                db.Jobs.Remove(job);
                db.SaveChanges();
            }

            SetCbRole();
            cbRole.Text = " -- Select Role --";

            picDelete.Visible = false;
            picEdit.Visible = false;

        }
        private void SetCbRole()
        {
            cbRole.Items.Clear();
            var res = db.Jobs.Select(s => s.tittle);

            foreach (var item in res)
            {
                cbRole.Items.Add(item);
            }
        }

        private void picEdit_Click(object sender, EventArgs e)
        {
            

            string Tittle = cbRole.SelectedItem.ToString();

            Add_Job aj = new Add_Job(Tittle)
            {
                StartPosition = FormStartPosition.CenterParent,
            };
            aj.ShowDialog();

           

            


        }

        private void tbCnic_Validating(object sender, CancelEventArgs e)
        {
            ValidateCnic(tbCnic);
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
    }
}
