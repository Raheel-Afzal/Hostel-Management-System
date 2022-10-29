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


namespace HMS_in_C_Sharp
{
    public partial class Form1 : Form
    {

        private Form activeFrom = null;
        
       
        public Form1()
        {
            InitializeComponent();
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {   
            HideSubMenu();
            Form_Load(new DashBoard());

        }


        #region Form_Load
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form_Load(new DashBoard());
        }
        private void btnNewEnrollment_Click(object sender, EventArgs e)
        {
            Form_Load(new New_Enrollment() );
        }
        private void btnAddNewRoom_Click(object sender, EventArgs e)
        {
            Form_Load(new Add_New_Room());
        }
        private void btnRoomDetails_Click(object sender, EventArgs e)
        {
            Form_Load(new Room_Details());
        }
        private void BtnViewRecord_Click(object sender, EventArgs e)
        {
            Form_Load(new ViewRecordStudent());
        }
        private void btnCancelEnrollment_Click(object sender, EventArgs e)
        {
            Form_Load(new Cancel_Enrollment());
        }
        private void btnFees_Click(object sender, EventArgs e)
        {
            Form_Load(new Fees());
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form_Load(new Menu());
        }
        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            Form_Load(new Add_New_Employee());
        }
        private void btnViewEmployeeRecord_Click(object sender, EventArgs e)
        {
            Form_Load(new View_Employee_Record());
        }
        private void btnSalary_Click(object sender, EventArgs e)
        {
            Form_Load(new Salary());
        }
        private void btnOthers_Click(object sender, EventArgs e)
        {
            Form_Load(new Others());
        }
        #endregion

        #region Submenu
        private void btnStudents_Click(object sender, EventArgs e)
        {
            
            ShowSubMenu(panelStudent, btnStudents);
        }
        private void btnRooms_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(panelRooms,btnRooms);
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAccounts,btnAccount);
        }
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelEmployees, btnEmployees);
        }
        private void btnMess_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMess, btnMess);

        }

        #endregion

        #region MenuSideBar
        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            HideSubMenu();

            if (Sidebar.Width == 270)
            {
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                Line.Width = 52;

            }
            else
            {

                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                Line.Width = 252;

            }
        }
        #endregion

        #region Methods
        private void HideSubMenu()
        {
            panelStudent.Visible = false;
            panelRooms.Visible = false;
            panelAccounts.Visible = false;
            panelEmployees.Visible = false;
            panelMess.Visible = false;


        }
        private void ShowSubMenu(Panel submenu,Guna.UI.WinForms.GunaButton btn)
        {
            lblSelectedMenu.Text = btn.Text;
            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }

        }
        public void Form_Load(Form form)
        {
            if (activeFrom != null)
            {
                activeFrom.Close();
            }
            activeFrom = form;
            form.TopLevel = false;
            Wrapper.Controls.Add(form);
            Wrapper.Tag = form;

            form.BringToFront();
            form.Show();

        }
        #endregion
        private void ExitControl_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure? You Want To Logout..!!!", "LogOut?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Login l = new Login();
                l.Show();
                this.Close();
            }
        }

        
    }
}

