using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BlogLight.Api.Models;
using BlogLight.Api.Managers;

namespace BlogLight.Api.Controllers
{
    public class GirisController : ApiController
    {
        [HttpPost]
        public User POST(string mail,string parola)
        {
         return  UserManager.CheckUserPassword(mail,parola);         
        }


        public List<User> Get()
        {
            List<User> kisiler = new List<User>();
            kisiler = UserManager.Get();
            return kisiler;
        }


    }
}
