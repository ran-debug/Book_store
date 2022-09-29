using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class CategoryController : ApiController
    {
        private ICategory category;

        public CategoryController()
        {
            category = new CategorySqlImpl();
        }

        [HttpGet]

        public IHttpActionResult get()
        {
            var data = category.GetBookCategory();
            return Ok(data);
        }

        [HttpGet , Route("api/category/{cat_id}")]

        public IHttpActionResult get(string cat_id)
        {
            var data = category.update(cat_id);
            if (data == null)
                return NotFound();
            else
                return Ok(data);
        }

        [HttpPost]

        public IHttpActionResult post(BookCategory bookCategory)
        {
            var data = category.AddCategory(bookCategory);
            return Ok(data);
        }
    }
}
