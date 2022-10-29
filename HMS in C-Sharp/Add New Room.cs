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
    public partial class Add_New_Room : Form
    {
        public Add_New_Room()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            Rooms a = new Rooms();

            a.RoomNo = tbRoomNo.Text;
            a.Floor = tbFloor.Text;
            a.RoomType = cbRoomType.SelectedItem.ToString();
            a.Fees = int.Parse(tbFees.Text);

            int available = int.Parse(a.RoomType.Split(' ')[0]);
            a.Available = available;
            

            dgvAddRoom.Rows.Add(a.RoomNo, a.Floor, a.RoomType, a.Fees,a.Available);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Want to Save Data?", "Save Data", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                Rooms a = new Rooms();

                for (int i = 0; i < dgvAddRoom.Rows.Count; i++)
                {
                    a.RoomNo = dgvAddRoom[0, i].Value.ToString();
                    a.Floor = dgvAddRoom[1, i].Value.ToString();
                    a.RoomType = dgvAddRoom[2, i].Value.ToString();
                    a.Fees = int.Parse(dgvAddRoom[3, i].Value.ToString());
                    a.Available = int.Parse( dgvAddRoom[4, i].Value.ToString());

                    a.SaveRooms();
                }

                MessageBox.Show("DATA SAVED SUCCESSFULLY");
                dgvAddRoom.Rows.Clear();
            }
            else
                MessageBox.Show("Data not Saved yet");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvAddRoom.Rows.RemoveAt(this.dgvAddRoom.SelectedRows[0].Index);
        }

        
    }
}
