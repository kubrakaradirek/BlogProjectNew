using Microsoft.AspNetCore.Mvc;

namespace BlogProjectNew.Mvc.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
