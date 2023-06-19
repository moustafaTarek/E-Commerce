using Microsoft.AspNetCore.Mvc;
using Template.Core.Layer.Dtos.Products;
using Template.Core.Layer.IServices;

namespace Template.API.Layer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductsController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllProducts([FromQuery] ProductsGetRequest productsGetRequest)
		{
			return Ok(await _productService.GetAllProducts(productsGetRequest));
		}

		[HttpGet("{id:int}")]
		public IActionResult GetProductById([FromRoute] int id)
		{
			return Ok(_productService.GetProductById(id));
		}

		[HttpDelete("{id:int}")]
		public IActionResult DeleteProductById([FromRoute] int id)
		{
			_productService.DeleteProduct(id);
			return Ok();
		}

		[HttpPost]
		public IActionResult AddProduct([FromBody] ProductAddRequest productAddRequest)
		{
			_productService.AddProduct(productAddRequest);
			return Ok();
		}
	}
}
