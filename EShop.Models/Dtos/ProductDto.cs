namespace EShop.Models.Dtos
{
    public class ProductDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string imgurl { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public int categoryId { get; set; }
        public string categoryname { get; set; }
    }
}
