using System.Data.Entity;
using SalaryApp.Repositoris.Entities;
using SalaryApp.Repositoris.EntitiyConfiguration;

namespace SalaryApp.Repositoris
{
    public class SalaryAppContext : DbContext
    {
        public SalaryAppContext()
            : base("name=SalaryAppContext")
        {
            this.Configuration.LazyLoadingEnabled = true;

        }

        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Insurance> Insurances { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<MilitaryServiceStatus> MilitaryServiceStatus { get; set; }
        public virtual DbSet<Workplace> Workplaces { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<SalaryDetail> SalaryDetails { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<TaxGroup> TaxGroups { get; set; }
        public virtual DbSet<InsuranceGroup> InsuranceGroups { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeConfiguration());

            modelBuilder.Entity<Company>()
                .HasMany(c => c.Workplaces)
                .WithRequired(w => w.Company)
                .HasForeignKey(w => w.CompanyId);
           
            base.OnModelCreating(modelBuilder);
        }
    }
}
