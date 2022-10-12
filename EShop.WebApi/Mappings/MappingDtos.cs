using EShop.Models.Dtos;
using EShop.WebApi.Entities;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace EShop.WebApi.Mappings
{
    public static class MappingDtos
    {
        public static IEnumerable<CategoryDto> ConvertCategoryToDto( this IEnumerable<Category> categories)
        {
            return (from c in categories
                    select new CategoryDto
                    {
                        id=c.id,
                        name=c.name,    
                        iconcss =c.iconcss
                    }).ToList();
        }   
        public static IEnumerable<ProductDto> ConvertProductsToDto( this IEnumerable<Product> products)
        {
            return (from p in products
                    select new ProductDto
                    {
                        id=p.id,
                        name = p.name, 
                        description = p.description,    
                        imgurl = p.imgurl,                
                        price = p.price,
                        quantity = p.quantity,
                        categoryId = p.category.id,
                        categoryname = p.category.name                        
                    }).ToList();
        }
        public static ProductDto ConvertProductToDto(this Product product)
        {
            return new ProductDto
            {
                id = product.id,
                name = product.name,
                description = product.description,
                imgurl = product.imgurl,
                price = product.price,
                quantity = product.quantity,
                categoryId = product.category.id,
                categoryname = product.category.name
            };
        }
        public static IEnumerable<CartItenDto> ConvertCartItensToDto(this IEnumerable<CartIten>
                                                                    cartitens, IEnumerable<Product> products)
        {
            return (from cartiten in cartitens
                    join product in products
                    on cartiten.productid equals product.id
                    select new CartItenDto
                    {
                        id = cartiten.id,
                        productid = cartiten.productid,
                        productname = product.name,
                        productdescription = product.description,
                        imgurl = product.imgurl,
                        price = product.price,
                        cartid = cartiten.cartid,
                        quantity = cartiten.quantity,
                        totalprice =product.price * cartiten.quantity                        
                    }).ToList();
        }

        public static CartItenDto CoonvertCartItenToDto(this CartIten cartiten, Product product)
        {
            return new CartItenDto
            {
                id=cartiten.id,
                productid=cartiten.productid,
                productname = product.name,
                productdescription=product.description,
                imgurl=product.imgurl,
                price=product.price,
                cartid=cartiten.cartid,
                quantity=cartiten.quantity,
                totalprice=product.price * cartiten.quantity
            };
        }
    }
}
