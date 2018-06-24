using System;
using SalaryApp.Repositoris.Repositories;
using SalaryApp.Repositoris.RpositoryInterfaces;

namespace SalaryApp.Repositoris
{
    public interface IUnitOfWork:IDisposable
    {
        IBankRepository Banks { get; }
        ICityRepository Cities { get; }
        IGenderRepository Genders { get; }
        IEmployeeRepository Employees { get; }
        
        int Complete();
    }
}
