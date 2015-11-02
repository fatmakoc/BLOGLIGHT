using BlogLight.Api.Common;
using BlogLight.Api.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dapper;
using BlogLight.Api.Managers;

namespace BlogLight.Api.Controllers
{
    public class AboutController : ApiController
    {
        public IEnumerable<About> Get()
        {

            IEnumerable<About> hakkımda = AboutManager.Get();
            return hakkımda;
        }


    }
}
