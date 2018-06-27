namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInsuranceIdFieldAndForeginKeyToEmployeeeTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "InsuranceId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "InsuranceId");
            AddForeignKey("dbo.Employees", "InsuranceId", "dbo.Insurances", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "InsuranceId", "dbo.Insurances");
            DropIndex("dbo.Employees", new[] { "InsuranceId" });
            DropColumn("dbo.Employees", "InsuranceId");
        }
    }
}
