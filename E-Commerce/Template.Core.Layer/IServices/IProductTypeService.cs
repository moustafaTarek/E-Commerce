using Template.Core.Layer.Dtos.ProductTypes;
using Template.DAL.Layer.Entities;

namespace Template.Core.Layer.IServices
{
	public interface IProductTypeService
	{
		/// <summary>
		/// Get all available productTypes.
		/// </summary>
		/// <returns></returns>
		public Task<IEnumerable<ProductType>> GetAllProductTypes();

		/// <summary>
		/// Get specific productType using <paramref name="id"/>.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public ProductType GetProductTypeById(int id);

		/// <summary>
		/// Delete specific productType using <paramref name="id"/>.
		/// </summary>
		/// <param name="id"></param>
		public void DeleteProductType(int id);

		/// <summary>
		/// Add new productType.
		/// </summary>
		/// <param name="productTypeAddRequest"></param>
		public void AddProductType(ProductTypeAddRequest productTypeAddRequest);
	}
}
