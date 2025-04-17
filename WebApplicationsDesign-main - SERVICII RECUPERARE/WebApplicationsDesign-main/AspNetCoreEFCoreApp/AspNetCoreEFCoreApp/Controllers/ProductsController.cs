using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspNetCoreEFCoreApp.Models;

namespace AspNetCoreEFCoreApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly SupermarketContext _context;

        public ProductsController(SupermarketContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var supermarketContext = _context.Products.Include(p => p.Categories);
            return View(await supermarketContext.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.Categories)
                .FirstOrDefaultAsync(m => m.Id_Product == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["Id_Categories"] = _context.Categories
                .Select(c => new SelectListItem
                {
                    Value = c.Id_Categories.ToString(),
                    Text = $"{c.Id_Categories} - {c.Name_Categories}"
                }).ToList();

            return View();
        }
        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Product,Name_Product,Price_Product,Image_Product,Description_Product,Id_Categories")] Products products)
        {
            if (ModelState.IsValid)
            {
                _context.Add(products);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id_Categories"] = _context.Categories
            .Select(c => new SelectListItem
            {
                Value = c.Id_Categories.ToString(),
                Text = c.Id_Categories + " - " + c.Name_Categories
            }).ToList();


            return View(products);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }

            // Aici setăm ca text vizibil atât ID-ul cât și numele categoriei
            ViewData["Id_Categories"] = new SelectList(
                _context.Categories,
                "Id_Categories",
                "Name_Categories", // <- asta e cheia
                products.Id_Categories
            );

            return View(products);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Product,Name_Product,Price_Product,Image_Product,Description_Product,Id_Categories")] Products products)
        {
            if (id != products.Id_Product)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(products);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsExists(products.Id_Product))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id_Categories"] = new SelectList(_context.Categories, "Id_Categories", "Id_Categories", products.Id_Categories);
            return View(products);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.Categories)
                .FirstOrDefaultAsync(m => m.Id_Product == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var products = await _context.Products.FindAsync(id);
            if (products != null)
            {
                _context.Products.Remove(products);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsExists(int id)
        {
            return _context.Products.Any(e => e.Id_Product == id);
        }
    }
}
