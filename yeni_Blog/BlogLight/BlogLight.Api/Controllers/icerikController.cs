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
    public class icerikController : ApiController
    {
       

        public IEnumerable<Writing> Get(int id)
        {
            IEnumerable<Writing> gelenYazi= ArticleManager.GetArticleById(id);
            return gelenYazi;
        }

        [HttpPost]

        public bool POST(Comment yorum)
        {
           return CommentManager.Save(yorum);
          
        }

        //public List<Comment> GetById(int id)
        //{
        //    List<Comment> liste = new List<Comment>();
        //    liste = CommentManager.GetComment(id);
        //    return liste;
        //}


       

    }
}
