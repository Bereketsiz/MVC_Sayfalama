using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Sayfalama.Models
{
    public class mesaj
    {
        public int id { get; set; }

        public string baslik { get; set; }

        [DataType(DataType.MultilineText)]
        public string icerik { get; set; }


    }
}