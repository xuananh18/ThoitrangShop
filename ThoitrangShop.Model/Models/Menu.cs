using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoitrangShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Menu { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string URL { set; get; }

        public int? DisplayOrder { set; get; }

        [Required]
        public int ID_Group { set; get; }

        [ForeignKey("ID_Group")]
        public virtual MenuGroup MenuGroup { set; get; }

        [MaxLength(10)]
        public string Target { set; get; }

        public bool Status { set; get; }
    }
}
