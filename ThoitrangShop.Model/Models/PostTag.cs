using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThoitrangShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [Column(Order = 1)]
        public int ID_Post { set; get; }

        [Key]
        [Column(TypeName = "varchar",Order =2)]
        [MaxLength(50)]
        public string ID_Tag { set; get; }

        [ForeignKey("ID_Post")]
        public virtual Post Post { set; get; }

        [ForeignKey("ID_Tag")]
        public virtual Tag Tag { set; get; }
    }
}