using System.ComponentModel.DataAnnotations;

namespace Template.Core.Layer.Dtos.ProductTypes
{
	public class ProductTypeAddRequest
	{
		[Required]
		public string Name { get; set; }

		[Required]
        public string Description { get; set; }
    }
}
