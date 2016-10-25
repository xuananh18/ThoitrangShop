using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using ThoitrangShop.Model.Abstract;

namespace ThoitrangShop.Model.Models
{
    [Table("Items")]
    public class Item : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Item { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        [Column(TypeName ="xml")]
        public string MoreImage { set; get; }
        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        public virtual IEnumerable<Item_Cat> Item_Cats { set; get; }

        public virtual IEnumerable<Item_Sub> Item_Subs { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }

        public virtual IEnumerable<ItemTag> ItemTags { set; get; }

        public virtual IEnumerable<Recoment> Recoments { set; get; }
    }
}