using System.ComponentModel.DataAnnotations;

namespace EShop.Models.Dtos
{
    public class CartItenAddDto
    {
        [Required]
        public int cartid { get; set; }
        [Required]
        public int productid { get; set; }
        [Required]
        public int quantityid { get; set; }

    }
}
