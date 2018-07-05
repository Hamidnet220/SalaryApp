namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foo3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "GroupId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "GroupId", c => c.Boolean(nullable: false));
        }
    }
}
