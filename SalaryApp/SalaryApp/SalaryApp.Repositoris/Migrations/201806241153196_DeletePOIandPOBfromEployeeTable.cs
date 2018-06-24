namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletePOIandPOBfromEployeeTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Gender_Id", "dbo.Genders");
            DropForeignKey("dbo.Employees", "POB_Id", "dbo.Cities");
            DropForeignKey("dbo.Employees", "POI_Id", "dbo.Cities");
            DropIndex("dbo.Employees", new[] { "Gender_Id" });
            DropIndex("dbo.Employees", new[] { "POB_Id" });
            DropIndex("dbo.Employees", new[] { "POI_Id" });
            DropColumn("dbo.Employees", "Gender_Id");
            DropColumn("dbo.Employees", "POB_Id");
            DropColumn("dbo.Employees", "POI_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "POI_Id", c => c.Int());
            AddColumn("dbo.Employees", "POB_Id", c => c.Int());
            AddColumn("dbo.Employees", "Gender_Id", c => c.Int());
            CreateIndex("dbo.Employees", "POI_Id");
            CreateIndex("dbo.Employees", "POB_Id");
            CreateIndex("dbo.Employees", "Gender_Id");
            AddForeignKey("dbo.Employees", "POI_Id", "dbo.Cities", "Id");
            AddForeignKey("dbo.Employees", "POB_Id", "dbo.Cities", "Id");
            AddForeignKey("dbo.Employees", "Gender_Id", "dbo.Genders", "Id");
        }
    }
}
