using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBHandler
    {
        string dbpath = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HMS;Data Source=DESKTOP-ES2DJHB";
        SqlConnection con;
        SqlCommand cmd;


        public DBHandler()
        {
            string dbpath = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HMS;Data Source=DESKTOP-ES2DJHB";
            con = new SqlConnection(dbpath);

        }
        
        private void OpenConnection()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void CloseConnection()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public void IDU (String query)
        {
            OpenConnection();
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public SqlDataReader GetReader(String query)
        {
            OpenConnection();
            cmd = new SqlCommand(query, con);
            return cmd.ExecuteReader();
        }
    }
}
