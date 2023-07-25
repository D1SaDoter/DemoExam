using Podgotovka.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka.Service.LoginModule
{
    public class Autorize
    {
        public bool LoginCheck(string login, string password, List<User> user)
        {
            for (int i = 0; i < user.Count; i++)
            {
                if (user[i].UserLogin == login&&user[i].UserPassword==password) return true;
            }
            return false;
        }
    }
}
