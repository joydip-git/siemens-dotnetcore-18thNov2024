using ProductManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.BusinessComponents
{
    public interface IProductBusinessManager:IBusinessManager<int,Product>
    {
        List<Product> FilterProducts(string productName);
    }
}
