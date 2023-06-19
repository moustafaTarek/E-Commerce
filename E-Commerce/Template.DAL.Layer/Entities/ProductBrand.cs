using Template.DAL.Layer.Entities.BaseEntity;

namespace Template.DAL.Layer.Entities
{
	public class ProductBrand : BaseEntity<int>
	{
		public string Name { get; set; }
	}
}
