using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amado.Models
{
    public class OrderModel
    {
        [Key]
        [Required]
        public int OrderID { get; set; }
        [ForeignKey("CartModel")]
        public int CartID { get; set; }

        public CartModel? Cart { get; set; }

        [ForeignKey("UserModel")]
        public int UserID { get; set; }

        public UserModel? User { get; set; }

       
        public string? Comment { get; set; }
    }
}
