using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryApp.Repositoris.Entities
{
    public class Attendance
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int SumWorkDays { get; set; }
        public int SumDaysoff { get; set; }
        public int SumAbsentDays { get; set; }
        public int SumWorkDaysInFriday { get; set; }
        public int SumWorkDayInHoliday { get; set; }

    }
}
