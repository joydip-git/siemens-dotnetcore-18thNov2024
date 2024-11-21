namespace ProductManagementSystem.Repository.Utility
{
    internal static class DbQueries
    {
        public const string INSERT_QUERY = "insert into products(product_name,product_description,price,category_id) values(@name,@desc,@price,@cid)";
        public const string SELECT_ALL_QUERY = "select product_id,product_name,product_description,price,category_id from products";
    }
}
