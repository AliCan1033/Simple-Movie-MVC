using Microsoft.AspNetCore.Mvc;
using movieapp.Models;

namespace movieapp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View(MovieRepository.Movies);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            return View(MovieRepository.GetById(id));
        }
                
    }
}