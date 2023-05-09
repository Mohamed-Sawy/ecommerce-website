using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amado.Models
{
    public class ImageModel
    {
        [Key]
        [Required]
        public int ImageID { get; set; }

        [ForeignKey("ItemModel")]
        public int ItemID { get; set; }

        public ItemModel? Item { get; set; }
    }
}
