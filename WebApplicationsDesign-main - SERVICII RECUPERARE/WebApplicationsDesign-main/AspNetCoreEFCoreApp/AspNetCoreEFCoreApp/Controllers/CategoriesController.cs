using AspNetCoreEFCoreApp.Models;
using AspNetCoreEFCoreApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AspNetCoreEFCoreApp.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: Categories
        [HttpGet]
        public IActionResult Index()
        {
            var categorii = _categoryService.GetAll();
            return View(categorii); // trimitem lista către view
        }

        // POST: Categories
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Categories category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _categoryService.AddCategoryAsync(category);
                    ViewBag.Mesaj = "✅ Categoria a fost adăugată cu succes!";
                    ModelState.Clear(); // reset form
                }
                catch (Exception ex)
                {
                    ViewBag.Eroare = "❌ Eroare la salvare: " + ex.Message;
                }
            }

            var categorii = _categoryService.GetAll();
            return View(categorii); // retrimitem lista în view după post
        }
    }
}
