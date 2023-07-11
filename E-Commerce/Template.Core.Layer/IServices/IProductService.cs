using Template.Core.Layer.Dtos.Products;
using Template.DAL.Layer.Entities;

namespace Template.Core.Layer.IServices
{
	public interface IProductService
	{
		/// <summary>
		/// Get all available products.
		/// </summary>
		/// <param name="productsGetRequest"></param>
		/// <returns></returns>
		public Task<IEnumerable<Product>> GetAllProducts(ProductsGetRequest productsGetRequest);

		/// <summary>
		/// Get specific product using <paramref name="id"/>.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public Product GetProductById(int id);

		/// <summary>
		/// Delete specific product using <paramref name="id"/>.
		/// </summary>
		/// <param name="id"></param>
		public void DeleteProduct(int id);

		/// <summary>
		/// Add new product.
		/// </summary>
		/// <param name="productAddRequest"></param>
		public void AddProduct(ProductAddRequest productAddRequest);
	}
}
