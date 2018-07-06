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
    public class AttendanceRepository:Repository<Attendance>,IAttendanceRepository
    {
        public AttendanceRepository(DbContext context) : base(context)
        {
        }
    }
}
