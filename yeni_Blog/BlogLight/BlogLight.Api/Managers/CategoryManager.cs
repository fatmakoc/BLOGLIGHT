using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogLight.Api.Common;
using BlogLight.Api.Models;
using System.Data.SqlClient;
using Dapper;

namespace BlogLight.Api.Managers
{
    public class CategoryManager
    {
        public static List<Category> Get()
        {
            List<Category> liste = new List<Category>();
            SqlConnection baglanti = DataHelp.baglan();
            IEnumerable<Category> kategoriler = baglanti.Query<Category>(
                "SELECT * FROM Category "
                );

            foreach (var k in kategoriler)
            {
                liste.Add(k);
            }
            return liste;
        }
    }
}