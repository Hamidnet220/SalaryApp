namespace SalaryApp.Repositoris.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SalaryEntityModel : DbContext
    {
        public SalaryEntityModel()
            : base("name=SalaryEntityModel")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Banks> Banks { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Educations> Educations { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Genders> Genders { get; set; }
        public virtual DbSet<Insurances> Insurances { get; set; }
        public virtual DbSet<MilitaryServiceStatus> MilitaryServiceStatus { get; set; }
        public virtual DbSet<Salaries> Salaries { get; set; }
        public virtual DbSet<SalaryDetails> SalaryDetails { get; set; }
        public virtual DbSet<Workplaces> Workplaces { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banks>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.Banks)
                .HasForeignKey(e => e.BankName1Id);

            modelBuilder.Entity<Banks>()
                .HasMany(e => e.Employees1)
                .WithOptional(e => e.Banks1)
                .HasForeignKey(e => e.BankName2Id);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.Cities)
                .HasForeignKey(e => e.POBId);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.Employees1)
                .WithOptional(e => e.Cities1)
                .HasForeignKey(e => e.POIId);

            modelBuilder.Entity<Companies>()
                .HasMany(e => e.Salaries)
                .WithRequired(e => e.Companies)
                .HasForeignKey(e => e.CompanyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Companies>()
                .HasMany(e => e.Workplaces)
                .WithRequired(e => e.Companies)
                .HasForeignKey(e => e.CompanyId);

            modelBuilder.Entity<Countries>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.Countries)
                .HasForeignKey(e => e.Nationality_Id);

            modelBuilder.Entity<Employees>()
                .HasMany(e => e.SalaryDetails)
                .WithOptional(e => e.Employees)
                .HasForeignKey(e => e.Employee_Id);

            modelBuilder.Entity<Genders>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.Genders)
                .HasForeignKey(e => e.GenderId);

            modelBuilder.Entity<Insurances>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.Insurances)
                .HasForeignKey(e => e.InsuranceId);

            modelBuilder.Entity<Salaries>()
                .HasMany(e => e.SalaryDetails)
                .WithRequired(e => e.Salaries)
                .HasForeignKey(e => e.SalaryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Workplaces>()
                .HasMany(e => e.Salaries)
                .WithRequired(e => e.Workplaces)
                .HasForeignKey(e => e.WorkplaceId)
                .WillCascadeOnDelete(false);
        }
    }
}
