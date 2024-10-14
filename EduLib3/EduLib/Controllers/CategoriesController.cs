using Microsoft.AspNetCore.Mvc;

namespace EduLib.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit(int id)
        { 
            return View();
        }
        public IActionResult Delete(int id)
        {
            return View();
        }

    }
}
