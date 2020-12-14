using DBMS_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_PROJECT.Controller
{
    class LoginController
    {
        static Database db = new Database();
        public static dynamic ValidateMember(string user)
        {
          return db.Users.AuthenticUser(user);
        }

        public static dynamic Manageuser(int a)
        {
            return db.Users.Manageuser(a);
        }
    }
}
