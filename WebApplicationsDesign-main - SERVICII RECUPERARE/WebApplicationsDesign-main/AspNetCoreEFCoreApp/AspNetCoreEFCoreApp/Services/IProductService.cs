using AspNetCoreEFCoreApp.Models;
using System.Collections.Generic;

namespace AspNetCoreEFCoreApp.Services
{
    public interface IProductService
    {
        IEnumerable<Products> GetAll();
        Products GetById(int id);
        void Add(Products product);
        void Update(Products product);
        void Delete(int id);
   
    }
}
