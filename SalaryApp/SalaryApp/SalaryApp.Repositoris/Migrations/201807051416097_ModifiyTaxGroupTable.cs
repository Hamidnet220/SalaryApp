namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiyTaxGroupTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TaxGroups", "Description", c => c.String(maxLength:100));
            AddColumn("dbo.TaxGroups", "TaxFreeAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TaxGroups", "TaxFreeAmount");
            DropColumn("dbo.TaxGroups", "Description");
        }
    }
}
