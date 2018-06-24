using System.Data.Entity;
using SalaryApp.Repositoris.Entities;

namespace SalaryApp.Repositoris
{
    public class SalaryAppContext : DbContext
    {
        public SalaryAppContext()
            : base("name=SalaryAppContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Country> Countries { get; set; }



    }
}
