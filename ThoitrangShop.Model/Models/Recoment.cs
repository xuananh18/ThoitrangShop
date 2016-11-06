using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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