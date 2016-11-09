using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThoitrangShop.Web.Models
{
    public class PostCatViewModel
    {
        public int ID_PostCat { set; get; }
        public string Name { set; get; }
        public string Alias { set; get; }
        public string Description { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }
        public string Image { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<PostSubViewModel> PostSubs { set; get; }

        public virtual IEnumerable<Post_CatViewModel> Post_Cats { set; get; }

        public DateTime? CreatedDate { set; get; }


        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }


        public string UpdatedBy { set; get; }


        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        public bool Status { set; get; }
    }
}