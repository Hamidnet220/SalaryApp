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
            throw new System.NotImplementedException();
        }

        public List<City> GetByCityName(string value)
        {
            throw new System.NotImplementedException();
        }

        public SalaryAppContext SalaryAppContext
        {
            get { return Context as SalaryAppContext; }
        }
    }
}
