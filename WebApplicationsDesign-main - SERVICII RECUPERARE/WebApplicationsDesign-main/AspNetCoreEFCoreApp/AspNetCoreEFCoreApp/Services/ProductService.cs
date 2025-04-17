using AspNetCoreEFCoreApp.Models;
using AspNetCoreEFCoreApp.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AspNetCoreEFCoreApp.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Products> GetAll()
        {
            return _repository.GetAll();
        }

        public Products GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Add(Products product)
        {
            _repository.Add(product);
            
        }

        public void Update(Products product)
        {
            _repository.Update(product);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
