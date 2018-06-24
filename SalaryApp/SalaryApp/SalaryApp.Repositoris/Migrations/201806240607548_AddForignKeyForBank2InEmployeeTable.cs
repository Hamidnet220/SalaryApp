namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForignKeyForBank2InEmployeeTable : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Employees", name: "BankName2_Id", newName: "BankName2Id");
            RenameIndex(table: "dbo.Employees", name: "IX_BankName2_Id", newName: "IX_BankName2Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Employees", name: "IX_BankName2Id", newName: "IX_BankName2_Id");
            RenameColumn(table: "dbo.Employees", name: "BankName2Id", newName: "BankName2_Id");
        }
    }
}
