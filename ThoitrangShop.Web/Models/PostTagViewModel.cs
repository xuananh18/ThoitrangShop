using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThoitrangShop.Web.Models
{
    public class PostTagViewModel
    {
        public int ID_Post { set; get; }
        public string ID_Tag { set; get; }
        public virtual PostViewModel Post { set; get; }
        public virtual TagViewModel Tag { set; get; }
    }
}