namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovePOBfromEmployeeTable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Employees", new[] { "POBId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Employees", "POBId");
        }
    }
}
