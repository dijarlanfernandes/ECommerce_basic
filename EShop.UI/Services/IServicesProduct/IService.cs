using EShop.Models.Dtos;

namespace EShop.UI.Services.IServicesProduct
{
    public interface IService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int id);
    }
}
