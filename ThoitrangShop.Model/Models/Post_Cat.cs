using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoitrangShop.Model.Models
{
    [Table("Post_Cats")]
    public class Post_Cat
    {
        [Key]
        [Column(Order = 1)]
        public int ID_Post { set; get; }

        [Key]
        [Column(Order = 2)]
        public int ID_PostCat { set; get; }

        [ForeignKey("ID_Post")]
        public virtual Post Post { set; get; }

        [ForeignKey("ID_PostCat")]
        public virtual PostCat PostCat { set; get; }
    }
}
