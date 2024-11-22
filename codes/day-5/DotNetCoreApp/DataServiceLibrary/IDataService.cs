namespace DataServiceLibrary
{
    public interface IDataService<T> where T : class
    {
        T GetData();
    }
}