using Application.Products.Commands;
using Application.Products.Queries.GetProductDetail;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace OnlineStoreWebUI.Controllers
{

    public class ProductsController : BaseController
    {
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<ProductDetailVm>> Get(int id)
        {
            var vm = await Mediator.Send(new GetProductDetailQuery { Id = id });

            return base.Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateProductDto createProductDto)
        {
            var productId = await Mediator.Send(new CreateProductCommand { NewProduct = createProductDto });

            return Ok(productId);
        }
    }
}