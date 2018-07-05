namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGroupIdToEmployeeTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Group_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Group_Id");
            AddForeignKey("dbo.Employees", "Group_Id", "dbo.Groups", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Group_Id", "dbo.Groups");
            DropIndex("dbo.Employees", new[] { "Group_Id" });
            DropColumn("dbo.Employees", "Group_Id");
        }
    }
}
