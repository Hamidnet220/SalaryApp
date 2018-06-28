namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UndoBankIdNameInEmployeeTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Bank_Id1", "dbo.Banks");
            DropIndex("dbo.Employees", new[] { "Bank_Id1" });
            RenameColumn(table: "dbo.Employees", name: "BankName1_Id", newName: "BankName1Id");
            RenameIndex(table: "dbo.Employees", name: "IX_BankName1_Id", newName: "IX_BankName1Id");
            DropColumn("dbo.Employees", "Bank_Id");
            DropColumn("dbo.Employees", "Bank_Id1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Bank_Id1", c => c.Int());
            AddColumn("dbo.Employees", "Bank_Id", c => c.Int());
            RenameIndex(table: "dbo.Employees", name: "IX_BankName1Id", newName: "IX_BankName1_Id");
            RenameColumn(table: "dbo.Employees", name: "BankName1Id", newName: "BankName1_Id");
            CreateIndex("dbo.Employees", "Bank_Id1");
            AddForeignKey("dbo.Employees", "Bank_Id1", "dbo.Banks", "Id");
        }
    }
}
