using Template.Core.Layer.Dtos.Products;
using Template.DAL.Layer.Entities;

namespace Template.Core.Layer.IServices
{
	public interface IProductService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="productsGetRequest"></param>
		/// <returns></returns>
		public Task<IEnumerable<Product>> GetAllProducts(ProductsGetRequest productsGetRequest);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public Product GetProductById(int id);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		public void DeleteProduct(int id);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="productAddRequest"></param>
		public void AddProduct(ProductAddRequest productAddRequest);
	}
}
