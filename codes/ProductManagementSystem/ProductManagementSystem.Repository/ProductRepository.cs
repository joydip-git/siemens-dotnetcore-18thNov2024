using ProductManagementSystem.Models;
using ProductManagementSystem.Storage;
using System.Data;
using static ProductManagementSystem.Repository.Utility.DbUtility;
using static ProductManagementSystem.Repository.Utility.DbQueries;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProductManagementSystem.Repository.Utility;

namespace ProductManagementSystem.Repository
{
    public class ProductRepository : IProductRepositoryManager
    {
        public ProductRepository()
        {
            
        }
        public Product Add(Product entity)
        {
            //var result = DataStorage.Products.Add(entity);
            //return result ? entity : throw new Exception("could not add Product");
            IDbConnection connection = null;
            IDbCommand command = null;

            try
            {
                connection = CreateConnection();
                command = CreateCommand(INSERT_QUERY, connection);
                command.Parameters.Add(entity);

                IDbDataParameter nameParam = CreateParameter("@name", entity.Name, DbType.String);
                IDbDataParameter descParam = CreateParameter("@desc", entity.Description, DbType.String);
                IDbDataParameter priceParam = CreateParameter("@price", entity.Price, DbType.Decimal);
                IDbDataParameter cidParam = CreateParameter("@cid", entity.CategoryId, DbType.Int32);

                command.Parameters.Add(nameParam);
                command.Parameters.Add(descParam);
                command.Parameters.Add(priceParam);
                command.Parameters.Add(cidParam);

                connection.Open();
                var result = command.ExecuteNonQuery();
                return result > 0 ? entity : throw new Exception("could not add");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection(connection);
            }
        }

        public Product Delete(int id)
        {
            var product = FindProduct(id);
            var result = DataStorage.Products.Remove(product);
            return result ? product : throw new Exception("could not delete Product");
        }

        public List<Product> FilterProducts(string productName)
        {
            return DataStorage.Products.Where(p => p.Name.Contains(productName, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        public Product Get(int id)
        {
            return FindProduct(id);
        }

        public List<Product> GetAll()
        {
            //return DataStorage.Products.ToList();
            IDbConnection connection = null;
            IDbCommand command = null;
            IDataReader reader = null;
            List<Product> products = null;
            try
            {
                connection = CreateConnection();
                command = CreateCommand(SELECT_ALL_QUERY, connection);

                connection.Open();
                reader = command.ExecuteReader();
                if (((SqlDataReader)reader).HasRows)
                {
                    products = new List<Product>();
                    while (reader.Read())
                    {
                        products.Add(
                            new Product
                            {
                                Name = (string)reader["product_name"],
                                Id = (int)reader["product_id"],
                                Price = (decimal)reader["price"],
                                Description = (string)reader["product_description"],
                                CategoryId = (int)reader["category_id"]
                            }
                        );
                    }
                }
                reader.Close();
                return products;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                CloseConnection(connection);
            }
        }

        public Product Update(int id, Product entity)
        {
            var product = FindProduct(id);
            product.Price = entity.Price;
            product.Name = entity.Name;
            product.Description = entity.Description;
            product.CategoryId = entity.CategoryId;
            return product;
        }
        private static Product FindProduct(int id)
        {
            var all = DataStorage.Products.Where(p => p.Id == id);
            if (all != null && all.Any())
            {
                var found = all.First();
                return found;
            }
            else
                throw new Exception($"product with id {id} not found..");
        }
    }
}
