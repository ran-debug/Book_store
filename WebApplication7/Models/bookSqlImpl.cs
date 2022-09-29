using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Configuration;
using System.Diagnostics;
using System.Security.Cryptography;

namespace WebApplication7.Models
{
    public class bookSqlImpl : Ibooks
    {
        SqlConnection conn;
        SqlCommand comm;


        public bookSqlImpl()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
            comm = new SqlCommand();
        }
        public Books addBooks(Books book)
        {
            throw new NotImplementedException();
        }

        public Books deleteBooks(string book_id)
        {
            throw new NotImplementedException();
        }

        public Books editBooks(string book_id)
        {
            throw new NotImplementedException();
        }

        public List<Books> getAllBooks()
        {
            List<Books> list = new List<Books>();
            comm.CommandText = "select * from books";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                string book_id = reader["bookId"].ToString();
                string cat_id = reader["cat_id"].ToString();
                string title = reader["title"].ToString();
                string years = reader["years"].ToString();
                int price = Convert.ToInt32(reader["price"]);
                string desc = reader["descriptions"].ToString();
                string pos = reader["position"].ToString();
                int status = Convert.ToInt32(reader["status"]);
                //byte[] img = reader["img"];
                string isbn = reader["isbn"].ToString();
                list.Add(new Books(book_id, cat_id, title, years, price, desc, pos, status,null, isbn));
            }
            conn.Close();
            return list;
        }
    }
}