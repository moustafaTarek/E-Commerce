using Template.Core.Layer.Dtos.ProductBrands;
using Template.DAL.Layer.Entities;

namespace Template.Core.Layer.IServices
{
	public interface IProductBrandService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Task<IEnumerable<ProductBrand>> GetAllProductBrands();
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public ProductBrand GetProductBrandById(int id);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		public void DeleteProductBrand(int id);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="productBrandAddRequest"></param>
		public void AddProductBrand(ProductBrandAddRequest productBrandAddRequest);
	}
}
