namespace Template.Core.Layer.Dtos.Products
{
	public class ProductsGetRequest
	{
		private const int MAX_PAGE_SIZE = 50;
		public int? BrandId { get; set; }
		public int? TypeId { get; set; }
		public int PageIndex { get; set; } = 1;
		public string? Sort { get; set; }

		private int _pageSize = MAX_PAGE_SIZE;
		public int PageSize
		{
			set { _pageSize = (value > MAX_PAGE_SIZE) ? MAX_PAGE_SIZE : value; }
			get { return _pageSize; }
		}

		private string? _search;
		public string? Search
		{
			set { _search = value?.ToLower(); }
			get { return _search; }

		}
	}
}
