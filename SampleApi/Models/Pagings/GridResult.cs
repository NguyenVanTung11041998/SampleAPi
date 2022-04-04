using System.Collections.Generic;

namespace SampleApi.Models.Pagings
{
    public class GridResult<T> where T : class
    {
        public int TotalCount { get; set; }
        public IEnumerable<T> Items { get; set; }

        public GridResult(int totalCount, IEnumerable<T> items)
        {
            Items = items;
            TotalCount = totalCount;
        }
    }
}
