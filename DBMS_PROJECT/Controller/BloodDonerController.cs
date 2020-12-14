using DBMS_PROJECT.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_PROJECT.Controller
{
    class BloodDonerController
    {
        static Database db = new Database();
        public static ArrayList GetAllDonor()
        {
            return db.BloodDoners.GetAllDonor();

        }
        public static ArrayList GetDonor(string uname)
        {
            return db.BloodDoners.GetDonor(uname);

        }
        public static dynamic GetLastDonateDate(string Username)
        {
            return db.BloodDoners.GetLastDonateDate(Username);
        }
        public static void InsertDonateInfo(User u)
        {
            db.BloodDoners.InsertDonateInfo(u);
        }
    }
}
