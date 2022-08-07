namespace CBR_Exchange_Rate_App.Domain.Models.Pagination
{
    public class Pagination<DataCollection>
    {
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public int TotalCount { get; private set; }
        public int PagesCount { get; private set; }
        public IEnumerable<DataCollection> Data { get; private set; }

        public Pagination(int pageSize, int pageIndex, IEnumerable<DataCollection> dataCollection)
        {
            PageSize = pageSize;
            PageIndex = pageIndex;
            TotalCount = dataCollection.Count();
            PagesCount = Convert.ToInt16(Math.Ceiling(Convert.ToDouble(TotalCount) / Convert.ToDouble(PageSize)));
            
            Data = dataCollection.Skip((PageIndex - 1) * PageSize).Take(PageSize);
        }
        public static Pagination<DataCollection> GetPaginatedData(IEnumerable<DataCollection> dataCollection, int pageSize, int pageIndex)
        {
            return new Pagination<DataCollection>(pageSize, pageIndex, dataCollection);
        }

    }
}
