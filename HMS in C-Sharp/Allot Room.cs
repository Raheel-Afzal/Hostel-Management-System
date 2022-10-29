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
    public partial class Allot_Room : Form
    {
        HMSEntities db = new HMSEntities();
        public Allot_Room()
        {
            InitializeComponent();
        }
        private void Allot_Room_Load(object sender, EventArgs e)
        {
            //btnConfirmAlloment.Enabled = false;


            SetCbRoomType();
            //SetCbBedRequired();
        }
        private void btnConfirmAlloment_Click(object sender, EventArgs e)
        {/*
             DialogResult dr = MessageBox.Show("Confirm Room Detail. \n \n  \n Room No : " + lblAllotRoom.Text+ " \n Room Type : " + lblRoomType.Text+ "\n Fees : "+lblFees.Text, "Review Detail",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                AllotRoom.RoomNo = lblAllotRoom.Text;
                AllotRoom.RoomType = lblRoomType.Text;
                AllotRoom.Fees = lblFees.Text;
                this.Close();
            }
            else
                MessageBox.Show("Room Not Selected","Not Proceed",MessageBoxButtons.OK,MessageBoxIcon.Warning);*/
        }

        private void btnCancelFromAllotRoom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
           
            string SelectedRoomType = cbRoomType.SelectedItem.ToString();
            string SRB = cbBedRequired.SelectedItem.ToString();
            int SelectedBedRequired = int.Parse(SRB.Split(' ')[0]);
            dgvRoomDetails.Rows.Clear();

            var collection2 = db.Rooms.Select(s => s);
            var collection= db.Rooms.Where(s => s.available >= SelectedBedRequired && s.type == SelectedRoomType).Select(s => s);
            foreach (var item in collection)
            {
                dgvRoomDetails.Rows.Add(item.roomno,item.floor,item.type,item.fees,item.available);
            }

            if (dgvRoomDetails.Rows.Count==0)
            {
                MessageBox.Show("No Rooms Are Available");
            }
        }

        private void cbBedRequired_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SRT = cbRoomType.SelectedItem.ToString();
            int SelectedRoomType = int.Parse(SRT.Split(' ')[0]);

            string SRB = cbBedRequired.SelectedItem.ToString();
            int SelectedBedRequired = int.Parse(SRB.Split(' ')[0]);

            if (SelectedBedRequired > SelectedRoomType)
            {
                MessageBox.Show("For " + SelectedBedRequired + " Bed You need to Choose Different Room Type !!!","Change Selection",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }

            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //btnConfirmAlloment.Enabled = true;
            string SelectedAllotRoom = "";
            string SelectedRoomType = "";
            string RoomFees = "";
            if (dgvRoomDetails.Rows.Count != 0)
            {
                SelectedAllotRoom = dgvRoomDetails.CurrentRow.Cells[0].Value.ToString();
                SelectedRoomType = dgvRoomDetails.CurrentRow.Cells[2].Value.ToString();
                RoomFees = dgvRoomDetails.CurrentRow.Cells[3].Value.ToString();
            }
            else
                MessageBox.Show("Click on Search Button First to View Available Rooms !!!", "Not Proceed", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            DialogResult dr = MessageBox.Show("Confirm Room Detail. \n \n  \n Room No : " + SelectedAllotRoom + " \n Room Type : " + SelectedRoomType + "\n Fees : " + RoomFees, "Review Detail", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                lblAllotRoom.Text = SelectedAllotRoom;
                lblRoomType.Text =  SelectedRoomType;
                lblFees.Text =      RoomFees;

                AllotRoom.RoomNo =   SelectedAllotRoom;
                AllotRoom.RoomType = SelectedRoomType;
                AllotRoom.Fees = RoomFees;

            }
            else
                MessageBox.Show("Room Not Selected", "Not Proceed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            

        }

        
        private void SetCbRoomType()
        {
            var res = db.Rooms.Select(s => s.type).Distinct();
            foreach (var item in res)
            {
                cbRoomType.Items.Add(item);
            }
        }
        private void SetCbBedRequired()
        {
            var res = db.Rooms.Select(s => s.available).Distinct();
            foreach (var item in res)
            {
                cbBedRequired.Items.Add(item+ " Bed");
            }
        }

        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
