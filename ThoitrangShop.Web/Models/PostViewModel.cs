using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThoitrangShop.Web.Models
{
    public class PostViewModel
    {
        public int ID_Post { set; get; }
        public string Name { set; get; }
        public string Alias { set; get; }

        public string Image { set; get; }
        public string MoreImage { set; get; }
        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        public virtual IEnumerable<Post_CatViewModel> Post_Cats { set; get; }

        public virtual IEnumerable<Post_SubViewModel> Post_Subs { set; get; }

        public virtual IEnumerable<PostTagViewModel> PostTags { set; get; }

        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }

        public string UpdatedBy { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        public bool Status { set; get; }
    }
}