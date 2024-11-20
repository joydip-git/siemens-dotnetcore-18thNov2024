using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Repository
{
    public interface IRepositoryManager<TId, T> where T : class
    {
        T Get(int id);
        List<T> GetAll();
        T Add(T entity);
        T Update(TId id, T entity);
        T Delete(TId id);
    }
}
