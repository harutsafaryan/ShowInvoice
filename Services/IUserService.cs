using ShowInvoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowInvoice.Services
{
    public interface IUserService
    {
        List<User> GetAll();
    }
}
