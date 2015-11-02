using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogLight.Api.Models
{
    public class Writing
    {
        public int ID { get; set; }
        public int Id_Writing { get; set; }
        public int IdCategory_Writing { get; set; }
        public string Header_Writing { get; set; }
        public string Text_Writing { get; set; }
        public string LongText_Writing { get; set; }
        public string Date_Writing { get; set; }
        public string Photo_Writing { get; set; }
        public string ChangeDate_Writing { get; set; }
    }
}