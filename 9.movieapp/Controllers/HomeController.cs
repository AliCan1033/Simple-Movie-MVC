using Microsoft.AspNetCore.Mvc;
using movieapp.Data;
using movieapp.Models;

namespace movieapp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            // MovieCategory model =new MovieCategory();
            // model.Categories=CategoryRepository.Categories;
            // model.Movies=MovieRepository.Movies;
            return View(MovieRepository.Movies);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            // MovieCategory model = new MovieCategory();
            // model.Categories=CategoryRepository.Categories;
            // model.Movie= (MovieRepository.GetById(id));
            return View(MovieRepository.GetById(id));
        }
                
    }
}