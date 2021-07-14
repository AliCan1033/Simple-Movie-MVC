using System.Linq;//Where gibi sql komutları için
using Microsoft.AspNetCore.Mvc;
using movieapp.Data;
using movieapp.Models;

namespace movieapp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index(int? id)//soru işareti zorunluluğu ortadan kaldırır. oladabilir olmayadabilir anlamında
        {
            // MovieCategory model =new MovieCategory();
            // model.Categories=CategoryRepository.Categories;
            // model.Movies=MovieRepository.Movies;
            var movies = MovieRepository.Movies;
            if (id!=null)
            {
                movies=movies.Where(i =>i.CategoryId==id).ToList();
            }
            return View(movies);
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