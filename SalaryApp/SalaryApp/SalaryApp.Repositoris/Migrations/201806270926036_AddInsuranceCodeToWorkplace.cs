namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInsuranceCodeToWorkplace : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Workplaces", "InsuranceCode", c => c.String(maxLength:50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Workplaces", "InsuranceCode");
        }
    }
}
