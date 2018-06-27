namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foo21 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SalaryDetails", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.SalaryDetails", new[] { "EmployeeId" });
            AlterColumn("dbo.SalaryDetails", "EmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.SalaryDetails", "EmployeeId");
            AddForeignKey("dbo.SalaryDetails", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalaryDetails", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.SalaryDetails", new[] { "EmployeeId" });
            AlterColumn("dbo.SalaryDetails", "EmployeeId", c => c.Int());
            CreateIndex("dbo.SalaryDetails", "EmployeeId");
            AddForeignKey("dbo.SalaryDetails", "EmployeeId", "dbo.Employees", "Id");
        }
    }
}
