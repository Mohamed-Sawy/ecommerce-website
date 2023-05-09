using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amado.Models
{
    public class Cart_ItemModel
    {
        [Key]
        [ForeignKey("CartModel")]
        public int CartID { get; set; }

        public CartModel? Cart { get; set; }

        [Key]
        [ForeignKey("ItemModel")]
        public int ItemID { get; set; }

        public ItemModel? Item { get; set; }

        public int Quantity { get; set; }
    }
}
