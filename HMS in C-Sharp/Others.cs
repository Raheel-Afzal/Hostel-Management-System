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
    public partial class Others : Form
    {
        HMSEntities db = new HMSEntities();
        DateTime ThisMonth = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-01"));


        public Others()
        {
            InitializeComponent();
        }

        private void Others_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Regex chk = new Regex(@"^\d*$");

            if (cbCategory.SelectedIndex == -1 || tbAmount.Text == string.Empty || !chk.IsMatch(tbAmount.Text) )
            {
                MessageBox.Show("Values Are not Correct");
            }
            else
            {
                for (int i = 0; i < dgvExpense.Rows.Count; i++)
                {
                    if (dgvExpense[0, i].Value.ToString() == cbCategory.SelectedItem.ToString())
                    {
                        MessageBox.Show("Value Can't be Added to DataGridView. \n To Update Value Click on Edit.\n To Delete Value Click on Delete", "Already Exists.");
                        return;
                    }




                }
                dgvExpense.Rows.Add(cbCategory.SelectedItem.ToString(), tbAmount.Text);

                cbCategory.StartIndex = -1;
                tbAmount.Text = null;
            }
            
           
        }

        private void dgvExpense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 3)
            {
                
                dgvExpense.Rows.RemoveAt(e.RowIndex);
            }
            if(e.ColumnIndex == 2)
            {
                btnUpdate.Visible = true;
                cbCategory.Enabled = false; 
                string Category = dgvExpense.CurrentRow.Cells[0].Value.ToString();
                string Amount = dgvExpense.CurrentRow.Cells[1].Value.ToString();
                cbCategory.SelectedItem = Category;
                
                tbAmount.Text = Amount;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            if (tbAmount.Text == string.Empty )
            {
                MessageBox.Show("Values are null Or maybe not in correct format");
            }
            else
            {
                for (int i = 0; i < dgvExpense.Rows.Count; i++)
                {
                    if (dgvExpense[0, i].Value.ToString() == cbCategory.SelectedItem.ToString())
                    {
                        dgvExpense[1, i].Value = tbAmount.Text;
                    }
                }

            }

            cbCategory.Enabled = true;
            cbCategory.StartIndex = -1;
            tbAmount.Text = null;
            btnUpdate.Visible = false;
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            DialogResult dr=MessageBox.Show("Save Data?","Comfirm?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                SaveData();
            }
            dgvExpense.Rows.Clear();
        }
        private void SaveData()
        {
            
            EarningReport er = db.EarningReports.Where(s => s.Month == ThisMonth).FirstOrDefault();
            EarningReport NewRep = new EarningReport();

            for (int i = 0; i < dgvExpense.Rows.Count; i++)
            {
                string Category = dgvExpense[0, i].Value.ToString();
                
                if (Category == "Mess")
                {
                    if(er != default)
                    {
                        er.Mess = dgvExpense[1, i].Value.ToString();
                    }
                    else
                    {
                        NewRep.Mess = dgvExpense[1, i].Value.ToString();
                    }
                }
                if (Category == "Internet")
                {
                    if (er != default)
                    {
                        er.Internet = dgvExpense[1, i].Value.ToString();
                    }
                    else
                    {
                        NewRep.Internet = dgvExpense[1, i].Value.ToString();
                    }
                }
                if (Category == "Gass")
                {
                    if (er != default)
                    {
                        er.Gas = dgvExpense[1, i].Value.ToString();
                    }
                    else
                    {
                        NewRep.Gas = dgvExpense[1, i].Value.ToString();
                    }
                }
                if (Category == "Electricity")
                {
                    if (er != default)
                    {
                        er.Electricity = dgvExpense[1, i].Value.ToString();
                    }
                    else
                    {
                        NewRep.Electricity = dgvExpense[1, i].Value.ToString();
                    }
                }
            }

            db.EarningReports.Add(NewRep);
            db.SaveChanges();
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            Regex chk = new Regex(@"^\d*$");

            if (!chk.IsMatch(tbAmount.Text))
            {
                errorProvider1.SetError(tbAmount, "Amount Can Only in Digits.\n E.g ' 12345 '");
                
            }

            else
            {
                errorProvider1.SetError(tbAmount, "");

            }
        }
    }
    
}
