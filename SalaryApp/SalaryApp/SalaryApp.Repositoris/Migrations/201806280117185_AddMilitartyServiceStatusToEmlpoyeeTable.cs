namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMilitartyServiceStatusToEmlpoyeeTable : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Employees", "MilitaryServiceStatusId");
            AddForeignKey("dbo.Employees", "MilitaryServiceStatusId", "dbo.MilitaryServiceStatus", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "MilitaryServiceStatusId", "dbo.MilitaryServiceStatus");
            DropIndex("dbo.Employees", new[] { "MilitaryServiceStatusId" });
        }
    }
}
