using Template.Core.Layer.Dtos.Products;
using Template.DAL.Layer.Entities;
using Template.DAL.Layer.Specification.Base;

namespace Template.Core.Layer.Specifications
{
	internal class ProductsSpecification : BaseSpecification<Product>
	{
		public ProductsSpecification(ProductsGetRequest productsGetRequest)
			: base( product => ((!productsGetRequest.BrandId.HasValue || product.ProductBrandId == productsGetRequest.BrandId) &&
							   (!productsGetRequest.TypeId.HasValue  || product.ProductTypeId == productsGetRequest.TypeId) &&
							   (string.IsNullOrWhiteSpace(productsGetRequest.Search) || product.Name.Contains(productsGetRequest.Search)))
				  )
		{
			AddInclude(e => e.ProductBrand);
			AddInclude(e => e.ProductType);

			AddPaging(productsGetRequest.PageSize*(productsGetRequest.PageIndex-1), productsGetRequest.PageSize);

			switch (productsGetRequest.Sort)
			{
				case "Asc":
					AddOrderBy(e=>e.Price);
					break;

				case "Desc":
					AddOrderByDescending(e=>e.Price);
					break;

				default:
					AddOrderBy(e => e.Name);
					break;
			}
		}

		public ProductsSpecification(int id) : base(x => x.Id == id)
		{
			AddInclude(x => x.ProductBrand);
			AddInclude(x => x.ProductType);
		}
	}
}
