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
    class BloodDoners
    {
        string connectionString = "User Id=RAIHANULISLAM; password=raihan;Data Source = localhost:1521/xe; ";
        OracleConnection con;
        OracleCommand cmd;

        public BloodDoners()
        {
            cmd = new OracleCommand();
            con = new OracleConnection();
            con.ConnectionString = connectionString;

        }
        public void InsertDonateInfo(User u)
        {
            string q = "";
            try
            {


                con.Open();

                q = "declare \n";
                q += "iid Informations.Info_Id%type; \n";
                q += "bld Informations.Blood_Group%type; \n";
                q += "begin \n";
                q += "Username_Info('"+u.Username+"',iid,bld); \n";
                q += "donates_dml.donateInfo_insert(Donates_sequence.nextval,iid,bld,to_date(to_char(sysdate,'dd-mm-yyyy'),'dd-mm-yyyy')); \n";
                q += "end;";

                cmd.CommandText = q;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
                con.Close();
            }

        }
        public dynamic GetLastDonateDate(string username)
        {
            

            DateTime lastdonatdate = DateTime.Parse("01/01/1753");

            try
            {
                con.Open();
                cmd.CommandText = "select max(Last_Time_Donated) as maxdate from DONATES where Info_Id=(select Info_Id from Informations where Username='" + username + "' )";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lastdonatdate = reader.GetDateTime(reader.GetOrdinal("maxdate"));

                }
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
               // MessageBox.Show(ex.Message, "Alert");
                return lastdonatdate;

            }
            return lastdonatdate;
        }

        public ArrayList GetAllDonor()
        {
            ArrayList doners = new ArrayList();


            try
            {
                con.Open();
                cmd.CommandText = "Select * from Donates,Informations  where Donates.Info_id =Informations.Info_id";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    BloodDoner a = new BloodDoner();
                    a.Blood_Group = reader.GetString(reader.GetOrdinal("Blood_Group"));
                    a.Donate_Serial= reader.GetInt32(reader.GetOrdinal("Serial"));
                    a.Last_Donate_Date= reader.GetDateTime(reader.GetOrdinal("last_Time_Donated"));
                    a.fullName= reader.GetString(reader.GetOrdinal("Full_Name"));
                    a.userName= reader.GetString(reader.GetOrdinal("Username"));
                    a.Profession = reader.GetString(reader.GetOrdinal("Profession"));
                    a.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    a.Gmail = reader.GetString(reader.GetOrdinal("Gmail"));
                    a.Address = reader.GetString(reader.GetOrdinal("Address"));


                    doners.Add(a);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Alert");
                con.Close();

            }
            return doners;


        }
        public ArrayList GetDonor(string uname)
        {
            ArrayList doners = new ArrayList();


            try
            {
                con.Open();
                cmd.CommandText = "Select * from Donates,Informations  where Donates.Info_id =Informations.Info_id and Informations.Username='"+uname+"'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    BloodDoner a = new BloodDoner();
                    a.Blood_Group = reader.GetString(reader.GetOrdinal("Blood_Group"));
                    a.Donate_Serial = reader.GetInt32(reader.GetOrdinal("Serial"));
                    a.Last_Donate_Date = reader.GetDateTime(reader.GetOrdinal("last_Time_Donated"));
                    a.fullName = reader.GetString(reader.GetOrdinal("Full_Name"));
                    a.userName = reader.GetString(reader.GetOrdinal("Username"));
                    a.Profession = reader.GetString(reader.GetOrdinal("Profession"));
                    a.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    a.Gmail = reader.GetString(reader.GetOrdinal("Gmail"));
                    a.Address = reader.GetString(reader.GetOrdinal("Address"));


                    doners.Add(a);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Alert");
                con.Close();

            }
            return doners;


        }

    }
}
