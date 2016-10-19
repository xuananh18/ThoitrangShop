using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoitrangShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int ID_Customer { set; get; }

        [Key]
        public int ID_Item { set; get; }

        [ForeignKey("ID_Customer")]
        public virtual Order Order { set; get; }

        [ForeignKey("ID_Item")]
        public virtual Item Item { set; get; }

        public int Quantity { set; get; }
    }
}
