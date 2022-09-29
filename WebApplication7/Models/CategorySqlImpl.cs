using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Security.Cryptography;


namespace WebApplication7.Models
{
    public class CategorySqlImpl : ICategory
    {
        SqlConnection conn;
        SqlCommand comm;

        public CategorySqlImpl()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
            comm = new SqlCommand();
        }
        public BookCategory AddCategory(BookCategory bookCategory)
        {
            comm.CommandText = "insert into category (cat_id , cat_name , descriptions , status , position , creat_at , img) values ('"
                +bookCategory.cat_id+"' ,'"+bookCategory.cat_name+ "','"+bookCategory.desc+ "',"+bookCategory.status+",'"+bookCategory.pos+"','" +
                bookCategory.date+"' , '"+bookCategory.img+"' )";


            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
            if (row > 0)
                return bookCategory;
            else
                return null;
            
        }

        public List<BookCategory> GetBookCategory()
        {
            List<BookCategory> list = new List<BookCategory>();
            comm.CommandText = "select * from category";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string cat_id = reader["cat_id"].ToString();
                string cat_name = reader["cat_name"].ToString();
                string desc = reader["descriptions"].ToString();
                int status = Convert.ToInt32(reader["status"]);
                string position = reader["position"].ToString();
                string date = reader["creat_at"].ToString();

                list.Add(new BookCategory(cat_id, cat_name, desc, status, position, date));
            }
            conn.Close();
            return list;
        }

        public BookCategory update(string c_id)
        {
            BookCategory booK_c = new BookCategory();
            comm.CommandText = "select * from category where cat_id ='"+c_id+"'";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                booK_c.cat_id = reader["cat_id"].ToString();
                booK_c.cat_name = reader["cat_name"].ToString();
                booK_c.desc = reader["descriptions"].ToString();
                booK_c.status = Convert.ToInt32(reader["status"]);
                booK_c.pos = reader["position"].ToString();
                booK_c.date = reader["creat_at"].ToString();
            }
            conn.Close();
            return booK_c;
        }
    }
}