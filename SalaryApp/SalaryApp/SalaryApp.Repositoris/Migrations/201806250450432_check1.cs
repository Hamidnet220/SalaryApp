namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class check1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "GenderId", c => c.Int());
            CreateIndex("dbo.Employees", "GenderId");
            AddForeignKey("dbo.Employees", "GenderId", "dbo.Genders", "Id");
           
        }
        
        public override void Down()
        {
            
            DropForeignKey("dbo.Employees", "GenderId", "dbo.Genders");
            DropIndex("dbo.Employees", new[] { "GenderId" });
            DropColumn("dbo.Employees", "GenderId");
            DropTable("dbo.Genders");
        }
    }
}
