using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using SalaryApp.Repositoris.Entities;
using SalaryApp.Repositoris.RpositoryInterfaces;

namespace SalaryApp.Repositoris.Repositories

{
    public class CityRepository:Repository<City>, ICityRepository
    {

        public CityRepository(SalaryAppContext context) 
            : base(context)
        {

        }

        public List<City> GetById(int value)
        {
            return null;
        }

        public List<City> GetByCityName(string value)
        {
            throw new System.NotImplementedException();
        }

        public SalaryAppContext SalaryAppContext => Context as SalaryAppContext;
    }
}
