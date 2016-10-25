using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThoitrangShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [MaxLength(50)]
        public string ID_Footer { set; get; }

        [Required]
        public string Content { set; get; }
    }
}