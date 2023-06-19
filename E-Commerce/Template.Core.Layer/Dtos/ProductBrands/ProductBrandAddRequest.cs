using System.ComponentModel.DataAnnotations;

namespace Template.Core.Layer.Dtos.ProductBrands
{
	public class ProductBrandAddRequest
	{
		[Required]
		public string Name { get; set; }
	}
}
