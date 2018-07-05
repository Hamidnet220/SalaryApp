namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyAttencanceTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendances", "Year", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "Month", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "SumWorkDays", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "SumDaysoff", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "SumAbsentDays", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "SumWorkDaysInFriday", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "SumWorkDayInHoliday", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attendances", "SumWorkDayInHoliday");
            DropColumn("dbo.Attendances", "SumWorkDaysInFriday");
            DropColumn("dbo.Attendances", "SumAbsentDays");
            DropColumn("dbo.Attendances", "SumDaysoff");
            DropColumn("dbo.Attendances", "SumWorkDays");
            DropColumn("dbo.Attendances", "Month");
            DropColumn("dbo.Attendances", "Year");
        }
    }
}
