namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foo4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SalaryDetails", "AttendanceId", c => c.Int(nullable: false));
            AddColumn("dbo.SalaryDetails", "InsuranceAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.SalaryDetails", "TaxAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SalaryDetails", "TaxAmount");
            DropColumn("dbo.SalaryDetails", "InsuranceAmount");
            DropColumn("dbo.SalaryDetails", "AttendanceId");
        }
    }
}
