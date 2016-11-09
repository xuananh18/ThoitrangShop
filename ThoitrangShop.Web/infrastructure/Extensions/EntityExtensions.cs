using ThoitrangShop.Model.Models;
using ThoitrangShop.Web.Models;

namespace ThoitrangShop.Web.infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCat(this PostCat postCat, PostCatViewModel postCatVm)
        {
            postCat.ID_PostCat = postCatVm.ID_PostCat;
            postCat.Name = postCatVm.Name;
            postCat.Description = postCatVm.Description;
            postCat.Alias = postCatVm.Alias;
            postCat.ParentID = postCatVm.ParentID;
            postCat.DisplayOrder = postCatVm.DisplayOrder;
            postCat.Image = postCatVm.Image;
            postCat.HomeFlag = postCatVm.HomeFlag;

            postCat.CreatedDate = postCatVm.CreatedDate;
            postCat.CreatedBy = postCatVm.CreatedBy;
            postCat.UpdatedDate = postCatVm.UpdatedDate;
            postCat.UpdateedBy = postCatVm.UpdatedBy;
            postCat.MetaKeyword = postCatVm.MetaKeyword;
            postCat.MetaDescription = postCatVm.MetaDescription;
            postCat.Status = postCatVm.Status;
        }

        public static void UpdatePost(this Post post, PostViewModel postVm)
        {
            post.ID_Post = postVm.ID_Post;
            post.Name = postVm.Name;
            post.Description = postVm.Description;
            post.Alias = postVm.Alias;
            //post.CategoryID = postVm.CategoryID;
            post.Content = postVm.Content;
            post.Image = postVm.Image;
            post.HomeFlag = postVm.HomeFlag;
            post.ViewCount = postVm.ViewCount;

            post.CreatedDate = postVm.CreatedDate;
            post.CreatedBy = postVm.CreatedBy;
            post.UpdatedDate = postVm.UpdatedDate;
            post.UpdateedBy = postVm.UpdatedBy;
            post.MetaKeyword = postVm.MetaKeyword;
            post.MetaDescription = postVm.MetaDescription;
            post.Status = postVm.Status;
        }
    }
}