namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployeeToSalaryDetialTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SalaryDetails", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.SalaryDetails", new[] { "EmployeeId" });
            RenameColumn(table: "dbo.SalaryDetails", name: "EmployeeId", newName: "Employee_Id");
            AlterColumn("dbo.SalaryDetails", "Employee_Id", c => c.Int());
            CreateIndex("dbo.SalaryDetails", "Employee_Id");
            AddForeignKey("dbo.SalaryDetails", "Employee_Id", "dbo.Employees", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalaryDetails", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.SalaryDetails", new[] { "Employee_Id" });
            AlterColumn("dbo.SalaryDetails", "Employee_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.SalaryDetails", name: "Employee_Id", newName: "EmployeeId");
            CreateIndex("dbo.SalaryDetails", "EmployeeId");
            AddForeignKey("dbo.SalaryDetails", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
    }
}
