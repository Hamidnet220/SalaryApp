namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "SalaryDetail_Id", "dbo.SalaryDetails");
            DropForeignKey("dbo.SalaryDetails", "SalaryId", "dbo.Salaries");
            DropIndex("dbo.Employees", new[] { "SalaryDetail_Id" });
            DropIndex("dbo.SalaryDetails", new[] { "SalaryId" });
            AddColumn("dbo.SalaryDetails", "EmployeeId", c => c.Int(nullable: false));
            AlterColumn("dbo.SalaryDetails", "SalaryId", c => c.Int(nullable: false));
            CreateIndex("dbo.SalaryDetails", "SalaryId");
            AddForeignKey("dbo.SalaryDetails", "SalaryId", "dbo.Salaries", "Id", cascadeDelete: false);
            CreateIndex("dbo.SalaryDetails", "EmployeeId");
            DropColumn("dbo.Employees", "SalaryDetail_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "SalaryDetail_Id", c => c.Int());
            DropForeignKey("dbo.SalaryDetails", "SalaryId", "dbo.Salaries");
            DropForeignKey("dbo.SalaryDetails", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.SalaryDetails", new[] { "EmployeeId" });
            AlterColumn("dbo.SalaryDetails", "SalaryId", c => c.Int());
            CreateIndex("dbo.SalaryDetails", "SalaryId");
            CreateIndex("dbo.Employees", "SalaryDetail_Id");
            AddForeignKey("dbo.SalaryDetails", "Salary_Id", "dbo.Salaries", "Id");
            AddForeignKey("dbo.Employees", "SalaryDetail_Id", "dbo.SalaryDetails", "Id");
        }
    }
}
