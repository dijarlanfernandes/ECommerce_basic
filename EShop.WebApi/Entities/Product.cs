using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.WebApi.Entities
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        [MaxLength(100)]
        public string name { get; set; }
        [MaxLength(200)]
        public string description { get; set; }
        [MaxLength(200)]
        public string imgurl { get; set; }
        [Column(TypeName = "Decimal(10,2)")]
        public decimal price { get; set; }
        public int quantity { get; set; }
        public int categoryid { get; set; }
        public Category category { get; set; }
        public ICollection<CartIten> cartItens { get; set; } = new List<CartIten>();
    }
}
