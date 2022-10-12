using Ecommerce.Services.Web.IServices;
using EShop.Models.Dtos;

namespace Ecommerce.Services.Web.Services
{
    public class ServiceProduct : IServiceProduct
    {
        public HttpClient _httpClient;
        public Logger<ServiceProduct> _logger;
        public ServiceProduct(HttpClient httpClient, Logger<ServiceProduct> logger)
        {
            _httpClient = httpClient;
            _logger = logger;   
        }

        public async Task<ProductDto> GetProductById(int id)
        {
            try
            {
                var productByid = await _httpClient.GetFromJsonAsync<ProductDto>($"v1/home/api/products/{id}");                
                return productByid;
            }
            catch (Exception)
            {
                _logger.LogError("algo deu errado:");
                throw;
            }
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            try
            {
                var products = await _httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("v1/home/api/products");
                return products;
            }
            catch (Exception)
            {
                _logger.LogError("erro ao acessar a api:");
                throw;
            }
        }
    }
}
