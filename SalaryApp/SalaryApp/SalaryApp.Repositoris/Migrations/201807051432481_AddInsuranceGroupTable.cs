namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInsuranceGroupTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InsuranceGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Rate = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "InsuranceGroup_Id", c => c.Int());
            CreateIndex("dbo.Employees", "InsuranceGroup_Id");
            AddForeignKey("dbo.Employees", "InsuranceGroup_Id", "dbo.InsuranceGroups", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "InsuranceGroup_Id", "dbo.InsuranceGroups");
            DropIndex("dbo.Employees", new[] { "InsuranceGroup_Id" });
            DropColumn("dbo.Employees", "InsuranceGroup_Id");
            DropTable("dbo.InsuranceGroups");
        }
    }
}
