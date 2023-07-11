using Template.Core.Layer.Dtos.ProductBrands;
using Template.Core.Layer.IServices;
using Template.DAL.Layer.Entities;
using Template.DAL.Layer.IGenericRepositoryService;

namespace Template.Core.Layer.Services
{
	internal class ProductBrandService : IProductBrandService
	{
		private readonly IGenericRepository<ProductBrand> _productBradGenericRepository;

        public ProductBrandService(IGenericRepository<ProductBrand> productBradGenericRepository)
        {
			_productBradGenericRepository = productBradGenericRepository;
		}

		public void AddProductBrand(ProductBrandAddRequest productBrandAddRequest)
		{
			_productBradGenericRepository.AddEntity(new ProductBrand
			{
				Name = productBrandAddRequest.Name,
			});

			_productBradGenericRepository.SaveChanges();
		}

		public void DeleteProductBrand(int id)
		{
			var productBrand = GetProductBrandById(id);

			_productBradGenericRepository.DeleteEntity(productBrand);
			_productBradGenericRepository.SaveChanges();
		}

		public async Task<IEnumerable<ProductBrand>> GetAllProductBrands()
		{
			var productBrands = await _productBradGenericRepository.GetAllEntitiesAsNoTrackingAsync();

			return productBrands;
		}

		public ProductBrand GetProductBrandById(int id)
		{
			var productBrand = _productBradGenericRepository.GetEntityById(id);

			if (productBrand == null)
				throw new Exception("Not Found product brand");

			return productBrand;
		}
	}
}
