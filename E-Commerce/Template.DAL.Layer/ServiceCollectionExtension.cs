using Microsoft.Extensions.DependencyInjection;
using Template.DAL.Layer.GenericRepositoryService;
using Template.DAL.Layer.IGenericRepositoryService;

namespace Template.DAL.Layer
{
	public static class ServiceCollectionExtension
	{
		public static IServiceCollection AddDalDependencies(this IServiceCollection serviceCollection) 
		{
			return
				serviceCollection.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
		}
	}
}
