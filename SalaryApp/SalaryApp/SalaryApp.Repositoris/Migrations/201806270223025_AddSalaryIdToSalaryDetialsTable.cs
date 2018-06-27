namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSalaryIdToSalaryDetialsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "SalaryDetail_Id", c => c.Int());
            CreateIndex("dbo.Employees", "SalaryDetail_Id");
            AddForeignKey("dbo.Employees", "SalaryDetail_Id", "dbo.SalaryDetails", "Id");
            DropColumn("dbo.SalaryDetails", "EmployeeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SalaryDetails", "EmployeeId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Employees", "SalaryDetail_Id", "dbo.SalaryDetails");
            DropIndex("dbo.Employees", new[] { "SalaryDetail_Id" });
            DropColumn("dbo.Employees", "SalaryDetail_Id");
        }
    }
}
