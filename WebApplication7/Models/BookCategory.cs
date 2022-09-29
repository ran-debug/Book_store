using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class BookCategory
    {
        public string cat_id { get; set; }
        public string cat_name { get; set; }
        public string desc { get; set; }

        public int status { get; set; }
        public string pos { get; set; }
        public string date { get; set; }

        public byte[] img { get; set; }

        public BookCategory()
        {

        }

        public BookCategory(string cat_id ,  string cat_name , string desc , int status , string pos , string date)
        {
            this.cat_id = cat_id;
            this.cat_name = cat_name;
            this.desc = desc;
            this.pos = pos;
            this.status = status;
            this.date = date;
        }
    }
}