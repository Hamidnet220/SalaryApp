namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeBanksPropertyToVirtualInEmployeeTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Bank_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Bank_Id");
            AddForeignKey("dbo.Employees", "Bank_Id", "dbo.Banks", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Bank_Id", "dbo.Banks");
            DropIndex("dbo.Employees", new[] { "Bank_Id" });
            DropColumn("dbo.Employees", "Bank_Id");
        }
    }
}
