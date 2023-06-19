using System.ComponentModel.DataAnnotations.Schema;
using Template.DAL.Layer.Entities.BaseEntity;

namespace Template.DAL.Layer.Entities
{
	public class Product : BaseEntity<int>
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
        public string PictureUrl { get; set; }

		[ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

		[ForeignKey("ProductBrand")]
        public int ProductBrandId { get; set; }
        public ProductBrand ProductBrand { get; set; }
    }
}
