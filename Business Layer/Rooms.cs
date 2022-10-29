using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;

namespace Business_Layer
{
    public class Rooms
    {
        public string RoomNo { get; set; }
        public string Floor { get; set; }
        public string RoomType { get; set; }
        public int Fees { get; set; }
        public int Available { get; set; }

        public string query = " ";

        public void SaveRooms()
        {
            query = "insert into Rooms values ('" + RoomNo + "','" + Floor + "','" + RoomType + "','" + Fees + "','" + Available + "')";

            DBHandler dBHandler = new DBHandler();

            dBHandler.IDU(query);


        }

        public List<Rooms> GetAllRoomDetail()
        {

            query = "select * from Rooms";
            DBHandler dBHandler = new DBHandler();
            SqlDataReader sdr = dBHandler.GetReader(query);
            List<Rooms> Rlist = new List<Rooms>();
            while (sdr.Read())
            {
                Rooms r = new Rooms();
                r.RoomNo = sdr[0].ToString();
                r.Floor = sdr[1].ToString();
                r.RoomType = sdr[2].ToString();
                r.Fees = int.Parse(sdr[3].ToString());
                r.Available = int.Parse(sdr[4].ToString());

                Rlist.Add(r);
            }
            sdr.Close();
            dBHandler.CloseConnection();

            return Rlist;




        }
    }
}
