namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBankAccountAgeAddressTelMobileToEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "BankAccNumber1", c => c.String(maxLength: 50));
            AddColumn("dbo.Employees", "BankAccNumber2", c => c.String(maxLength: 50));
            AddColumn("dbo.Employees", "Children", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "Age", c => c.Int());
            AddColumn("dbo.Employees", "Tel", c => c.String());
            AddColumn("dbo.Employees", "Mobile", c => c.String());
            AddColumn("dbo.Employees", "Address", c => c.String());
            AddColumn("dbo.Employees", "Email", c => c.String());
            AddColumn("dbo.Employees", "IsWorking", c => c.Boolean(nullable: false));
            AddColumn("dbo.Employees", "BankName1_Id", c => c.Int());
            AddColumn("dbo.Employees", "BankName2_Id", c => c.Int());
            CreateIndex("dbo.Employees", "BankName1_Id");
            CreateIndex("dbo.Employees", "BankName2_Id");
            AddForeignKey("dbo.Employees", "BankName1_Id", "dbo.Banks", "Id");
            AddForeignKey("dbo.Employees", "BankName2_Id", "dbo.Banks", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "BankName2_Id", "dbo.Banks");
            DropForeignKey("dbo.Employees", "BankName1_Id", "dbo.Banks");
            DropIndex("dbo.Employees", new[] { "BankName2_Id" });
            DropIndex("dbo.Employees", new[] { "BankName1_Id" });
            DropColumn("dbo.Employees", "BankName2_Id");
            DropColumn("dbo.Employees", "BankName1_Id");
            DropColumn("dbo.Employees", "IsWorking");
            DropColumn("dbo.Employees", "Email");
            DropColumn("dbo.Employees", "Address");
            DropColumn("dbo.Employees", "Mobile");
            DropColumn("dbo.Employees", "Tel");
            DropColumn("dbo.Employees", "Age");
            DropColumn("dbo.Employees", "Children");
            DropColumn("dbo.Employees", "BankAccNumber2");
            DropColumn("dbo.Employees", "BankAccNumber1");
        }
    }
}
