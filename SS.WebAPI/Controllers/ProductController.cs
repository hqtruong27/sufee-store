using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using Microsoft.AspNetCore.Authorization;
>>>>>>> origin/develop
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SS.Services.Interface.IProductServices;

namespace SS.WebAPI.Controllers
{
<<<<<<< HEAD
    [Route("api/[controller]")]
    [ApiController]
=======
    [ApiController]
    [Route("api/[controller]")]
>>>>>>> origin/develop
    public class ProductController : ControllerBase
    {
        private readonly IClientProduct _product;
        public ProductController(IClientProduct product)
        {
            _product = product;
        }
        [HttpGet]
<<<<<<< HEAD
=======
        [Authorize]
>>>>>>> origin/develop
        public async Task<IActionResult> GetProduct()
            => Ok(await _product.GetProduct());
    }
}
