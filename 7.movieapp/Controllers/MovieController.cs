using Microsoft.AspNetCore.Mvc;

namespace movieapp.Controllers
{
    public class MovieController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        
    }
}