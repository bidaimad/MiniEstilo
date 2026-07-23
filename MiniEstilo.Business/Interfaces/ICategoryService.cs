using MiniEstilo.Models.Entities;
using System.Collections.Generic;

namespace MiniEstilo.Business.Interfaces
{
    public interface ICategoryService
    {
        bool Add(Category category);

        bool Update(Category category);

        bool Delete(int id);

        Category? GetById(int id);

        List<Category> GetAll();
    }
}
