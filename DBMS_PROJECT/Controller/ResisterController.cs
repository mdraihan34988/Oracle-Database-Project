using DBMS_PROJECT.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_PROJECT.Controller
{
   public class ResisterController
    {
        static Database db = new Database();
        public static bool ResisterMember(string name, string username, string pass, string blgrp, DateTime dob, string prof, string gen, string mail, string add,string a)
        {
            string t = a;
            User u = new User();
            Information info = new Information();
            info.fullName = name;
            u.Username = username;
            info.userName = username;
            u.Password = pass;
            info.bloodGroup = blgrp;
            info.DOB = dob;
            info.Profession = prof;
            info.Gender = gen;
            info.Gmail = mail;
            info.Address = add;
            u.Permission = "Valid";
            u.Type = "User";
            return db.Informations.ResisterMember(u,info,t);
        }

        public static ArrayList GetAllMember()
        {
            return db.Users.GetAllMember();
        }
        public static dynamic GetInfo(int id)
        {
            return db.Informations.GetInfoById(id);

        }
        public static dynamic GetMember(string bldgrp)
        {
            return db.Informations.GetMembers(bldgrp);
        }

        public static dynamic updatepermission(string a,string b)
        {
            return db.Informations.updatepermission(a, b);
        }
        public static dynamic GetMemberuname(string username)
        {
            return db.Informations.GetMemberUname(username);
        }

        public static int UpdateInfo(string username,string mail,string address)
        {
            return db.Informations.UpdateInfo(username, mail, address);
        }
        public static int UpdatePassword(string username, string old, string newpass)
        {
            return db.Users.UpdatePassword(username, old, newpass);
        }
    }
}
