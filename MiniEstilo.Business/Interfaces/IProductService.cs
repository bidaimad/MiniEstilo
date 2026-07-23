using MiniEstilo.Models.Entities;

namespace MiniEstilo.Business.Interfaces
{
    public interface IProductService
    {
        bool Add(Product product);

        bool Update(Product product);

        bool Delete(int id);

        Product? GetById(int id);

        List<Product> GetAll();
    }
}