using BlogLight.Api.Common;
using BlogLight.Api.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BlogLight.Api.Managers;
using Dapper;

namespace BlogLight.Api.Controllers
{
    public class CategoryController : ApiController
    {
        public List<Category> Get()
        {
            List<Category> liste = new List<Category>();
            liste = CategoryManager.Get();
            return liste;
        }
    }
}
