using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoitrangShop.Model.Models
{
    [Table("Post_Subs")]
    public class Post_Sub
    {
        [Key]
        [Column(Order = 1)]
        public int ID_Post { set; get; }

        [Key]
        [Column(Order = 2)]
        public int ID_PostSub { set; get; }

        [ForeignKey("ID_Post")]
        public virtual Post Post { set; get; }

        [ForeignKey("ID_PostSub")]
        public virtual PostSub PostSub { set; get; }
    }
}
