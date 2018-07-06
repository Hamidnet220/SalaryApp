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
        public virtual Employee Employee { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int D1 { get; set; }
        public int D2 { get; set; }
        public int D3 { get; set; }
        public int D4 { get; set; }
        public int D5 { get; set; }
        public int D6 { get; set; }
        public int D7 { get; set; }
        public int D8 { get; set; }
        public int D9 { get; set; }
        public int D10 { get; set; }
        public int D11 { get; set; }
        public int D12 { get; set; }
        public int D13 { get; set; }
        public int D14 { get; set; }
        public int D15 { get; set; }
        public int D16 { get; set; }
        public int D17 { get; set; }
        public int D18 { get; set; }
        public int D19 { get; set; }
        public int D20 { get; set; }
        public int D21 { get; set; }
        public int D22 { get; set; }
        public int D23 { get; set; }
        public int D24 { get; set; }
        public int D25 { get; set; }
        public int D26 { get; set; }
        public int D27 { get; set; }
        public int D28 { get; set; }
        public int D29 { get; set; }
        public int D30 { get; set; }
        public int D31 { get; set; }

        public int SumWorkDays { get; set; }
        public int SumDaysoff { get; set; }
        public int SumAbsentDays { get; set; }
        public int SumWorkDaysInFriday { get; set; }
        public int SumWorkDayInHoliday { get; set; }
        public float OverTimeHoures { get; set; }

    }
}
