using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductServiceAPI.Models;

namespace ProductServiceAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly SiemensDbContext dbContext;
        readonly ILogger<ProductController> logger;

        public ProductController(SiemensDbContext dbContext, ILogger<ProductController> logger)
        {
            this.dbContext = dbContext;
            this.logger = logger;
        }

        [Route("hello")]
        [HttpGet]
        public string GetData()
        {
            return "hello world....";
        }

        [Route("welcome/{name}")]
        [HttpGet]
        public string GetData(string name)
        {
            return "welcome " + name;
        }

        [Route("all")]
        [HttpGet]
        public ActionResult<List<Product>> Getproducts()
        {
            try
            {
                var all = dbContext.Products.ToList();
                return this.Ok(all);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
    }
}
