using EShop.Models.Dtos;
using EShop.WebApi.Entities;
using EShop.WebApi.Mappings;
using EShop.WebApi.Repository.IProductRepository;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace EShop.WebApi.Controllers
{
    [Route("v1/[controller]/api")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet("products")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> Index()
        {
            try
            {
                var products = await productRepository.getProductsAll();
                if (products == null)
                {
                    return NotFound();
                }
                else
                {
                var productdto = products.ConvertProductsToDto();
                return Ok(productdto);

                }
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("products/{id:int}")]
        public async Task<ActionResult<ProductDto>> GetProductById(int id)
        {
            try
            {
                var product = await productRepository.getProductById(id);            
                if (product == null) 
                    { 
                        return NotFound("product not found");
                    }
                else
                    {
                        var productDto = product.ConvertProductToDto();
                        return Ok(productDto);

                    }
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("products/categories/{id:int}")]
        public async Task<ActionResult<ProductDto>> GetProductCategory(int id)
        {
            try
            {
                var getcategory = await productRepository.getProductsCategoryById(id);
                if (getcategory == null)
                {
                    return NotFound("category not found");
                }
                else
                {
                    var getcategoryDto = getcategory.ConvertProductsToDto();
                    return Ok(getcategoryDto);
                }

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
       
    }
}
