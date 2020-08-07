namespace HRDataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingColVacationBalence : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vacations", "VacationBalance", c => c.Double(nullable: false, defaultValue: 14));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vacations", "VacationBalance");
        }
    }
}
