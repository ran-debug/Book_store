using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class Books
    {
        public string book_id { get; set; }
        public string cat_id { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public int price { get; set; }
        public string desc { get; set; }
        public string pos { get; set; }
        public int status { get; set; }

        public byte[] img { get; set; }
        public string isbn { get; set; }

        public Books()
        {

        }

       public Books(string book_id , string cat_id , string title , string year , int price , string desc , string pos , int status , byte[] img , string isbn)
        {
            this.book_id = book_id;
            this.cat_id = cat_id;
            this.title = title;
            this.year = year;
            this.price = price;
            this.desc = desc;
            this.pos = pos;
            this.status = status;
            this.img = img;
            this.isbn = isbn;
        }

    }
}