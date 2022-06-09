using EF_DBConnect.Models;
using System.Collections.Generic;

namespace EF_DBConnect.Services.Interface
{
    public interface ICosmeticRepository
    {
        IEnumerable<Cosmetic> GetList();
        Cosmetic Create (Cosmetic entity);
        bool Delete (int id);
        Cosmetic Edit(Cosmetic entity);
        Cosmetic GetById(int id);
    }
}
