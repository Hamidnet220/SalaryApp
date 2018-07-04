using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryApp.Repositoris.Entities;

namespace SalaryApp.Repositoris.RpositoryInterfaces
{
    public interface ISalaryDetailsRepository:IRepository<SalaryDetail>
    {
        IEnumerable<SalaryDetail> GetBySalaryId(int value);
        IEnumerable<SalaryDetail> GetSalaryDetails(int value);
    }
}
