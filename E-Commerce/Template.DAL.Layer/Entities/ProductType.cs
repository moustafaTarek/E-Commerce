using Template.DAL.Layer.Entities.BaseEntity;

namespace Template.DAL.Layer.Entities
{
	public class ProductType : BaseEntity<int>
	{
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
