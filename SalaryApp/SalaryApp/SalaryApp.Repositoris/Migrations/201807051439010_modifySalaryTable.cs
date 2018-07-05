namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifySalaryTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Salaries", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Salaries", "WorkplaceId", "dbo.Workplaces");
            DropIndex("dbo.Salaries", new[] { "CompanyId" });
            DropIndex("dbo.Salaries", new[] { "WorkplaceId" });
            RenameColumn(table: "dbo.Salaries", name: "WorkplaceId", newName: "Workplace_Id");
            AlterColumn("dbo.Salaries", "Workplace_Id", c => c.Int());
            CreateIndex("dbo.Salaries", "Workplace_Id");
            AddForeignKey("dbo.Salaries", "Workplace_Id", "dbo.Workplaces", "Id");
            DropColumn("dbo.Salaries", "CompanyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Salaries", "CompanyId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Salaries", "Workplace_Id", "dbo.Workplaces");
            DropIndex("dbo.Salaries", new[] { "Workplace_Id" });
            AlterColumn("dbo.Salaries", "Workplace_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Salaries", name: "Workplace_Id", newName: "WorkplaceId");
            CreateIndex("dbo.Salaries", "WorkplaceId");
            CreateIndex("dbo.Salaries", "CompanyId");
            AddForeignKey("dbo.Salaries", "WorkplaceId", "dbo.Workplaces", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Salaries", "CompanyId", "dbo.Companies", "Id", cascadeDelete: true);
        }
    }
}
