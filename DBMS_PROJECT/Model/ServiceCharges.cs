using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_PROJECT.Model
{
    class ServiceCharges
    {
        public int GetBalance()
        {
            string a;
            int result = 0;

            using (OracleConnection objConn = new OracleConnection("User Id=RAIHANULISLAM; password=raihan;Data Source = localhost:1521/xe; "))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "Total_ServiceCharge";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("sc", OracleDbType.Int32).Direction = ParameterDirection.Output;
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                    a = objCmd.Parameters["sc"].Value.ToString();
                    result = Int32.Parse(a);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alert");
                    objConn.Close();

                }
                objConn.Close();

                return result;

            }
        }
        public int GetBalance(string u)
        {
            string a;
            int result = 0;

            using (OracleConnection objConn = new OracleConnection("User Id=RAIHANULISLAM; password=raihan;Data Source = localhost:1521/xe; "))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "UnitTotal_ServiceCharge";
                   




                objCmd.CommandType = CommandType.StoredProcedure;
        
                objCmd.Parameters.Add("sc", OracleDbType.Int32).Direction = ParameterDirection.Output;
                objCmd.Parameters.Add("uname", OracleDbType.Varchar2).Value=u;

                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                    a = objCmd.Parameters["sc"].Value.ToString();
                    result = Int32.Parse(a);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alert");
                    objConn.Close();

                }
                objConn.Close();

                return result;

            }
        }
    }
}

