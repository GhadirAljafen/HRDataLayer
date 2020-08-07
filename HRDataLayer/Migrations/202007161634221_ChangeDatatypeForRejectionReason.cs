namespace HRDataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDatatypeForRejectionReason : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vacations", "RejectionReason", c => c.String(maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vacations", "RejectionReason", c => c.Int());
        }
    }
}
