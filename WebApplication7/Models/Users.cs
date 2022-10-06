using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class Users
    {
        public string name { get; set; }
        public string mobile { get; set; }
        public string password { get; set; }

        public Users(string name , string mobile , string password)
        {
            this.name = name;
            this.mobile = mobile;
            this.password = password;
        }
    }
}