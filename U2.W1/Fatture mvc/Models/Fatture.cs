using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fatture_mvc.Models
{
    public class Fatture
    {
        public int IDfatture { get; set; }
        public string nomeIntestatario { get; set; }
        public string cognomeIntestatario { get; set; }
        public DateTime dataEmissione { get; set; }
        public double ammontareFattura { get; set; }
        public static List<Fatture> FattureList { get; set; } = new List<Fatture>();
    }
}