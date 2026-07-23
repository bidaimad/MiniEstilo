using MiniEstilo.Models.Entities;
using System.Collections.Generic;

namespace MiniEstilo.Data.Interfaces
{
    public interface IBrandRepository
    {
        bool Add(Brand brand);

        bool Update(Brand brand);

        bool Delete(int id);

        Brand? GetById(int id);

        List<Brand> GetAll();
    }
}
