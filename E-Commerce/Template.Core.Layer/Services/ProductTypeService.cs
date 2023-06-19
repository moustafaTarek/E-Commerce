using Template.Core.Layer.Dtos.ProductTypes;
using Template.Core.Layer.IServices;
using Template.DAL.Layer.Entities;
using Template.DAL.Layer.IGenericRepositoryService;

namespace Template.Core.Layer.Services
{
	internal class ProductTypeService : IProductTypeService
	{
		private readonly IGenericRepository<ProductType> _productTypeRepository;

        public ProductTypeService(IGenericRepository<ProductType> productTypeRepository)
        {
			_productTypeRepository = productTypeRepository;
		}

        public void AddProductType(ProductTypeAddRequest productTypeAddRequest)
		{
			_productTypeRepository.AddEntity(new ProductType
			{
				Name = productTypeAddRequest.Name,
				Description = productTypeAddRequest.Description,
			});
			
			_productTypeRepository.SaveChanges();
		}

		public void DeleteProductType(int id)
		{
			var productBrand = GetProductTypeById(id);

			_productTypeRepository.DeleteEntity(productBrand);
			_productTypeRepository.SaveChanges();
		}

		public async Task<IEnumerable<ProductType>> GetAllProductTypes()
		{
			var productBrands = await _productTypeRepository.GetAllEntitiesAsNoTrackingAsync();

			return productBrands;
		}

		public ProductType GetProductTypeById(int id)
		{
			var productBrand = _productTypeRepository.GetEntityById(id);

			if (productBrand == null)
				throw new Exception("Not Found");

			return productBrand;
		}
	}
}