using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using DAL;

namespace Business_Layer
{
    public class UserInfo
    {
        
        string query;
        public string username { get; set; }
        public string password { get; set; }
        
        public bool CheckCredentials()
        {
            query = "select * from UserInfo where username = '"+username+"' and password= '"+password+"' ";

            DBHandler db = new DBHandler();
            SqlDataReader sdr = db.GetReader(query);

            if (sdr.HasRows)
            {
                sdr.Close();
                return true;
            }
            sdr.Close();
            return false;
        }

        public void ForgetPassword()
        {
            
            query = "Update UserInfo set password = '" + password + "' where username = '" + username + "' ";

            DBHandler db = new DBHandler();
            db.IDU(query);
            
        }

       
    }

   



}
