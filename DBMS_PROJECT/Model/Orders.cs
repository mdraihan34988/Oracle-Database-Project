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
    class Orders
    {
        string connectionString = "User Id=RAIHANULISLAM; password=raihan;Data Source = localhost:1521/xe; ";
        OracleConnection con;
        OracleCommand cmd;

        public Orders()
        {
            cmd = new OracleCommand();
            con = new OracleConnection();
            con.ConnectionString = connectionString;

        }
        public void InsertRequest(string username, string membertype, string ordertype, string bloodgroup, int quantity)
        {
            string q = "";
            int servchar = 0;
            if (membertype == "Non Registered" && ordertype == "Accepted")
            {
                servchar = 100;
            }
            else if (membertype == "Registered" && ordertype == "Accepted")
            {
                servchar =  (100 / 2);
            }
            else
                servchar = 0;
            try
            {
                con.Open();

                q = "begin \n";
                q += "InsertOrders('" + username + "','" + ordertype + "','" + bloodgroup + "','" + quantity + "','" + membertype + "','" + servchar + "'); \n";
                q += "end;";

                cmd.CommandText = q;
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

        public ArrayList GetAllRequest()
        {
            ArrayList requests = new ArrayList();


            try
            {
                con.Open();
                cmd.CommandText = "Select * from Orders,Blood_stocks  where Orders.Blood_id =Blood_stocks.Blood_id";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    Order a = new Order();
                    a.Blood_Group = reader.GetString(reader.GetOrdinal("Blood_Group"));
                    a.Username = reader.GetString(reader.GetOrdinal("USERNAME"));
                    a.Order_Status = reader.GetString(reader.GetOrdinal("ORDER_STATUS"));
                    a.Member_Status = reader.GetString(reader.GetOrdinal("MEMBER_STATUS"));
                    a.Quantity = reader.GetInt32(reader.GetOrdinal("QUANTITY"));
                    a.Order_Serial = reader.GetInt32(reader.GetOrdinal("ORDER_SERIAL"));
                    a.ServiceCharge = reader.GetInt32(reader.GetOrdinal("SERVICE_CHARGE"));



                    requests.Add(a);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Alert");
                con.Close();

            }
            return requests;

        }
        public ArrayList GetRequest(string uname)
        {
            ArrayList requests = new ArrayList();


            try
            {
                con.Open();
                cmd.CommandText = "Select * from Orders,Blood_stocks  where Orders.Blood_id =Blood_stocks.Blood_id and Orders.Username='"+uname+"'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    Order a = new Order();
                    a.Blood_Group = reader.GetString(reader.GetOrdinal("Blood_Group"));
                    a.Username = reader.GetString(reader.GetOrdinal("USERNAME"));
                    a.Order_Status = reader.GetString(reader.GetOrdinal("ORDER_STATUS"));
                    a.Member_Status = reader.GetString(reader.GetOrdinal("MEMBER_STATUS"));
                    a.Quantity = reader.GetInt32(reader.GetOrdinal("QUANTITY"));
                    a.Order_Serial = reader.GetInt32(reader.GetOrdinal("ORDER_SERIAL"));
                    a.ServiceCharge = reader.GetInt32(reader.GetOrdinal("SERVICE_CHARGE"));



                    requests.Add(a);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Alert");
                con.Close();

            }
            return requests;

        }

    }
}
