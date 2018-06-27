namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSalaryAndSalaryDetailTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(nullable: false),
                        WorkplaceId = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        EmployeesCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: false)
                .ForeignKey("dbo.Workplaces", t => t.WorkplaceId, cascadeDelete: false)
                .Index(t => t.CompanyId)
                .Index(t => t.WorkplaceId);
            
            CreateTable(
                "dbo.SalaryDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        GrossAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NetAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalaryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Salaries", t => t.SalaryId)
                .Index(t => t.SalaryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Salaries", "WorkplaceId", "dbo.Workplaces");
            DropForeignKey("dbo.SalaryDetails", "Salary_Id", "dbo.Salaries");
            DropForeignKey("dbo.Salaries", "CompanyId", "dbo.Companies");
            DropIndex("dbo.SalaryDetails", new[] { "Salary_Id" });
            DropIndex("dbo.Salaries", new[] { "WorkplaceId" });
            DropIndex("dbo.Salaries", new[] { "CompanyId" });
            DropTable("dbo.SalaryDetails");
            DropTable("dbo.Salaries");
        }
    }
}
