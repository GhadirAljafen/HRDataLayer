namespace HRDataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIsUnique : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Users", "Email", unique: true);
            CreateIndex("dbo.Users", "Username", unique: true);
            CreateIndex("dbo.Users", "Mobile", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Mobile" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Users", new[] { "Email" });
        }
    }
}
