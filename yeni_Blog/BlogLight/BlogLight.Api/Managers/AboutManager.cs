using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogLight.Api.Common;
using System.Data.SqlClient;
using BlogLight.Api.Models;
using Dapper;
namespace BlogLight.Api.Managers
{
    public class AboutManager
    {
        public static IEnumerable<About> Get()
        {
            SqlConnection baglanti = DataHelp.baglan();
            IEnumerable<About> hakkımda = baglanti.Query<About>(
                "SELECT * FROM About "
                );

            return hakkımda;
        }
    }
}