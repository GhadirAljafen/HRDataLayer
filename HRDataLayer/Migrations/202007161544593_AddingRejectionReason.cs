namespace HRDataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingRejectionReason : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vacations", "RejectionReason", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vacations", "RejectionReason");
        }
    }
}
