using System.Collections.Generic;
using System.Linq;
using SalaryApp.DataLayer;
using SalaryApp.Repositoris.DataLayer;
using SalaryApp.Repositoris.Entities;
using SalaryApp.Repositoris.RpositoryInterfaces;

namespace SalaryApp.Repositoris.Repositories
{
    public class BankRepository:Repository<Bank>,IBankRepository
    {

        public BankRepository(SalaryAppContext context) 
            : base(context)
        {
          
        }


        public IEnumerable<Bank> GetById(int id)
        {
            return SalaryAppContext.Banks.Take(id).ToList();
        }

        IEnumerable<Bank> IBankRepository.GetByTitle(string value)
        {
            return SalaryAppContext.Banks.Where(b=>b.Title==value).ToList();
        }

        public  SalaryAppContext SalaryAppContext => (SalaryAppContext)Context ;
    }
}
