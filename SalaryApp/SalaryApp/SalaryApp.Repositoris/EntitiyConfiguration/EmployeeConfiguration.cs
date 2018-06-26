using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryApp.Repositoris.Entities;

namespace SalaryApp.Repositoris.EntitiyConfiguration
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            
            Property(e => e.FirstName)
            .IsRequired()
            .HasMaxLength(50);


            Property(e => e.LastName)
            .IsRequired()
            .HasMaxLength(50);


            Property(e => e.NationalCode)
            .IsRequired()
            .HasMaxLength(10);


            Property(e => e.IdNumber)
            .IsRequired()
            .HasMaxLength(10);

            Property(e => e.BankAccNumber1)
                .HasMaxLength(50);

            Property(e => e.BankAccNumber2)
                .HasMaxLength(50);
        }
    }
}
