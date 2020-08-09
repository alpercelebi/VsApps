using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Vtİslemleri
{
    public class OrderPost
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public int Stock { get; set; }
        public DateTime Date { get; set; }
        public bool OnayDurumu { get; set; }
        public string Adress { get; set; }

    }
}