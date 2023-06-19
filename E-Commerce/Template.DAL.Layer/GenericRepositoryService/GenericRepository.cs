using Microsoft.EntityFrameworkCore;
using Template.DAL.Layer.Db;
using Template.DAL.Layer.IGenericRepositoryService;
using Template.DAL.Layer.ISpecification;
using Template.DAL.Layer.Specification;

namespace Template.DAL.Layer.GenericRepositoryService
{
	internal class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
	{
		private readonly ApplicationDbContext _applicationDbContext;
		private readonly DbSet<TEntity> _entity;

        public GenericRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            _entity = _applicationDbContext.Set<TEntity>();
        }

		public void AddEntity(TEntity entity)
		{
			_entity.Add(entity);
		}

		public void DeleteEntity(TEntity entity)
		{
			_entity.Remove(entity);
		}

		public async Task<IEnumerable<TEntity>> GetAllEntitiesAsync()
		{
			return await _entity.ToListAsync();
		}

		public async Task<IEnumerable<TEntity>> GetAllEntitiesAsNoTrackingAsync()
		{
			return await _entity.AsNoTracking().ToListAsync();
		}

		public async Task<IEnumerable<TEntity>> GetAllEntitiesWithSpecsAsync(ISpecification<TEntity> specification)
		{
			return await GetQueryWithSpecs(specification).ToListAsync();
		}

		public async Task<IEnumerable<TEntity>> GetAllEntitiesWithSpecsAsNoTrackingAsync(ISpecification<TEntity> specification)
		{
			return await GetQueryWithSpecs(specification).AsNoTracking().ToListAsync();
		}

		public TEntity GetEntityById(int id)
		{
			return _entity.Find(id);
		}

		public TEntity GetEntityByIdAsNoTracking(string id)
		{
			return _entity.Find(id);
		}

		public TEntity GetEntityWithSpecs(ISpecification<TEntity> specification)
		{
			return GetQueryWithSpecs(specification).FirstOrDefault();
		}

		public TEntity GetEntityWithSpecsAsNoTracking(ISpecification<TEntity> specification)
		{
			return GetQueryWithSpecs(specification).AsNoTracking().FirstOrDefault();
		}

		public void UpdateEntity(TEntity entity)
		{
			_entity.Update(entity);
		}

		public void SaveChanges()
		{
			_applicationDbContext.SaveChanges();
		}

		public void SaveChangesAsync()
		{
			_applicationDbContext.SaveChangesAsync();
		}

		private IQueryable<TEntity> GetQueryWithSpecs(ISpecification<TEntity> specification)
		{
			return SpecificationEvaluator<TEntity>.GetQuery(_entity.AsQueryable(), specification);
		}
	}
}
