using System.Collections.Generic;
using System.Web.Http;
using ExampleApp.Models;

namespace ExampleApp.Controllers
{
    public class ProductsController : ApiController
    {
        Repository repo;

        public ProductsController()
        {
            repo = Repository.Current;
        }

        public IEnumerable<Product> GetAll()
        {
            return repo.Products;
        }
    }
}
