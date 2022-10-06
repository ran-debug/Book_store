using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication7.Models
{
    public class authSqlImpl : Iauth
    {
        SqlConnection conn;
        SqlCommand comm;

        public authSqlImpl()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
            comm = new SqlCommand();
        }
        public Users login(Users user)
        {
            
            comm.CommandText = "select * from login where u_name = '"+user.name+"' and [password] = '"+user.password+"'";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            conn.Close();
            return user;
        }

        public void register(Users user)
        {
            throw new NotImplementedException();
        }
    }
}