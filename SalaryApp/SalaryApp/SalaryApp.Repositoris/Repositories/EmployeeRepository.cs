using System.Data.Entity;
using SalaryApp.DataLayer;
using SalaryApp.Repositoris.DataLayer;
using SalaryApp.Repositoris.Entities;
using SalaryApp.Repositoris.RpositoryInterfaces;

namespace SalaryApp.Repositoris.Repositories
{
    public class EmployeeRepository:Repository<Employee>,IEmployeeRepository
    {
        public EmployeeRepository(DbContext context) : base(context)
        {
        }

        private SalaryAppContext SalaryAppContext => (SalaryAppContext)Context;

    }
}
