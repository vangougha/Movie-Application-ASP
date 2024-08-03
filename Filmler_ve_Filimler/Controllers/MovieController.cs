using Filmler_ve_Filimler.Models;
using Microsoft.AspNetCore.Mvc;

namespace Filmler_ve_Filimler.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Movies;
            return View(model);
        }

        // GET ile çalışan metod
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add([FromForm] MovieViewModel model)
        {
            if (ModelState.IsValid)
            {
                Repository.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
