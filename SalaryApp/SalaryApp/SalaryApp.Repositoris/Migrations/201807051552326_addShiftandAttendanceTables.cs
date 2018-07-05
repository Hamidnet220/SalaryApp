namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addShiftandAttendanceTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Employee_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength:50),
                        Abbr = c.String(maxLength:10),
                    })
                .PrimaryKey(t => t.Id); 
            
            AddColumn("dbo.Salaries", "SumSalary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Salaries", "SumTax", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Salaries", "SumInsurance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.Attendances", new[] { "Employee_Id" });
            DropColumn("dbo.Salaries", "SumInsurance");
            DropColumn("dbo.Salaries", "SumTax");
            DropColumn("dbo.Salaries", "SumSalary");
            DropTable("dbo.Shifts");
            DropTable("dbo.Attendances");
        }
    }
}
