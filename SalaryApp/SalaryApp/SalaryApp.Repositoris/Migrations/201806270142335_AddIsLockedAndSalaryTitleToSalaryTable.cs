namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsLockedAndSalaryTitleToSalaryTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Salaries", "Title", c => c.String(maxLength:100));
            AddColumn("dbo.Salaries", "IsLocked", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Salaries", "IsLocked");
            DropColumn("dbo.Salaries", "Title");
        }
    }
}
