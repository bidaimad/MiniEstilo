using MiniEstilo.Models.Entities;
using System.Collections.Generic;

namespace MiniEstilo.Data.Interfaces
{
    public interface IAgeGroupRepository
    {
        bool Add(AgeGroup ageGroup);

        bool Update(AgeGroup ageGroup);

        bool Delete(int id);

        AgeGroup? GetById(int id);

        List<AgeGroup> GetAll();
    }
}
