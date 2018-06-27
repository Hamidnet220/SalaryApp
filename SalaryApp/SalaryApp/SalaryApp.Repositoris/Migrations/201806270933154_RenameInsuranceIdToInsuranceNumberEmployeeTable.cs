namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameInsuranceIdToInsuranceNumberEmployeeTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "InsurenceNumber", c => c.String(maxLength:10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "InsurenceNumber");
        }
    }
}
