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
    public partial class Menu : Form
    {
        HMSEntities db = new HMSEntities();
        MessMenu m = new MessMenu();
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            SetBackColor();        // disable color ko change kry ga
            SetMenu();                   // sb textbox k andr database sy value row by row assign ho gi

            DisableControls(this);       // sb controls disables ho jy gy

            EnableControls(btnUpdate);
        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                EnableControls(c);

            }
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateMenu();
            db.SaveChanges();

            SetMenu();

            DisableControls(this);
            EnableControls(btnUpdate);
        }

        #region Methods
        private void SetMenu()
        {
            SetMenu(textBox1, 1);
            SetMenu(textBox2, 2);
            SetMenu(textBox3, 3);
            SetMenu(textBox4, 4);
            SetMenu(textBox5, 5);
            SetMenu(textBox6, 6);
            SetMenu(textBox7, 7);
            SetMenu(textBox8, 8);
            SetMenu(textBox9, 9);
            SetMenu(textBox10, 10);
            SetMenu(textBox11, 11);
            SetMenu(textBox12, 12);
            SetMenu(textBox13, 13);
            SetMenu(textBox14, 14);
            SetMenu(textBox15, 15);
            SetMenu(textBox16, 16);
            SetMenu(textBox17, 17);
            SetMenu(textBox18, 18);
            SetMenu(textBox19, 19);
            SetMenu(textBox20, 20);
            SetMenu(textBox21, 21);
        }
        private void SetBackColor()
        {
            textBox1.BackColor = SystemColors.HighlightText;
            textBox2.BackColor = SystemColors.HighlightText;
            textBox3.BackColor = SystemColors.HighlightText;
            textBox4.BackColor = SystemColors.HighlightText;
            textBox5.BackColor = SystemColors.HighlightText;
            textBox6.BackColor = SystemColors.HighlightText;
            textBox7.BackColor = SystemColors.HighlightText;
            textBox8.BackColor = SystemColors.HighlightText;
            textBox9.BackColor = SystemColors.HighlightText;
            textBox10.BackColor = SystemColors.HighlightText;
            textBox11.BackColor = SystemColors.HighlightText;
            textBox12.BackColor = SystemColors.HighlightText;
            textBox13.BackColor = SystemColors.HighlightText;
            textBox14.BackColor = SystemColors.HighlightText;
            textBox15.BackColor = SystemColors.HighlightText;
            textBox16.BackColor = SystemColors.HighlightText;
            textBox17.BackColor = SystemColors.HighlightText;
            textBox18.BackColor = SystemColors.HighlightText;
            textBox19.BackColor = SystemColors.HighlightText;
            textBox20.BackColor = SystemColors.HighlightText;
            textBox21.BackColor = SystemColors.HighlightText;
        }
        private void SetMenu(TextBox t, int i)
        {
            m = db.MessMenus.Where(s => s.id == i).FirstOrDefault();
            t.Text = m.meal.ToString();
        }
        private void UpdateMenu(TextBox t, int i)
        {
            MessMenu menu = db.MessMenus.Where(s => s.id == i).FirstOrDefault();
            menu.meal = t.Text;

        }
        private void UpdateMenu()
        {
            UpdateMenu(textBox1, 1);
            UpdateMenu(textBox2, 2);
            UpdateMenu(textBox3, 3);
            UpdateMenu(textBox4, 4);
            UpdateMenu(textBox5, 5);
            UpdateMenu(textBox6, 6);
            UpdateMenu(textBox7, 7);
            UpdateMenu(textBox8, 8);
            UpdateMenu(textBox9, 9);
            UpdateMenu(textBox10, 10);
            UpdateMenu(textBox11, 11);
            UpdateMenu(textBox12, 12);
            UpdateMenu(textBox13, 13);
            UpdateMenu(textBox14, 14);
            UpdateMenu(textBox15, 15);
            UpdateMenu(textBox16, 16);
            UpdateMenu(textBox17, 17);
            UpdateMenu(textBox18, 18);
            UpdateMenu(textBox19, 19);
            UpdateMenu(textBox20, 20);
            UpdateMenu(textBox21, 21);
        }
        private void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }
            con.Enabled = false;
        }
        private void EnableControls(Control con)
        {
            if (con != null)
            {
                con.Enabled = true;
                EnableControls(con.Parent);
            }
        }

        #endregion
    }
}
