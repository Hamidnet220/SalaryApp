namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTaxtGroupAndInsuranceGroupEmployeeTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "TaxGroupId", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "InsuranceGroupId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "InsuranceGroupId");
            DropColumn("dbo.Employees", "TaxGroupId");
        }
    }
}
