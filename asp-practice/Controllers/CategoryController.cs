using asp_practice.Data;
using asp_practice.Models;
using asppractice.Migrations;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;
using Category = asp_practice.Models.Category;

namespace asp_practice.Controllers
{
    public class CategoryController : Controller
    {
        private AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categories = _context.Categories;
            return View(categories);
        }
    }
}
