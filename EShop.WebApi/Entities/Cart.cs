namespace EShop.WebApi.Entities
{
    public class Cart
    {
        public int id { get; set; }
        public string userid { get; set; }
        public ICollection<CartIten>cartItens { get; set; }=new List<CartIten>();
    }
}
