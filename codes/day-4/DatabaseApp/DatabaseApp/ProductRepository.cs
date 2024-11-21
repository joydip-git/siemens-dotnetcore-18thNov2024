using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp
{
    public class ProductRepository : IRepository<Product>
    {
        public int AddData(Product entity)
        {
            return 0;
        }

        public int DeleteData(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> FetchData()
        {
            throw new NotImplementedException();
        }
    }
}
