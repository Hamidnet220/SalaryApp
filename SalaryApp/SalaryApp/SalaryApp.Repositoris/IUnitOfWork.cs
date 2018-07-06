using System;
using SalaryApp.Repositoris.Repositories;
using SalaryApp.Repositoris.RpositoryInterfaces;

namespace SalaryApp.Repositoris
{
    public interface IUnitOfWork:IDisposable
    {
        IBankRepository Banks { get; }
        ICityRepository Cities { get; }
        ICountryRepository Countries { get; }
        IGenderRepository Genders { get; }
        IEmployeeRepository Employees { get; }
        IWorkplaceRepository Workplaces { get; }
        ISalaryRepository Salaries { get; }
        
        int Complete();
    }
}
