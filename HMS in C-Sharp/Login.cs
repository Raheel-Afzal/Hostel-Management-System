using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna;
using Business_Layer;

namespace HMS_in_C_Sharp
{
    public partial class Login : Form
    {
        HMSEntities db = new HMSEntities();
        public Login()
        {
            InitializeComponent();

            
        }
        private void lblForgetPass_Click_1(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelReset.Visible = true;
        }
        private void lblLogin_Click(object sender, EventArgs e)
        {
            panelReset.Visible = false;
            panelLogin.Visible = true;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            UserInfo ui = db.UserInfoes.Where(s => s.username == tbUserName.Text && s.password == tbPassword.Text).FirstOrDefault();

            if (ui != default)
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Password or UserName is Incorrect. Try Again !!!", "Not Found", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            UserInfo ui = db.UserInfoes.Where(s => s.username == tbResetUserName.Text ).FirstOrDefault();

            if (ui != default)
            {
                if (tbConfirmPassword.Text.Equals(tbResetPassword.Text))
                {
                    ui.password = tbResetPassword.Text;
                    MessageBox.Show("Password Changes Sucessfully..!!!");

                    panelReset.Visible = false;
                    panelLogin.Visible = true;
                }
                else
                    MessageBox.Show("Password does not matched !!!", "Not Matched", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

            }


        }

       
    }

       
}

