namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyEmployee : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "InsuranceId", "dbo.Insurances");
            DropForeignKey("dbo.Employees", "InsuranceGroup_Id", "dbo.InsuranceGroups");
            DropForeignKey("dbo.Employees", "MilitaryServiceStatusId", "dbo.MilitaryServiceStatus");
            DropForeignKey("dbo.Employees", "TaxGroup_Id", "dbo.TaxGroups");
            DropIndex("dbo.Employees", new[] { "MilitaryServiceStatusId" });
            DropIndex("dbo.Employees", new[] { "InsuranceId" });
            DropIndex("dbo.Employees", new[] { "InsuranceGroup_Id" });
            DropIndex("dbo.Employees", new[] { "TaxGroup_Id" });
            AddColumn("dbo.Employees", "MilitaryServStatusId", c => c.Int());
            AddColumn("dbo.Employees", "EducationDegreeId", c => c.Int());
            AlterColumn("dbo.Employees", "InsuranceId", c => c.Int());
            DropColumn("dbo.Employees", "MilitaryServiceStatusId");
            DropColumn("dbo.Employees", "InsuranceGroup_Id");
            DropColumn("dbo.Employees", "TaxGroup_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "TaxGroup_Id", c => c.Int());
            AddColumn("dbo.Employees", "InsuranceGroup_Id", c => c.Int());
            AddColumn("dbo.Employees", "MilitaryServiceStatusId", c => c.Int());
            AlterColumn("dbo.Employees", "InsuranceId", c => c.Int(nullable: false));
            DropColumn("dbo.Employees", "EducationDegreeId");
            DropColumn("dbo.Employees", "MilitaryServStatusId");
            CreateIndex("dbo.Employees", "TaxGroup_Id");
            CreateIndex("dbo.Employees", "InsuranceGroup_Id");
            CreateIndex("dbo.Employees", "InsuranceId");
            CreateIndex("dbo.Employees", "MilitaryServiceStatusId");
            AddForeignKey("dbo.Employees", "TaxGroup_Id", "dbo.TaxGroups", "Id");
            AddForeignKey("dbo.Employees", "MilitaryServiceStatusId", "dbo.MilitaryServiceStatus", "Id");
            AddForeignKey("dbo.Employees", "InsuranceGroup_Id", "dbo.InsuranceGroups", "Id");
            AddForeignKey("dbo.Employees", "InsuranceId", "dbo.Insurances", "Id", cascadeDelete: true);
        }
    }
}
