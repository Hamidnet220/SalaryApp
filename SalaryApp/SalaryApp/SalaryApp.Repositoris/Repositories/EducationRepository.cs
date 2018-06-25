﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryApp.Repositoris.Entities;
using SalaryApp.Repositoris.RpositoryInterfaces;

namespace SalaryApp.Repositoris.Repositories
{
    public class EducationRepository:Repository<Education>,IEducationRepository
    {
        public EducationRepository(DbContext context) : base(context)
        {
        }
    }
}
