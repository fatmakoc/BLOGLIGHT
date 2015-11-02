using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogLight.Api.Models
{
    public class Comment
    {
        public int Id_Comment { get; set; }
        public int IdWriting_Comment { get; set; }
        public string Mail_Comment { get; set; }
        public string Text_Comment { get; set; }
        public string Date_Comment { get; set; }
    }
}