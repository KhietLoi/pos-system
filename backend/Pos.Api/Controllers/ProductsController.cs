using Microsoft.AspNetCore.Mvc;
using Pos.Api.Data;
using Pos.Api.Models;

namespace Pos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {

        // GET /api/products
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(InMemoryData.Products);
        }

    
    }
    }
