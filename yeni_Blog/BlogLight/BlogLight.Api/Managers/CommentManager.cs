using BlogLight.Api.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using BlogLight.Api.Models;


namespace BlogLight.Api.Managers
{
    public class CommentManager
    {
        public static bool Save(Comment yorum)
        {
            string tar = DateTime.Today.ToString();
            SqlConnection bag = DataHelp.baglan();

            IEnumerable<Comment> Yorum = bag.Query<Comment>(
                "INSERT INTO Comment (IdWriting_Comment,Mail_Comment,Text_Comment,Date_Comment) VALUES(@idw,@mailc,@tc,@tarih)",
                new {idw=yorum.IdWriting_Comment,mailc= yorum.Mail_Comment,tc= yorum.Text_Comment,tarih=tar });

            return true;
        }

        public static List<Comment> GetComment(int id)
        {
            List<Comment> liste = new List<Comment>();
            SqlConnection baglanti = DataHelp.baglan();
            IEnumerable<Comment> yorumlar = baglanti.Query<Comment>(
                "SELECT * FROM Comment where IdWriting_Comment=@idy", new { idy = id }
                );

            foreach (var y in yorumlar)
            {
                liste.Add(y);
            }
            return liste;
        }





    }
}