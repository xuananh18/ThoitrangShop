using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThoitrangShop.Web.Models
{
    public class PostSubViewModel
    {
        public int ID_PostSub { set; get; }

        public int ID_PostCat { set; get; }
        public string Name { set; get; }
        public string Alias { set; get; }
        public string Description { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }
        public string Image { set; get; }

        public bool? HomeFlag { set; get; }
        public virtual PostCatViewModel PostCat { set; get; }

        public virtual IEnumerable<Post_SubViewModel> Post_Subs { set; get; }
    }
}