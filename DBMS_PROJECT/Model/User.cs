using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_PROJECT.Model
{
    class User
    {
        public int Userid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public int Info_Id { get; set; }
        public string Permission { get; set; }
        public string Type { get; set; }
    }
}
