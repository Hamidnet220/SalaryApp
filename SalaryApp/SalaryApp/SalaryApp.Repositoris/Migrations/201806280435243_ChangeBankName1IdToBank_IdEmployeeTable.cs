namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBankName1IdToBank_IdEmployeeTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Bank_Id", "dbo.Banks");
            DropIndex("dbo.Employees", new[] { "Bank_Id" });
            RenameColumn(table: "dbo.Employees", name: "BankName1Id", newName: "BankName1_Id");
            RenameIndex(table: "dbo.Employees", name: "IX_BankName1Id", newName: "IX_BankName1_Id");
            AddColumn("dbo.Employees", "Bank_Id1", c => c.Int());
            CreateIndex("dbo.Employees", "Bank_Id1");
            AddForeignKey("dbo.Employees", "Bank_Id1", "dbo.Banks", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Bank_Id1", "dbo.Banks");
            DropIndex("dbo.Employees", new[] { "Bank_Id1" });
            DropColumn("dbo.Employees", "Bank_Id1");
            RenameIndex(table: "dbo.Employees", name: "IX_BankName1_Id", newName: "IX_BankName1Id");
            RenameColumn(table: "dbo.Employees", name: "BankName1_Id", newName: "BankName1Id");
            CreateIndex("dbo.Employees", "Bank_Id");
            AddForeignKey("dbo.Employees", "Bank_Id", "dbo.Banks", "Id");
        }
    }
}
