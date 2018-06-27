namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foo1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SalaryDetails", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.SalaryDetails", new[] { "EmployeeId" });
            DropColumn("dbo.SalaryDetails", "EmployeeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SalaryDetails", "EmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.SalaryDetails", "EmployeeId");
            AddForeignKey("dbo.SalaryDetails", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
    }
}
