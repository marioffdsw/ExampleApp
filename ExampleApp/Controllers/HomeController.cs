using System.Web.Mvc;
using ExampleApp.Models;

namespace ExampleApp.Controllers
{
    public class HomeController : Controller
    {
        Repository repo;

        public HomeController()
        {
            repo = Repository.Current;
        }

        public ActionResult Index()
        {
            return View( repo.Products );
        }
    }
}