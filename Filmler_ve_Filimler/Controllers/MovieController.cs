using Filmler_ve_Filimler.Data;
using Filmler_ve_Filimler.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Filmler_ve_Filimler.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MovieController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Movies.ToList();
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
                _context.Movies.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
