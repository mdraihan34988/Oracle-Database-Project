using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_PROJECT.Model
{
    class BloodDoner
    {
        public int Donate_Serial { get; set; }
        public string fullName { get; set; }
        public string userName { get; set; }
        public string Blood_Group { get; set; }
        public DateTime Last_Donate_Date { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Profession { get; set; }
        public string Gmail { get; set; }

    }
}
