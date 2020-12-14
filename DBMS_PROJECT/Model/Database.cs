using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_PROJECT.Model
{
    class Database
    {
        public Users Users { get; set; }
        public Informations Informations { get; set; }

        public BloodStocks BloodStocks { get; set; }

        public Orders Orders { get; set; }

        public BloodDoners BloodDoners { get; set; }

        public ServiceCharges ServiceCharges { get; set; }

        public Database()
        {
            Users = new Users();
            Informations = new Informations();
            BloodStocks = new BloodStocks();

            Orders = new Orders();
            BloodDoners = new BloodDoners();
            ServiceCharges = new ServiceCharges();
        }
    }
}
