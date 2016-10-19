using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoitrangShop.Model.Abstract;

namespace ThoitrangShop.Model.Models
{
    [Table("SubCats")]
    public class SubCat:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_SubCat { set; get; }

        public int ID_Cat { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string Alias { set; get; }
        public string Description { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }
        public string Image { set; get; }

        public bool? HomeFlag { set; get; }


        [ForeignKey("ID_Cat")]
        public virtual Cat Cat { set; get; }

        public virtual IEnumerable<Item_Sub> Item_Subs { set; get; }
    }
}
