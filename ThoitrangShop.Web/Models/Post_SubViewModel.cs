using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThoitrangShop.Web.Models
{
    public class Post_SubViewModel
    {
        public int ID_Post { set; get; }
        public int ID_PostSub { set; get; }
        public virtual PostViewModel Post { set; get; }
        public virtual PostSubViewModel PostSub { set; get; }
    }
}