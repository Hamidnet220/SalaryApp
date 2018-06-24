namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenderColumnToEmployeesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Gender_Id", c => c.Int());
            AddForeignKey("dbo.Employees", "Gender_Id", "dbo.Genders", "Id");
        }
        
        public override void Down()                                                                                 
        {
            DropForeignKey("dbo.Employees", "Gender_Id", "dbo.Genders");
            DropIndex("dbo.Employees", new[] { "Gender_Id" });
            DropColumn("dbo.Employees", "Gender_Id");
        }
    }
}
