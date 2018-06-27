using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryApp.Repositoris.Entities
{
    public class Salary
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int WorkplaceId { get; set; }
        public Workplace Workplace { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int EmployeesCount { get; set; }
        public bool IsLocked { get; set; }

        public virtual ICollection<SalaryDetail> SalaryDetails { get; set; }
    }
}
