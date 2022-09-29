using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public interface Ibooks
    {
        List<Books> getAllBooks();
        Books addBooks(Books book);

        Books editBooks(string book_id);

        Books deleteBooks(string book_id);
    }
}
