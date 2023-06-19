using System.Collections.Generic;
using System.Linq.Expressions;
using Template.DAL.Layer.ISpecification;

namespace Template.DAL.Layer.IGenericRepositoryService
{
	public interface IGenericRepository<TEntity> where TEntity : class
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="expression"></param>
		/// <returns></returns>
		public TEntity GetEntityWithSpecs(ISpecification<TEntity> specification);

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public TEntity GetEntityWithSpecsAsNoTracking(ISpecification<TEntity> specification);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public TEntity GetEntityById(int id);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public TEntity GetEntityByIdAsNoTracking(string id);

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Task<IEnumerable<TEntity>> GetAllEntitiesWithSpecsAsync(ISpecification<TEntity> specification);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="specification"></param>
		/// <returns></returns>
		public Task<IEnumerable<TEntity>> GetAllEntitiesWithSpecsAsNoTrackingAsync(ISpecification<TEntity> specification);

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Task<IEnumerable<TEntity>> GetAllEntitiesAsync();

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Task<IEnumerable<TEntity>> GetAllEntitiesAsNoTrackingAsync();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entity"></param>
		public void AddEntity(TEntity entity);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entity"></param>
		public void UpdateEntity(TEntity entity);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entity"></param>
		public void DeleteEntity(TEntity entity);

		/// <summary>
		/// 
		/// </summary>
		public void SaveChanges();

		/// <summary>
		/// 
		/// </summary>
		public void SaveChangesAsync();

	}
}
