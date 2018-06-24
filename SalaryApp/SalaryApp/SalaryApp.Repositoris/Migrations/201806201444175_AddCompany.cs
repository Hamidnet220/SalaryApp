namespace SalaryApp.Repositoris.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddCompany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
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
            DropTable("dbo.Companies");
        }
    }
}
