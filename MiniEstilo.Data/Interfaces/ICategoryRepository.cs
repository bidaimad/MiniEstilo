using MiniEstilo.Models.Entities;

namespace MiniEstilo.Data.Interfaces
{
    public interface ICategoryRepository
    {
        bool Add(Category category);

        bool Update(Category category);

        bool Delete(int id);

        Category? GetById(int id);

        List<Category> GetAll();
    }
}