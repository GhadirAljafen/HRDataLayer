namespace HRDataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeNullabilityForManagerID : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "ManagerID", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "ManagerID", c => c.Int(nullable: false));
        }
    }
}
