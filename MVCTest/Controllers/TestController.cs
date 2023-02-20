using Microsoft.AspNetCore.Mvc;

namespace MVCTest.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            ViewData["testItem"]=Guid.NewGuid();
            return View();
        }
    }
}
