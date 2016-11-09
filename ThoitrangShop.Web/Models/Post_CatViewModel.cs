using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ThoitrangShop.Web.Models
{
    public class Post_CatViewModel
    {
        public int ID_Post { set; get; }
        public int ID_PostCat { set; get; }

        public virtual PostViewModel Post { set; get; }
        public virtual PostCatViewModel PostCat { set; get; }
    }
}