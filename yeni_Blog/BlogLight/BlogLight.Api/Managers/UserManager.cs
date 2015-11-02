using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogLight.Api.Models;
using BlogLight.Api.Common;
using System.Data.SqlClient;
using Dapper;

namespace BlogLight.Api.Managers
{
    public class UserManager
    {
        //public static User Save(User gelen)
        //{
        //    string sifre = Sifrele.sifrele(gelen.Password_User);
        //    SqlConnection bag = DataHelp.baglan();
        //    IEnumerable<User> kullanici = bag.Query<User>(
        //      "SELECT * FROM [User] where Mail_User=@Mail And Password_User=@parola", new { Mail = gelen.Mail_User, parola = sifre });

        //    return kullanici.FirstOrDefault();
            
        //}

        public static User CheckUserPassword(string mailAd, string pass)
        {
           
            string sifreliPas = Sifrele.sifrele(pass);
            User user = GetByUsername(mailAd);
            //if (user == null)
            //    result = false;

            //if (user.Password_User != sifreliPas)
            ////    result = false;

            //return result;
            return user;
        }

        public static User GetByUsername(string mailAd)
        {
            SqlConnection bag = DataHelp.baglan();
            User kullanici = bag.Query<User>(
              "SELECT * FROM [User] where Mail_User = @Username ", new {Username = mailAd }).FirstOrDefault();

           return kullanici;

        }


        public static List<User> Get()
        {
            List<User> liste = new List<User>();
            SqlConnection bag = DataHelp.baglan();
            IEnumerable<User> kullanici = bag.Query<User>(
              "SELECT * FROM [User]");

            foreach (var u in kullanici)
                liste.Add(u);

            return liste;
        }



    }
}