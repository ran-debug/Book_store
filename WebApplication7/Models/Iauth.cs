using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace WebApplication7.Models
{
    public interface Iauth
    {
        Users login(Users user);
        void register(Users user);
    }
}
