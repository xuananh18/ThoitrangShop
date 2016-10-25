using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoitrangShop.Model.Models
{
    [Table("ItemTags")]
    public class ItemTag
    {
        [Key]
        [Column(Order=1)]
        public int ID_Item { set; get; }

        [Key]
        [Column(TypeName = "varchar", Order = 2)]
        [MaxLength(50)]
        public string ID_Tag { set; get; }

        [ForeignKey("ID_Item")]
        public virtual Item Item { set; get; }

        [ForeignKey("ID_Tag")]
        public virtual Tag Tag { set; get; }
    }
}
