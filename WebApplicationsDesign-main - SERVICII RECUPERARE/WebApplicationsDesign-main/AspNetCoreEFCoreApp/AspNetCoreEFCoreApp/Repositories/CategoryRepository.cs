using AspNetCoreEFCoreApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCoreEFCoreApp.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly SupermarketContext _context;

        public CategoryRepository(SupermarketContext context)
        {
            _context = context;
        }

        public IEnumerable<Categories> GetAll()
        {
            return _context.Categories.ToList();
        }
        public void Add(Categories category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

    }
}
