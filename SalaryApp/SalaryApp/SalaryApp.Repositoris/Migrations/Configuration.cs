using SalaryApp.Repositoris.DataLayer;

namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SalaryAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            
        }

        protected override void Seed(SalaryAppContext context)
        {
           //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
