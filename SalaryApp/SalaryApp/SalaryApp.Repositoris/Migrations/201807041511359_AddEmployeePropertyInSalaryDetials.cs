namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployeePropertyInSalaryDetials : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SalaryDetails", "Employee_Id", c => c.Int());
            CreateIndex("dbo.SalaryDetails", "Employee_Id");
            AddForeignKey("dbo.SalaryDetails", "Employee_Id", "dbo.Employees", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalaryDetails", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.SalaryDetails", new[] { "Employee_Id" });
            DropColumn("dbo.SalaryDetails", "Employee_Id");
        }
    }
}
