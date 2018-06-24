using System.Collections.Generic;
using SalaryApp.Repositoris.Entities;

namespace SalaryApp.Repositoris.RpositoryInterfaces
{
    public interface IBankRepository :IRepository<Bank>
    {
        IEnumerable<Bank> GetById(int value);
        IEnumerable<Bank> GetByTitle(string value);
    }
}
