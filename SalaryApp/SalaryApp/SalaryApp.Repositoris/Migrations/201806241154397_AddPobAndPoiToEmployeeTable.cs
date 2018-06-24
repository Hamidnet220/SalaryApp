namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPobAndPoiToEmployeeTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "POBId", c => c.Int());
            AddColumn("dbo.Employees", "POIId", c => c.Int());
            CreateIndex("dbo.Employees", "POBId");
            CreateIndex("dbo.Employees", "POIId");
            AddForeignKey("dbo.Employees", "POBId", "dbo.Cities", "Id");
            AddForeignKey("dbo.Employees", "POIId", "dbo.Cities", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "POIId", "dbo.Cities");
            DropForeignKey("dbo.Employees", "POBId", "dbo.Cities");
            DropIndex("dbo.Employees", new[] { "POIId" });
            DropIndex("dbo.Employees", new[] { "POBId" });
            DropColumn("dbo.Employees", "POIId");
            DropColumn("dbo.Employees", "POBId");
        }
    }
}
