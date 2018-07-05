namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCountyNavigatorOfEmployee : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Nationality_Id", "dbo.Countries");
            DropIndex("dbo.Employees", new[] { "Nationality_Id" });
            AddColumn("dbo.Employees", "Nationality", c => c.Int());
            DropColumn("dbo.Employees", "Nationality_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Nationality_Id", c => c.Int());
            DropColumn("dbo.Employees", "Nationality");
            CreateIndex("dbo.Employees", "Nationality_Id");
            AddForeignKey("dbo.Employees", "Nationality_Id", "dbo.Countries", "Id");
        }
    }
}
