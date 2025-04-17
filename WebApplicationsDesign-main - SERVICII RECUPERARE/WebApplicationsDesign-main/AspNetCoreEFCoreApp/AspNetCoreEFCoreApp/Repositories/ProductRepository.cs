using AspNetCoreEFCoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCoreEFCoreApp.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly SupermarketContext _context;

        public ProductRepository(SupermarketContext context)
        {
            _context = context;
        }

        public IEnumerable<Products> GetAll()
        {
            return _context.Products.Include(p => p.Categories).ToList();
        }

        public Products GetById(int id)
        {
            return _context.Products.Include(p => p.Categories)
                                    .FirstOrDefault(p => p.Id_Product == id);
        }

        public void Add(Products product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Update(Products product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
