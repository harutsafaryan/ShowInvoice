using ShowInvoice.JsonManager;
using ShowInvoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowInvoice.Repo
{
    public class UserRepo : IUserRepo
    {
        private readonly IJsonRead<User> _userJson;

        public UserRepo(IJsonRead<User> userJson)
        {
            _userJson = userJson;
        }
        public List<User> GetAll()
        {
            return _userJson.Read(@"C:\Users\user\source\repos\ShowInvoice\Data\users.json");
        }
    }
}
