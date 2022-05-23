using Microsoft.AspNetCore.Mvc;

namespace backend_karma.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult ProductDetails()
        {
            return View();
        }
    }
}
