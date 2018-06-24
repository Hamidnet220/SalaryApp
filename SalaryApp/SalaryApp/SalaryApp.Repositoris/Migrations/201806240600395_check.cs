namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class check : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Bank_Id", "dbo.Banks");
            DropIndex("dbo.Employees", new[] { "Bank_Id" });
            DropColumn("dbo.Employees", "Bank_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Bank_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Bank_Id");
            AddForeignKey("dbo.Employees", "Bank_Id", "dbo.Banks", "Id");
        }
    }
}
