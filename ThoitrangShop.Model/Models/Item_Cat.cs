using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoitrangShop.Model.Models
{
    [Table("Item_Cats")]
    public class Item_Cat
    {
        [Key]
        [Column(Order=1)]
        public int ID_Item { set; get; }

        [Key]
        [Column(Order = 2)]
        public int ID_Cat { set; get; }

        [ForeignKey("ID_Item")]
        public virtual Item Item { set; get; }

        [ForeignKey("ID_Cat")]
        public virtual Cat Cat { set; get; }
    }
}
