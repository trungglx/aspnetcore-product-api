using Microsoft.AspNetCore.Mvc;
using ProductApi.DTOs;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            return Ok("Hello Trung! API is working!");
        }

        [HttpGet("products")]
        public IActionResult GetFakeProducts()
        {
            var products = new List<ProductDto>
            {
                new ProductDto { Id = 1, Name = "Apple", Price = 10.5 },
                new ProductDto { Id = 2, Name = "Mango", Price = 20 }
            };
            return Ok(products);
        }
    }
}
