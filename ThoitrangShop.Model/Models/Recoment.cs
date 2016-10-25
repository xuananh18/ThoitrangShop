using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoitrangShop.Model.Models
{
    [Table("Recoments")]
    public class Recoment
    {
        [Key]
        [Column(Order = 1)]
        public int ID_Rec { set; get; }

        [Key]
        [Column(Order = 2)]
        public int ID_Item { set; get; }

        [ForeignKey("ID_Item")]
        public virtual Item Item { set; get; }
    }
}
