using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryApp.Repositoris.Entities;
using SalaryApp.Repositoris.RpositoryInterfaces;

namespace SalaryApp.Repositoris.Repositories
{
    public class CountryRepository:Repository<Country>,ICountryRepository
    {
        public CountryRepository(DbContext context) : base(context)
        {
        }

        private SalaryAppContext SalaryAppContext => (SalaryAppContext) Context;
    }
}
