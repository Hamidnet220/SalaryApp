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
        public SalaryDitailsRepository(DbContext context) : base(context)
        {
        }

        private SalaryAppContext SalaryAppContext => (SalaryAppContext)Context;
    }
}
