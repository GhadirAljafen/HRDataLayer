namespace HRDataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropAndAddColVacationBalence : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "AnnualVacationBalance", c => c.Double(nullable: false, defaultValue:14));
            DropColumn("dbo.Vacations", "VacationBalance");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vacations", "VacationBalance", c => c.Double(nullable: false));
            DropColumn("dbo.Users", "AnnualVacationBalance");
        }
    }
}
