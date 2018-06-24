namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHierDateAndExperianceAgeIntEmployeeTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "HireDate", c => c.DateTime());
            AddColumn("dbo.Employees", "Experience", c => c.Int());
            AddColumn("dbo.Employees", "Nationality_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Nationality_Id");
            AddForeignKey("dbo.Employees", "Nationality_Id", "dbo.Countries", "Id");
            DropColumn("dbo.Employees", "Nationality");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Nationality", c => c.Int(nullable: false));
            DropForeignKey("dbo.Employees", "Nationality_Id", "dbo.Countries");
            DropIndex("dbo.Employees", new[] { "Nationality_Id" });
            DropColumn("dbo.Employees", "Nationality_Id");
            DropColumn("dbo.Employees", "Experience");
            DropColumn("dbo.Employees", "HireDate");
        }
    }
}
