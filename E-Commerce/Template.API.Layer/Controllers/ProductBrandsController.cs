using Microsoft.AspNetCore.Mvc;
using Template.Core.Layer.Dtos.ProductBrands;
using Template.Core.Layer.IServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Template.API.Layer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductBrandsController : ControllerBase
	{
		private readonly IProductBrandService _productBrandService;

        public ProductBrandsController(IProductBrandService productBrandService)
        {
            _productBrandService = productBrandService;
        }

        [HttpGet]
		public async Task<IActionResult> GetAllProductBrands()
		{
			var ProductBrands = await _productBrandService.GetAllProductBrands();
			return Ok(ProductBrands);
		}

		[HttpGet("{id}")]
		public IActionResult GetProductBrandById(int id)
		{
			var productBrand = _productBrandService.GetProductBrandById(id);
			return Ok(productBrand);
		}

		[HttpPost]
		public IActionResult AddProductBrand([FromBody]ProductBrandAddRequest productBrandAddRequest)
		{
			_productBrandService.AddProductBrand(productBrandAddRequest);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteProductBrand(int id)
		{
			_productBrandService.DeleteProductBrand(id);
			return Ok();
		}
	}
}
