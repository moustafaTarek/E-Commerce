using Template.Core.Layer.Dtos.ProductBrands;
using Template.DAL.Layer.Entities;

namespace Template.Core.Layer.IServices
{
	public interface IProductBrandService
	{
		/// <summary>
		/// Get all available productBrands.
		/// </summary>
		/// <returns></returns>
		public Task<IEnumerable<ProductBrand>> GetAllProductBrands();
		
		/// <summary>
		/// Get specific productBrand using <paramref name="id"/>.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public ProductBrand GetProductBrandById(int id);

		/// <summary>
		/// Delete specific productBrand using <paramref name="id"/>.
		/// </summary>
		/// <param name="id"></param>
		public void DeleteProductBrand(int id);

		/// <summary>
		/// Add new productBrand
		/// </summary>
		/// <param name="productBrandAddRequest"></param>
		public void AddProductBrand(ProductBrandAddRequest productBrandAddRequest);
	}
}
