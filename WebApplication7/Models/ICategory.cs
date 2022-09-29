using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public interface ICategory
    {
        List<BookCategory> GetBookCategory();
        BookCategory AddCategory(BookCategory bookCategory);

        BookCategory update(string cat_id);
    }
}