using MiniEstilo.Models.Entities;
using System.Collections.Generic;

namespace MiniEstilo.Data.Interfaces
{
    public interface IProductRepository
    {
        bool Add(Product product);

        bool Update(Product product);

        bool Delete(int id);

        Product? GetById(int id);

        List<Product> GetAll();

        List<Product> Search(string keyword);
    }
}