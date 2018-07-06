namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDaysInAttandanceTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendances", "D1", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D2", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D3", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D4", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D5", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D6", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D7", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D8", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D9", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D10", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D11", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D12", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D13", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D14", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D15", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D16", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D17", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D18", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D19", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D20", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D21", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D22", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D23", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D24", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D25", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D26", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D27", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D28", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D29", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D30", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "D31", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "OverTimeHoures", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attendances", "OverTimeHoures");
            DropColumn("dbo.Attendances", "D31");
            DropColumn("dbo.Attendances", "D30");
            DropColumn("dbo.Attendances", "D29");
            DropColumn("dbo.Attendances", "D28");
            DropColumn("dbo.Attendances", "D27");
            DropColumn("dbo.Attendances", "D26");
            DropColumn("dbo.Attendances", "D25");
            DropColumn("dbo.Attendances", "D24");
            DropColumn("dbo.Attendances", "D23");
            DropColumn("dbo.Attendances", "D22");
            DropColumn("dbo.Attendances", "D21");
            DropColumn("dbo.Attendances", "D20");
            DropColumn("dbo.Attendances", "D19");
            DropColumn("dbo.Attendances", "D18");
            DropColumn("dbo.Attendances", "D17");
            DropColumn("dbo.Attendances", "D16");
            DropColumn("dbo.Attendances", "D15");
            DropColumn("dbo.Attendances", "D14");
            DropColumn("dbo.Attendances", "D13");
            DropColumn("dbo.Attendances", "D12");
            DropColumn("dbo.Attendances", "D11");
            DropColumn("dbo.Attendances", "D10");
            DropColumn("dbo.Attendances", "D9");
            DropColumn("dbo.Attendances", "D8");
            DropColumn("dbo.Attendances", "D7");
            DropColumn("dbo.Attendances", "D6");
            DropColumn("dbo.Attendances", "D5");
            DropColumn("dbo.Attendances", "D4");
            DropColumn("dbo.Attendances", "D3");
            DropColumn("dbo.Attendances", "D2");
            DropColumn("dbo.Attendances", "D1");
        }
    }
}
