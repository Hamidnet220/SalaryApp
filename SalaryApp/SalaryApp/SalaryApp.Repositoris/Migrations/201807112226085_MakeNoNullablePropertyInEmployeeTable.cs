namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeNoNullablePropertyInEmployeeTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "POB", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "POI", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "GenderId", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "CountryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "MilitaryServStatusId", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "EducationDegreeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "InsuranceId", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "BankName1Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "BankName2Id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "BankName2Id", c => c.Int());
            AlterColumn("dbo.Employees", "BankName1Id", c => c.Int());
            AlterColumn("dbo.Employees", "InsuranceId", c => c.Int());
            AlterColumn("dbo.Employees", "EducationDegreeId", c => c.Int());
            AlterColumn("dbo.Employees", "MilitaryServStatusId", c => c.Int());
            AlterColumn("dbo.Employees", "CountryId", c => c.Int());
            AlterColumn("dbo.Employees", "GenderId", c => c.Int());
            AlterColumn("dbo.Employees", "POI", c => c.Int());
            AlterColumn("dbo.Employees", "POB", c => c.Int());
        }
    }
}
