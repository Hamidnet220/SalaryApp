using System.Collections.Generic;

namespace SalaryApp.Repositoris.Entities
{
    public class Salary
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual Workplace Workplace { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public decimal SumSalary { get; set; }
        public decimal SumTax { get; set; }
        public decimal SumInsurance { get; set; }
        public int EmployeesCount { get; set; }
        public bool IsLocked { get; set; }

        public virtual ICollection<SalaryDetail> SalaryDetails { get; set; }
    }
}
