namespace SalaryApp.Repositoris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameNationalityToCountyEmployeeTable : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Employees","POBId", "POB");
            RenameColumn("dbo.Employees","POIId", "POI");
            RenameColumn("dbo.Employees", "Nationality", "CountryId");
            
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Employees", "POB", "POBId");
            RenameColumn("dbo.Employees", "POI", "POIId");
            RenameColumn("dbo.Employees", "CountryId", "Nationality");
        }
    }
}
