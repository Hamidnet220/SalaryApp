namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourceConfiguratinModleBuilder : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Employees", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Employees", "FatherName", c => c.String());
            AlterColumn("dbo.Employees", "NationalCode", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Employees", "IdNumber", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "IdNumber", c => c.String(maxLength: 10));
            AlterColumn("dbo.Employees", "NationalCode", c => c.String(maxLength: 10));
            AlterColumn("dbo.Employees", "FatherName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Employees", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Employees", "FirstName", c => c.String(maxLength: 50));
        }
    }
}
