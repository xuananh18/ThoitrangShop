using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoitrangShop.Model.Models
{
    [Table("Item_Subs")]
    public class Item_Sub
    {
        [Key]
        public int ID_Item { set; get; }

        [Key]
        public int ID_SubCat { set; get; }

        [ForeignKey("ID_Item")]
        public virtual Item Item { set; get; }

        [ForeignKey("ID_SubCat")]
        public virtual SubCat SubCat { set; get; }
    }
}
