using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.DAL.Layer.Entities.BaseEntity;
using Template.DAL.Layer.ISpecification;

namespace Template.DAL.Layer.Specification
{
	public class SpecificationEvaluator<TEntity> where TEntity : class
	{
		public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> specification)
		{
			IQueryable<TEntity> query = inputQuery;

			if(specification.Criteria != null)
				query = query.Where(specification.Criteria);

			if(specification.OrderBy != null)
				query = query.OrderBy(specification.OrderBy);

			if (specification.OrderByDescending != null)
				query = query.OrderByDescending(specification.OrderByDescending);

			if (specification.IsPagingEnabled)
				query = query.Skip(specification.Skip).Take(specification.Take);

			if (specification.Includes.Count() != 0)
				query = specification.Includes.Aggregate(query, (current, include)=> current.Include(include));
			
			return query;
		}
	}
}
