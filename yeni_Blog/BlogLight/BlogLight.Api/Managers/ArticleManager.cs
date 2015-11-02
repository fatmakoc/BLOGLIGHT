using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogLight.Api.Models;
using Dapper;
using BlogLight.Api.Common;
using System.Data.SqlClient;

namespace BlogLight.Api.Managers
{
    public class ArticleManager
    {
        //YAZIYI GETIR
        public static IEnumerable<Writing> GetArticleById(int id)
        {
            SqlConnection baglanti = DataHelp.baglan();
            IEnumerable<Writing> yazilar = baglanti.Query<Writing>(
                "SELECT * FROM Writing where ID=@idy", new { idy = id }
                );
            return yazilar;
        }

        public static List<Writing> GetArticleByCategId(int id)
        {
            List<Writing> liste = new List<Writing>();
            SqlConnection baglanti = DataHelp.baglan();
            IEnumerable<Writing> yazilar = baglanti.Query<Writing>(
                "SELECT * FROM Writing where IdCategory_Writing=@idy", new { idy = id }
                );

            foreach (var y in yazilar)
            {
                liste.Add(y);
            }
            return liste;
        }

        //TUMUNU GETIR
        public static List<Writing> Get()
        {
            List<Writing> liste = new List<Writing>();
            SqlConnection baglanti = DataHelp.baglan();
            IEnumerable<Writing> yazilar = baglanti.Query<Writing>(
                "SELECT * FROM Writing "
                );

            foreach (var y in yazilar)
            {
                liste.Add(y);
            }
            return liste;
        }


        ////YAZI EKLE
        //public IEnumerable <Writing> POST(int id, int yazino, int categno, string baslik, string yaz, string foto)
        //{
        //    SqlConnection baglanti = DataHelp.baglan();
        //    IEnumerable<Writing> yazi = baglanti.Query<Writing>(
        //      "INSERT INTO Writing VALUES(ID=@idw,Id_Writing=@idww,IdCategory_Writing=@idcw, Header_Writing=@bas,Text_Writing=@yazisi,Date_Writing=@tar,Photo_Writing=@fot,ChangeDate_Writing=@dtar)",
        //      new { idw = id, idww = yazino, idcw = categno, bas = baslik, yazisi = yaz, tar = DateTime.Today.ToString(), fot = foto, dtar = DateTime.Today.ToString() }
        //    );
        //    return yazi.FirstOrDefault();
        //}


        ////YAZI SİL
        //public static bool DeleteWriting(int id)
        //{
        //    SqlConnection baglanti = DataHelp.baglan();
        //    IEnumerable<Writing> yazi = baglanti.Query<Writing>(
        //        "DELETE FROM Writing where ID=@no", new { no = id }
        //        );
        //    return true;
        //}


        ////YAZI GUNCELLE
        //public static Writing UpdateWriting(int id, int yazino, int categno, string baslik, string yaz, string tarih, string foto)
        //{
        //    SqlConnection baglanti = DataHelp.baglan();
        //    IEnumerable<Writing> guncelyazi = baglanti.Query<Writing>(
        //       "UPDATE Writing SET ID=@idw,Id_Writing=@idww,IdCategory_Writing=@idcw, Header_Writing=@bas,Text_Writing=@yazisi,Date_Writing=@tar,Photo_Writing=@fot,ChangeDate_Writing=@dtar ",
        //       new { idw = id, idww = yazino, idcw = categno, bas = baslik, yazisi = yaz, tar = tarih, fot = foto, dtar = DateTime.Today.ToString() }
        //        );
        //    return guncelyazi.FirstOrDefault();
        //}





    }
}