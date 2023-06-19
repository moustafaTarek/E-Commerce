using Microsoft.Extensions.DependencyInjection;
using Template.Core.Layer.IServices;
using Template.Core.Layer.Services;
using Template.DAL.Layer;

namespace Template.Core.Layer
{
	public static class ServiceCollectionsExtension
	{
		public static IServiceCollection AddCoreDependencies(this IServiceCollection serviceCollection)
		{
			return
				serviceCollection
				.AddScoped<IProductService, ProductService>()
				.AddScoped<IProductBrandService, ProductBrandService>()
				.AddScoped<IProductTypeService, ProductTypeService>()
				.AddDalDependencies();
		}
	}
}
