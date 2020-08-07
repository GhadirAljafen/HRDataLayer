namespace HRDataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropColVacationBalence : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Vacations", "VacationBalance");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vacations", "VacationBalance", c => c.Double(nullable: false));
        }
    }
}
