using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.BusinessComponents
{
    public interface IBusinessManager<TId,T> where T : class
    {
        T Fetch(int id);
        List<T> FetchAll();
        T Insert(T entity);
        T Modify(TId id, T entity);
        T Remove(TId id);
    }
}
