namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foo11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SalaryDetails", "EmployeeId", c => c.Int(nullable: true));
            CreateIndex("dbo.SalaryDetails", "EmployeeId");
            AddForeignKey("dbo.SalaryDetails", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalaryDetails", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.SalaryDetails", new[] { "EmployeeId" });
            DropColumn("dbo.SalaryDetails", "EmployeeId");
        }
    }
}
