using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace BlogLight.Api.Common
{
    public class Sifrele
    {
        public static string sifrele(string parola)
        {
            parola = FormsAuthentication.HashPasswordForStoringInConfigFile(parola, "MD5");

            return parola;
        }
    }
}