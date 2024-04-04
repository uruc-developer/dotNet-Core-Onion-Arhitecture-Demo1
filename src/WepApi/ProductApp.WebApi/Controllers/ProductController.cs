using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var alllist = await productRepository.GetAllAsync();
            var result = alllist.Select(i => new ProductViewDto()
            {
                Id = i.Id,
                Name = i.Name
            }).ToList();
            return Ok(result);
        }
    }
}
