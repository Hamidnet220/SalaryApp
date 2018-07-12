namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "POB", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "POB", c => c.Int(nullable: false));
        }
    }
}
