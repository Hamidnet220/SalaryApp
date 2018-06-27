using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryApp.Repositoris.Entities
{
    public class SalaryDetail
    {
        public int Id { get; set; }
        public int SalaryId { get; set; }
        public Salary Salary { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }


    }
}
