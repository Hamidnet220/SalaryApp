namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveEmployeePropertySalaryDetails : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SalaryDetails", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Employees", "SalaryDetail_Id", "dbo.SalaryDetails");
            DropIndex("dbo.Employees", new[] { "SalaryDetail_Id" });
            DropIndex("dbo.SalaryDetails", new[] { "Employee_Id" });
            DropColumn("dbo.Employees", "SalaryDetail_Id");
            DropColumn("dbo.SalaryDetails", "Employee_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SalaryDetails", "Employee_Id", c => c.Int());
            AddColumn("dbo.Employees", "SalaryDetail_Id", c => c.Int());
            CreateIndex("dbo.SalaryDetails", "Employee_Id");
            CreateIndex("dbo.Employees", "SalaryDetail_Id");
            AddForeignKey("dbo.Employees", "SalaryDetail_Id", "dbo.SalaryDetails", "Id");
            AddForeignKey("dbo.SalaryDetails", "Employee_Id", "dbo.Employees", "Id");
        }
    }
}
