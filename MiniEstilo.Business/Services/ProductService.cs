using MiniEstilo.Business.Interfaces;
using MiniEstilo.Data.Interfaces;
using MiniEstilo.Models.Entities;
using System.Collections.Generic;

namespace MiniEstilo.Business.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public bool Add(Product product)
        {
            return _repository.Add(product);
        }

        public bool Update(Product product)
        {
            return _repository.Update(product);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public Product? GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Product> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
