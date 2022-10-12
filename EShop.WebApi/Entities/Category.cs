using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace EShop.WebApi.Entities
{
    public class Category
    {
        public int id { get; set; }
        [MaxLength(200)]
        public string name { get; set; }
        [MaxLength(100)]
        public string iconcss { get;set; }
        public Collection<Product> products { get; set; } = new Collection<Product>();    
    }
}
