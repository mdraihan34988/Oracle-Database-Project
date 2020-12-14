using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_PROJECT.Model
{
    class BloodStocks
    {
        string connectionString = "User Id=RAIHANULISLAM; password=raihan;Data Source = localhost:1521/xe; ";
        OracleConnection con;
        OracleCommand cmd;

        public BloodStocks()
        {
            cmd = new OracleCommand();
            con = new OracleConnection();
            con.ConnectionString = connectionString;


        }
        public void UpdateStock(string bloodgroup)
        {
            try
            {
                con.Open();
               cmd.CommandText = "Update Blood_Stocks set Quantity=Quantity+1 where Blood_Group='" + bloodgroup + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Alert");
                con.Close();
            }
        }

        public ArrayList GetAllBloodGroup()
        {
            ArrayList BloodStock = new ArrayList();
            try
            {
                con.Open();
                cmd.CommandText = "Select * from Blood_stocks";
                cmd.Connection= con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BloodStock a = new BloodStock();

                    a.Blood_Group = dr.GetString(dr.GetOrdinal("BLOOD_GROUP"));
                    a.Quantity = dr.GetInt32(dr.GetOrdinal("QUANTITY"));
                    a.Id = dr.GetInt32(dr.GetOrdinal("BLOOD_ID"));
                    BloodStock.Add(a);
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Alert");
                con.Close();
            }
            return BloodStock;


        }


        public int CheckRequest(string bloodgroup, int quantity)
        {
            int result = 0;
            try
            {
                con.Open();
                cmd.CommandText = "Update Blood_Stocks set Quantity=Quantity-'" + quantity + "' where Quantity>='" + quantity + "' and Blood_Group='" + bloodgroup + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                result = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Alert");
            }
            return result;
        }

    }
}
