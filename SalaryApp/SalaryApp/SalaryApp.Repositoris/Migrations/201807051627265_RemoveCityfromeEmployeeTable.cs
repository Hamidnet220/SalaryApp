namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCityfromeEmployeeTable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Employees", new[] { "POIId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Employees", "POIId");
        }
    }
}
