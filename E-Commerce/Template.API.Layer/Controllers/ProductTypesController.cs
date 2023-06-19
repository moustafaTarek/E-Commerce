using Microsoft.AspNetCore.Mvc;
using Template.Core.Layer.Dtos.ProductTypes;
using Template.Core.Layer.IServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Template.API.Layer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductTypesController : ControllerBase
	{
		private readonly IProductTypeService _productTypeService;

        public ProductTypesController(IProductTypeService productTypeService)
        {
            _productTypeService = productTypeService;
        }

        [HttpGet]
		public async Task<IActionResult> GetAllProductTypes()
		{
			var productTypes = await _productTypeService.GetAllProductTypes();
			return Ok(productTypes);
		}

		[HttpGet("{id}")]
		public IActionResult GetProductTypeById(int id)
		{
			var productType = _productTypeService.GetProductTypeById(id);
			return Ok(productType);
		}

		[HttpPost]
		public IActionResult AddProductType([FromBody] ProductTypeAddRequest productTypeAddRequest)
		{
			_productTypeService.AddProductType(productTypeAddRequest);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteProductType(int id)
		{
			_productTypeService.DeleteProductType(id);
			return Ok();
		}
	}
}
