using System.ComponentModel.DataAnnotations;

namespace Template.Core.Layer.Dtos.Products
{
	public class ProductAddRequest
	{
		[Required]
		public string Name { get; set; }
		
		[Required]
		public string Description { get; set; }
		
		[Required]
		public double Price { get; set; }
		
		[Required] 
		public string PictureUrl { get; set; }

		[Required]
		public int BrandId { get; set; }

		[Required]
		public int TypeId { get; set; }
	}
}
