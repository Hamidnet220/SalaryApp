namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWorkplaceTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "WorkplaceId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "WorkplaceId");
        }
    }
}
