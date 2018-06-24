namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConvertPobAndPoiToCityTypeInEmployeeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        FatherName = c.String(),
                        DOB = c.DateTime(),
                        NationalCode = c.String(),
                        IdNumber = c.String(),
                        POB_Id = c.Int(nullable:true),
                        POI_Id = c.Int(nullable:true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.POB_Id)
                .ForeignKey("dbo.Cities", t => t.POI_Id)
                .Index(t => t.POB_Id)
                .Index(t => t.POI_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "POI_Id", "dbo.Cities");
            DropForeignKey("dbo.Employees", "POB_Id", "dbo.Cities");
            DropIndex("dbo.Employees", new[] { "POI_Id" });
            DropIndex("dbo.Employees", new[] { "POB_Id" });
            DropTable("dbo.Employees");
        }
    }
}
