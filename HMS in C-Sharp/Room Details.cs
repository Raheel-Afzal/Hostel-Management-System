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
    public partial class Room_Details : Form
    {
        Rooms r = new Rooms();
        HMSEntities db = new HMSEntities();
        public Room_Details()
        {
            InitializeComponent();
        }
        private void Room_Details_Load(object sender, EventArgs e)
        {
           

            SetComboBoxFloor();
            SetComboBoxSeater();

            ShowAllData();
        }
        private void btnViewAllRoomDetail_Click(object sender, EventArgs e)
        {
            dgvRoomDetails.Rows.Clear();
            ShowAllData();
        }
        private void cbSortByType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dgvRoomDetails.Rows.Clear();

            for (int i = 1; i <= 30; i++)
            {
                if (cbSortByType.SelectedItem.ToString() == i + " Seater")
                {

                    FilterData();

                }
            }

            #region Alternative
            //if (cbSortBy.SelectedItem.ToString() == "1 Seater" )
            //{

            //    FilterData();
            //    MessageShow();
            //}

            //if (cbSortBy.SelectedItem.ToString() == "2 Seater")
            //{

            //    FilterData();
            //    MessageShow();
            //}
            //if (cbSortBy.SelectedItem.ToString() == "3 Seater")
            //{
            //    FilterData();
            //    MessageShow();
            //}
            //if (cbSortBy.SelectedItem.ToString() == "4 Seater")
            //{
            //    FilterData();
            //    MessageShow();
            //}
            //if (cbSortBy.SelectedItem.ToString() == "5 Seater")
            //{
            //    FilterData();
            //    MessageShow();
            //}
            //if (cbSortBy.SelectedItem.ToString() == "6 Seater")
            //{
            //    FilterData();
            //    MessageShow();

            //}
            #endregion // is my alternative method hy
        }
        private void cbSortByFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dgvRoomDetails.Rows.Clear();

            for (int i = 1; i <= 30; i++)
            {
                if (cbSortByFloor.SelectedItem.ToString() == i.ToString())
                {
                    var res = db.Rooms.Where(r => r.floor == cbSortByFloor.SelectedItem.ToString()).Select(r => r);

                    foreach (var item in res)
                    {
                        dgvRoomDetails.Rows.Add(item.roomno, item.floor, item.type, item.fees, item.available);
                    }

                }
            }
        }
        private void dgvRoomDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                panelEdit.Visible = true;

                string RoomNo = dgvRoomDetails.CurrentRow.Cells[0].Value.ToString();
                string Floor = dgvRoomDetails.CurrentRow.Cells[1].Value.ToString();
                string Type = dgvRoomDetails.CurrentRow.Cells[2].Value.ToString();
                string Fees = dgvRoomDetails.CurrentRow.Cells[3].Value.ToString();
                string Seats = dgvRoomDetails.CurrentRow.Cells[4].Value.ToString();

                tbRoom.Text = RoomNo;
                tbFloor.Text = Floor;
                tbType.Text = Type;
                tbFees.Text = Fees;
                tbSeats.Text = Seats;

            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
        }
        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Confirm Save Changes?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Room room = db.Rooms.Where(r => r.roomno == tbRoom.Text).FirstOrDefault();
                room.roomno = tbRoom.Text;
                room.floor = tbFloor.Text;
                room.type = tbType.Text;
                room.fees = int.Parse(tbFees.Text);
                room.available = int.Parse(tbSeats.Text);

                db.SaveChanges();

                panelEdit.Visible = false;

                dgvRoomDetails.Rows.Clear();
                ShowAllData();
            }
            else
                MessageBox.Show("Changes are not saved..!!", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }


        #region Methods
        private void ShowAllData()
        {
            var room = db.Rooms.Select(r => r);
            lblTotalRooms.Text = room.Count().ToString();

            List<Rooms> rooms = r.GetAllRoomDetail();  // three layers wala method use ho rha yahan
            foreach (var item in room)
            {
                dgvRoomDetails.Rows.Add(item.roomno, item.floor, item.type, item.fees, item.available);
            }
        }
        private void FilterData()
        {
            var res = db.Rooms.Where(r => r.type == cbSortByType.SelectedItem.ToString()).Select(r => r);

            foreach (var item in res)
            {
                dgvRoomDetails.Rows.Add(item.roomno, item.floor, item.type, item.fees, item.available);
            }
        }
        
        private void SetComboBoxFloor()
        {
            var res = db.Rooms.Select(s => s.floor).Distinct();
            foreach (var item in res)
            {
                cbSortByFloor.Items.Add(item);
            }
        }
        private void SetComboBoxSeater()
        {
            var res = db.Rooms.Select(s => s.type).Distinct();
            foreach (var item in res)
            {
                cbSortByType.Items.Add(item);
            }

        }




        #endregion

       
    }
}
