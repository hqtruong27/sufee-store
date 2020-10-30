using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SS.Services.Interface.IProductServices;

namespace SS.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IClientProduct _product;
        public ProductController(IClientProduct product)
        {
            _product = product;
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetProduct()
            => Ok(await _product.GetProduct());
    }
}
