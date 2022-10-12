namespace EShop.Models.Dtos
{
    public class CartItenDto
    {
        public int id { get; set; }
        public int productid { get; set; }
        public int cartid { get; set; }
        public int quantity { get; set; }
        public string productname { get; set; }
        public string productdescription { get; set; }
        public string imgurl { get; set; }
        public decimal price { get; set; }
        public decimal totalprice { get; set; }

    }
}
