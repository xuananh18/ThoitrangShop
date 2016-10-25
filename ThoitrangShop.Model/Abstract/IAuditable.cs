using System;

namespace ThoitrangShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdateedBy { set; get; }

        bool Status { set; get; }

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
    }
}