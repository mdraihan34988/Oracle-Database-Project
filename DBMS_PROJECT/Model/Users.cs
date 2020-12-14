using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DBMS_PROJECT.Model
{
    class Users
    {
        string connectionString = "User Id=RAIHANULISLAM; password=raihan;Data Source = localhost:1521/xe; ";
        OracleConnection con;
        OracleCommand cmd;


        public Users()
        {
            cmd = new OracleCommand();
            con = new OracleConnection();
            con.ConnectionString = connectionString;
           

        }

        public int Manageuser(int a)
        {
            string query="";
            int result = 0;

            if(a==1)
            {
                query = "ALTER TRIGGER ManageUser Enable";
            }
            if (a == 0)
            {
                query = "ALTER TRIGGER ManageUser Disable";
            }

            try
            {

                con.Open();
                cmd.CommandText = query;
                cmd.Connection = con;
                result=cmd.ExecuteNonQuery();
                con.Close();



            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString(), "Alert");
            }
            return result;

        }
        public int UpdatePassword(string username, string old, string newpass)
        {
            int result = 0;
            string a;
            cmd.Connection = con;
            cmd.CommandText = "updatepassword";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("u", OracleDbType.Varchar2).Value = username;
            cmd.Parameters.Add("old", OracleDbType.Varchar2).Value = old;

            cmd.Parameters.Add("newp", OracleDbType.Varchar2).Value = newpass;
            cmd.Parameters.Add("c", OracleDbType.Int32).Direction = ParameterDirection.Output;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                a = cmd.Parameters["c"].Value.ToString();
                result = Int32.Parse(a);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
                con.Close();

            }
            con.Close();

            return result;
        }



        public User AuthenticUser(string user)
        {
            User u = null;
            u = null;
            try
            {
                
                con.Open();
                cmd.CommandText = "SELECT * FROM USERS WHERE USERNAME='" + user + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    u = new User();
                   u.Userid = dr.GetInt32(dr.GetOrdinal("Id"));
                    u.Username = dr.GetString(dr.GetOrdinal("USERNAME"));
                    u.Password = dr.GetString(dr.GetOrdinal("PASSWORD"));
                    u.Info_Id = dr.GetInt32(dr.GetOrdinal("INFO_ID"));
                    u.Type = dr.GetString(dr.GetOrdinal("TYPE"));
                    u.Permission = dr.GetString(dr.GetOrdinal("PERMISSION"));
                    
                }
                con.Close();
                return u;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Alert");
            }


            return u;
            
        }


        public ArrayList GetAllMember()
        {
            ArrayList informations = new ArrayList();


            try
            {
                con.Open();
                cmd.CommandText = "Select * from Informations,Users where Informations.Info_Id =Users.Info_Id and Type='User'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    Customize a = new Customize();
                    a.fullName = dr.GetString(dr.GetOrdinal("FULL_NAME"));
                    a.userName = dr.GetString(dr.GetOrdinal("USERNAME"));
                    a.bloodGroup = dr.GetString(dr.GetOrdinal("BLOOD_GROUP"));
                    a.DOB = dr.GetDateTime(dr.GetOrdinal("DOB"));
                    a.Gender = dr.GetString(dr.GetOrdinal("GENDER"));
                    a.Address = dr.GetString(dr.GetOrdinal("ADDRESS"));
                    a.Gmail = dr.GetString(dr.GetOrdinal("GMAIL"));
                    a.Profession = dr.GetString(dr.GetOrdinal("PROFESSION"));
                    a.Type = dr.GetString(dr.GetOrdinal("TYPE"));
                    a.Permission = dr.GetString(dr.GetOrdinal("PERMISSION"));

                    informations.Add(a);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
                con.Close();

            }
            con.Close();
            return informations ;

        }



    }
}
