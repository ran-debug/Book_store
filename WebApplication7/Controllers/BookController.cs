using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class BookController : ApiController
    {
        private Ibooks book;

        public BookController()
        {
            book = new bookSqlImpl();
        }

        [HttpGet]

        public IHttpActionResult get()
        {
            var data = book.getAllBooks();
            return Ok(data);
        }

        [HttpGet , Route("api/book/{book_id}")]

        public IHttpActionResult delete(string book_id)
        {
            var data = book.deleteBooks(book_id);
            if(data > 0)
            {
                return Ok(data);
            }
            return NotFound();
        }

        [HttpPost]

        public IHttpActionResult post(Books books)
        {
            var data = book.addBooks(books);
            return Ok(data);
        }
    }
}
