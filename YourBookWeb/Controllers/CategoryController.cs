using Microsoft.AspNetCore.Mvc;
using YourBookWeb.Data;
using YourBookWeb.Models;

namespace YourBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db= db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList=_db.categories;
            return View(objCategoryList);
        }
    }
}
