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
    class Informations
    {
        string query;
        string query1;
        string connectionString = "User Id=RAIHANULISLAM; password=raihan;Data Source = localhost:1521/xe; ";
        OracleConnection con;
        OracleCommand cmd;

        public Informations()
        {
            cmd = new OracleCommand();
            con = new OracleConnection();
            con.ConnectionString = connectionString;


        }
        public Information GetMemberUname(string username)
        {
            Information a=new Information();



            try
            {
                con.Open();
                query = "Select Gmail,Address from Informations where Username ='" + username + "'";
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                  
                   
                    
                    a.Address = reader.GetString(reader.GetOrdinal("Address"));

                    a.Gmail = reader.GetString(reader.GetOrdinal("Gmail"));
               



                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
                con.Close();

            }
            return a;
        }
        public ArrayList GetMembers(string bloodgroup)
        {
            ArrayList members = new ArrayList();
       

            try
            {
                con.Open();
                query = "Select * from Informations where Blood_Group ='" + bloodgroup + "'";
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    SearchMember a = new SearchMember();
                    a.Full_Name = reader.GetString(reader.GetOrdinal("FULL_Name"));
                    a.Address = reader.GetString(reader.GetOrdinal("Address"));
                
                    a.Gmail = reader.GetString(reader.GetOrdinal("Gmail"));
                    a.Profession = reader.GetString(reader.GetOrdinal("PROFESSION"));
                    a.Gender = reader.GetString(reader.GetOrdinal("GENDER"));



                    members.Add(a);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
                con.Close();

            }
            return members;
        }
        public dynamic GetInfoById(int id)
        {
            string bld = "";
            try
            {

                con.Open();
                cmd.CommandText = "SELECT Blood_Group FROM Informations WHERE Info_Id='" + id + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    bld = dr.GetString(dr.GetOrdinal("Blood_Group"));

                }
                con.Close();
                return bld;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Alert");
                return bld;
            }

        }

        public bool updatepermission(string a, string b)
        {
            int result = 0;
            try
            {

                con.Open();


                query = "Update Users set Permission='" + a + "' where USERNAME='"+b+"'";
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Alert");
                con.Close();
            }
            if (result != 0) return true;
            else return false;

        }
        public int UpdateInfo(string uname,string mail,string addresss)
        {
            int result=0;
            string a;
            cmd.Connection = con;
            cmd.CommandText = "update_info";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("u", OracleDbType.Varchar2).Value = uname;
            cmd.Parameters.Add("m", OracleDbType.Varchar2).Value = mail;

            cmd.Parameters.Add("a", OracleDbType.Varchar2).Value = addresss;
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

        public bool ResisterMember(User user, Information info,string t)
        {
            int result = 0;
            try
            {

                con.Open();
                DateTime sid= info.DOB;

                query = "INSERT INTO Informations (Info_Id,Full_Name,Username,Address,Blood_Group,Gender,DOB,Profession,Gmail) " +
                                        "VALUES(Informations_sequence.nextval, '" + info.fullName + "','" + info.userName + "','" + info.Address + "','" + info.bloodGroup + "','" + info.Gender +
                                        "',to_date('"+t+"','dd-mm-yyyy'),'" + info.Profession + "','" + info.Gmail + "')";
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                result = cmd.ExecuteNonQuery();




                    query1 = "INSERT INTO Users (Id,Username,Password,Type,Permission,Info_Id) " +
                        "VALUES(Users_sequence.nextval,'" + user.Username+ "','" + user.Password + "','" + user.Type + "','" + user.Permission + "',Informations_sequence.currval)";

                cmd.CommandText = query1;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                result = cmd.ExecuteNonQuery();





                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show( e.ToString(), "Alert");
                con.Close();
            }
            if (result != 0) return true;
            else return false;
        }
    }
}
