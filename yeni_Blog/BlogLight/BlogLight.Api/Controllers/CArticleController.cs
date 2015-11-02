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
    public class CArticleController : ApiController
    {
       // TUMUNU GETIR
        public IEnumerable<Writing> Get(int id)
        {
            List<Writing> liste = new List<Writing>();
            liste = ArticleManager.GetArticleByCategId(id);
            
            return liste;

        }

       
    }
}
