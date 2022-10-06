using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class AuthController : ApiController
    {
        private Iauth auth;

        public AuthController()
        {
            auth = new authSqlImpl();
        }

        [HttpGet]

        public IHttpActionResult get(Users user)
        {
            var data = auth.login(user);
            return Ok(data);
        }
    }
}
