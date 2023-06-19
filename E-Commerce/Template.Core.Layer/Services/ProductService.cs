using Template.Core.Layer.Dtos.Products;
using Template.Core.Layer.IServices;
using Template.Core.Layer.Specifications;
using Template.DAL.Layer.Entities;
using Template.DAL.Layer.IGenericRepositoryService;

namespace Template.Core.Layer.Services
{
	internal class ProductService : IProductService
	{
		private readonly IGenericRepository<Product> _productRepository;

        public ProductService(IGenericRepository<Product> productRepository)
        {
			_productRepository = productRepository;

		}

		public async Task<IEnumerable<Product>> GetAllProducts(ProductsGetRequest productsGetRequest)
		{
			ProductsSpecification productsSpecification = new ProductsSpecification(productsGetRequest);

			var product = await _productRepository.GetAllEntitiesWithSpecsAsync(productsSpecification);
			return product;
		}

		public Product GetProductById(int id)
		{
			ProductsSpecification productsSpecification = new ProductsSpecification(id);

			var product = _productRepository.GetEntityWithSpecs(productsSpecification);
			return product;
		}

		public void AddProduct(ProductAddRequest productAddRequest)
		{
			_productRepository.AddEntity(new Product
			{
				Name = productAddRequest.Name,
				Description =  productAddRequest.Description,
				Price = productAddRequest.Price,
				ProductBrandId = productAddRequest.BrandId,
				ProductTypeId = productAddRequest.TypeId,
				PictureUrl = productAddRequest.PictureUrl,
			});

			_productRepository.SaveChanges();
		}

		public void DeleteProduct(int id)
		{
			_productRepository.DeleteEntity(GetProductById(id));

			_productRepository.SaveChanges();
		}
	}
}
