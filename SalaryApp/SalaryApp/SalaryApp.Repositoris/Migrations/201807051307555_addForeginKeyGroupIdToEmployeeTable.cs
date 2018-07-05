namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addForeginKeyGroupIdToEmployeeTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "GroupId", "dbo.Groups");
            DropIndex("dbo.Employees", new[] { "GroupId" });
            DropColumn("dbo.Employees", "GroupId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "GroupId", c => c.Int());
            CreateIndex("dbo.Employees", "GroupId");
            AddForeignKey("dbo.Employees", "GroupId", "dbo.Groups", "Id");
        }
    }
}
