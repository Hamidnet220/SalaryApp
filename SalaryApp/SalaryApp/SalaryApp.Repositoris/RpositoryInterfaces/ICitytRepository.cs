using System.Collections.Generic;
using SalaryApp.Repositoris.Entities;

namespace SalaryApp.Repositoris.RpositoryInterfaces
{
    public interface ICityRepository :IRepository<City>
    {
        List<City> GetById(int value);
        List<City> GetByCityName(string value);
    }
}
