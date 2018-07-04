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
    public class SalaryDitailsRepository:Repository<SalaryDetail>,ISalaryDetailsRepository
    {
        private SalaryAppContext SalaryAppContext => (SalaryAppContext)Context;


        public SalaryDitailsRepository(DbContext context) : base(context)
        {
        }

        
        
        public IEnumerable<SalaryDetail> GetBySalaryId(int value)
        {
            return SalaryAppContext.SalaryDetails.Where(s=>s.SalaryId==value).ToList();
        }

        public IEnumerable<SalaryDetail> GetSalaryDetails(int value)
        {
           return SalaryAppContext.SalaryDetails.Where(s => s.SalaryId == value).ToList();
        }
    }
}
