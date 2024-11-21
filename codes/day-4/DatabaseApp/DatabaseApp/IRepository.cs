
namespace DatabaseApp
{
    public interface IRepository<T> where T : class
    {
        int AddData(T entity);
        int DeleteData(int id);
        List<T> FetchData();
    }
}