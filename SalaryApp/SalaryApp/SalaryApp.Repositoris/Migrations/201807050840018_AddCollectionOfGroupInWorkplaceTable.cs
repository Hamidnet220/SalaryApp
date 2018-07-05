namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCollectionOfGroupInWorkplaceTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groups", "WorkplaceId", c => c.Int());
            CreateIndex("dbo.Groups", "WorkplaceId");
            AddForeignKey("dbo.Groups", "WorkplaceId", "dbo.Workplaces", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Groups", "Workplace_Id", "dbo.Workplaces");
            DropIndex("dbo.Groups", new[] { "WorkplaceId" });
            DropColumn("dbo.Groups", "WorkplaceId");
        }
    }
}
