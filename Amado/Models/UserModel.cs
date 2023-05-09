using Amado.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amado.Models
{
    public class UserModel
    {
        [Key]
        [Required]
        public int UserId { get; set; }
        [ForeignKey("CartModel")]
        public int CartID { get; set; }

        public CartModel? Cart { get; set; }

        public string? FirstName { get; set; }

        public string? SecondName { get; set; }
        public string? CompanyName { get; set; }

        public string? Email { get; set;}

        public Country Country { get; set; }

        public string? Address { get; set; }

        public string? Town { get; set; }

        public string? ZIPCode { get; set; }

        public string? PhoneNo { get; set; }

        public List<OrderModel>? Orders { get; set; }

    }
}
