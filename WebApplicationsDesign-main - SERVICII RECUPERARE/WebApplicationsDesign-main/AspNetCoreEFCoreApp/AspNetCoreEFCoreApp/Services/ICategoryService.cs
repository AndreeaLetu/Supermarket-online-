using AspNetCoreEFCoreApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreEFCoreApp.Services
{
    public interface ICategoryService
    {
        IEnumerable<Categories> GetAll();
        Task AddCategoryAsync(Categories category); // totul ok aici
    }
}
