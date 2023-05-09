using System.ComponentModel.DataAnnotations;

namespace Amado.Models
{
    public class CartModel
    {
        [Key]
        [Required]
        public int CartID { get; set; }

        public double TotalPrice { get; set; }

        public List<Cart_ItemModel>? CartItems { get; set; }
        public List<OrderModel>? Orders { get; set; }

    }
}
