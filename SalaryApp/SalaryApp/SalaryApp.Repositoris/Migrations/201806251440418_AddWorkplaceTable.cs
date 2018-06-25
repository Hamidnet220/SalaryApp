namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWorkplaceTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Workplaces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(nullable: false),
                        IsAcitve = c.Boolean(nullable: false),
                        Title = c.String(),
                        EmployerTitle = c.String(),
                        ContractNumber = c.String(),
                        ContractPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        IsClosed = c.Boolean(nullable: false),
                        Tel = c.String(),
                        Fax = c.String(),
                        Address = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreateByUserId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedDate = c.DateTime(),
                        DeletedByUserID = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Workplaces");
        }
    }
}
