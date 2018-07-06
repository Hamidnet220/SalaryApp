using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryApp.Repositoris.Repositories;
using SalaryApp.Repositoris.RpositoryInterfaces;

namespace SalaryApp.Repositoris
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly SalaryAppContext _context;

        public IBankRepository Banks { get; }
        public ICityRepository Cities { get; }
        public ICountryRepository Countries { get; }
        public ICompanyRepository Companies { get; }
        public IGenderRepository Genders { get; }
        public IEmployeeRepository Employees { get; }
        public IWorkplaceRepository Workplaces { get; }
        public ISalaryRepository Salaries { get; }
        public ISalaryDetailsRepository SalaryDetails { get; }

        public UnitOfWork(SalaryAppContext context)
        {
            _context = context;
            Banks=new BankRepository(_context);
            Cities=new CityRepository(_context);
            Countries=new CountryRepository(_context);
            Companies=new CompanyRepository(_context);
            Genders=new GenderRepository(_context);
            Employees=new EmployeeRepository(_context);
            Workplaces=new WorkplaceRepository(_context);
            Salaries=new SalaryRepository(_context);
            SalaryDetails=new SalaryDitailsRepository(_context);
            
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
    }

