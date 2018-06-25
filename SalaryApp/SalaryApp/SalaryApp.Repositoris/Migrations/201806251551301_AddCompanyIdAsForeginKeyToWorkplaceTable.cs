namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyIdAsForeginKeyToWorkplaceTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "MilitaryServiceStatusId", c => c.Int());
            CreateIndex("dbo.Workplaces", "CompanyId");
            AddForeignKey("dbo.Workplaces", "CompanyId", "dbo.Companies", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Workplaces", "CompanyId", "dbo.Companies");
            DropIndex("dbo.Workplaces", new[] { "CompanyId" });
            DropColumn("dbo.Employees", "MilitaryServiceStatusId");
        }
    }
}
