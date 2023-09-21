using Microsoft.AspNetCore.Mvc;

namespace dotNetCRUDApplication.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
