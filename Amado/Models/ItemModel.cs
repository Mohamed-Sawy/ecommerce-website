using Amado.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Amado.Models
{
    public class ItemModel
    {
        [Key]
        [Required]
        public int ItemID { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Rate { get; set; }
        public string? Category { get; set; }
        public string? Brand { get; set; }

        public Color Color { get; set; }

        public int Quantity { get; set; }
    }
}
