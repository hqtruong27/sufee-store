using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SS.Services.Interface.IProductServices;

namespace SS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IClientProduct _product;
        public ProductController(IClientProduct product)
        {
            _product = product;
        }
        [HttpGet]
        public async Task<IActionResult> GetProduct()
            => Ok(await _product.GetProduct());
    }
}
