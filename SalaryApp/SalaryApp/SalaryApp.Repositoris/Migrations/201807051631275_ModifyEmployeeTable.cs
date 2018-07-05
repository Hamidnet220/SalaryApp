namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyEmployeeTable : DbMigration
    {
        public override void Up()
        {
           
            DropIndex("dbo.Employees", new[] { "GenderId" });
            DropIndex("dbo.Employees", new[] { "BankName1Id" });
            DropIndex("dbo.Employees", new[] { "BankName2Id" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Employees", "BankName2Id");
            CreateIndex("dbo.Employees", "BankName1Id");
            CreateIndex("dbo.Employees", "GenderId");
           
        }
    }
}
