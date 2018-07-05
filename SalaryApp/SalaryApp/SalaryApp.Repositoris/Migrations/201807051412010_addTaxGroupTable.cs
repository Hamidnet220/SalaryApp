namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTaxGroupTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaxGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength:100,nullable:false),
                        Rate = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "TaxGroup_Id", c => c.Int());
            CreateIndex("dbo.Employees", "TaxGroup_Id");
            AddForeignKey("dbo.Employees", "TaxGroup_Id", "dbo.TaxGroups", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "TaxGroup_Id", "dbo.TaxGroups");
            DropIndex("dbo.Employees", new[] { "TaxGroup_Id" });
            DropColumn("dbo.Employees", "TaxGroup_Id");
            DropTable("dbo.TaxGroups");
        }
    }
}
