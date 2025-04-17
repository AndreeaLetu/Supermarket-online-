using AspNetCoreEFCoreApp.Models;
using AspNetCoreEFCoreApp.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreEFCoreApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Categories> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task AddCategoryAsync(Categories category)
        {
            await Task.Run(() => _repository.Add(category));
        }
    }
}
