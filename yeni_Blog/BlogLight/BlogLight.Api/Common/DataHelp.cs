using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BlogLight.Api.Common
{
    public class DataHelp
    {
        public static SqlConnection baglan()
        {
            SqlConnection baglan = new SqlConnection("Data Source=FATMA\\SQLEXPRESS;Initial Catalog=blog;Integrated Security=True");
            return baglan;
        }
    }
}