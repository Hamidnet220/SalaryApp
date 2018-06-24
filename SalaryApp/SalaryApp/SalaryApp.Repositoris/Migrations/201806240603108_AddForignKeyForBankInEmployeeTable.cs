namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForignKeyForBankInEmployeeTable : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Employees", name: "BankName1_Id", newName: "BankName1Id");
            RenameIndex(table: "dbo.Employees", name: "IX_BankName1_Id", newName: "IX_BankName1Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Employees", name: "IX_BankName1Id", newName: "IX_BankName1_Id");
            RenameColumn(table: "dbo.Employees", name: "BankName1Id", newName: "BankName1_Id");
        }
    }
}
