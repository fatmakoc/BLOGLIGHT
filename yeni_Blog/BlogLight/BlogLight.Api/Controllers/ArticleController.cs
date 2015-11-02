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
    public class ArticleController : ApiController
    {

        //YAZIYI GETIR
        public IEnumerable<Writing> Get(int id)
        {

            IEnumerable<Writing> yazilar = ArticleManager.GetArticleById(id);
            return yazilar;
        }


        //TUMUNU GETIR
        public IEnumerable<Writing> Get()
        {
            List<Writing> liste = new List<Writing>();
            liste = ArticleManager.Get();

            return liste;
        }



    }
}
