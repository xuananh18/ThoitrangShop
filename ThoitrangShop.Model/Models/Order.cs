using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoitrangShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Customer { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string Address { set; get; }

        [Required]
        [MaxLength(256)]
        public string Email { set; get; }

        [Required]
        [MaxLength(50)]
        public string Mobile { set; get; }

        [Required]
        [MaxLength(256)]
        public string Message { set; get; }

        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { set; get; }

        [MaxLength(256)]
        public string PaymentMethod { set; get; }

        public string PaymentStatus { set; get; }

        public bool Status { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}
