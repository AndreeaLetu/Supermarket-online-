using AspNetCoreEFCoreApp.Models;
using System.Collections.Generic;

namespace AspNetCoreEFCoreApp.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Categories> GetAll();
        void Add(Categories category);
    }
}
