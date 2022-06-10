using Microsoft.AspNetCore.Mvc;

namespace CrudMvc.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
