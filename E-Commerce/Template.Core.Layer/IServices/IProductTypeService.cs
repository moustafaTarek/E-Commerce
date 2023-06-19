using Template.Core.Layer.Dtos.ProductTypes;
using Template.DAL.Layer.Entities;

namespace Template.Core.Layer.IServices
{
	public interface IProductTypeService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Task<IEnumerable<ProductType>> GetAllProductTypes();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public ProductType GetProductTypeById(int id);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		public void DeleteProductType(int id);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="productTypeAddRequest"></param>
		public void AddProductType(ProductTypeAddRequest productTypeAddRequest);
	}
}
