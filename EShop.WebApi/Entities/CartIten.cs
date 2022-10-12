namespace EShop.WebApi.Entities
{
    public class CartIten
    {
        public int id { get; set; }
        public int cartid { get; set; } 
        public int productid{ get; set; } 
        public int quantity{ get; set; } 
        public Cart cart { get; set; }
        public Product product { get; set; }
        
    }
}
