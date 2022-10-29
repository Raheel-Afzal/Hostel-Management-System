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
    public partial class Add_Job : Form
    {
        HMSEntities db = new HMSEntities();
        Job job = new Job();
        string tittle;
        public Add_Job(string tittle)
        {
            InitializeComponent();
            this.tittle = tittle;

            Job job = db.Jobs.Where(j => j.tittle == tittle).FirstOrDefault();
            tbJobTittle.Text = job.tittle.ToString();
            tbPay.Text = job.pay.ToString();

            
        }
        public Add_Job()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
           
            job.tittle = tbJobTittle.Text;
            job.pay = Convert.ToInt64(tbPay.Text);
            db.Jobs.Add(job);
            db.SaveChanges();

            MessageBox.Show("Changes Saved");
            this.Close();


        }

        private void Add_Job_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            if (tittle != null)
            {
                lblHeader.Text = "Edit Job Details";
                btnSaveChange.Visible = false;
                btnUpdate.Visible = true;

               
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Job job = new Job();
            job.tittle = tbJobTittle.Text;
            job.pay = Convert.ToInt64(tbPay.Text);


            db.SaveChanges();

            MessageBox.Show("Update Save Change");
            this.Close();
        }
    }
}
