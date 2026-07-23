using MiniEstilo.Business.Interfaces;
using MiniEstilo.Data.Interfaces;
using MiniEstilo.Models.Entities;
using System.Collections.Generic;

namespace MiniEstilo.Business.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public bool Add(Category category)
        {
            return _repository.Add(category);
        }

        public bool Update(Category category)
        {
            return _repository.Update(category);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public Category? GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Category> GetAll()
        {
            return _repository.GetAll();
        }
    }
}