using System.Linq.Expressions;
using Template.DAL.Layer.ISpecification;

namespace Template.DAL.Layer.Specification.Base
{
	public class BaseSpecification<T> : ISpecification<T> where T : class
	{
		public Expression<Func<T, bool>> Criteria { get; }
		public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();
		public Expression<Func<T, object>> OrderBy { get; private set; }
		public Expression<Func<T, object>> OrderByDescending { get; private set; }

		public int Skip { get; private set; }
		public int Take { get; private set; }
		public bool IsPagingEnabled { get; private set; }

		public BaseSpecification(Expression<Func<T, bool>> criteria)
		{
			Criteria = criteria;
		}

		public void AddOrderBy(Expression<Func<T, object>> orderBy)
		{
			OrderBy = orderBy;
		}

		public void AddOrderByDescending(Expression<Func<T, object>> orderByDescending)
		{
			OrderByDescending = orderByDescending;
		}

		public void AddInclude(Expression<Func<T, object>> includes)
		{
			Includes.Add(includes);
		}

		public void AddPaging(int skip, int take)
		{
			Skip = skip;
			Take = take;
			IsPagingEnabled = true;
		}
	}
}

