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
    [Table("Cats")]
    public class Cat:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Cat { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }

        [MaxLength(256)]
        public string Description { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<SubCat> SubCats { set; get; }

        public virtual IEnumerable<Item_Cat> Item_Cats { set; get; }
    }
}
