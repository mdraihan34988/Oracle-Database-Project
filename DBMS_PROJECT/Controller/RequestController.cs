using DBMS_PROJECT.Model;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_PROJECT.Controller
{
    class RequestController
    {
        static Database db = new Database();
        public static ArrayList GetAllRequest()
        {
            return db.Orders.GetAllRequest();
        }
        public static ArrayList GetRequest(string uname)
        {
            return db.Orders.GetRequest(uname);
        }

        public static int GetBalance()
        {
            return db.ServiceCharges.GetBalance();
        }
        public static int GetBalance(string uname)
        {
            return db.ServiceCharges.GetBalance(uname);
        }
        public static void InsertRequest(string user, string memtype, string reqtype, string bloodgroup, int quantity)
        {
            db.Orders.InsertRequest(user, memtype, reqtype, bloodgroup, quantity);
        }
    }
}
