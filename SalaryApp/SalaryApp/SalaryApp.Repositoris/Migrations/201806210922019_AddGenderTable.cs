namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenderTable : DbMigration
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
            Sql("INSERT INTO Genders Values('„—œ')");
            Sql("INSERT INTO Genders Values('“‰')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Genders");
        }
    }
}
