using Microsoft.AspNetCore.Mvc;//miras alınan ViewComponent
using movieapp.Data;

namespace movieapp.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(CategoryRepository.Categories);
        }
    }
}