namespace HRDataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDesign : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        Username = c.String(nullable: false, maxLength: 50, unicode: false),
                        Password = c.String(),
                        Mobile = c.String(nullable: false, maxLength: 15, unicode: false),
                        JobTitle = c.String(maxLength: 50),
                        Role = c.Int(nullable: false),
                        ManagerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Vacations",
                c => new
                    {
                        VacationID = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Attatchment = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Description = c.String(maxLength: 3000),
                        Status = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VacationID)
                .ForeignKey("dbo.Users", t => t.EmployeeID)
                .Index(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vacations", "EmployeeID", "dbo.Users");
            DropIndex("dbo.Vacations", new[] { "EmployeeID" });
            DropTable("dbo.Vacations");
            DropTable("dbo.Users");
        }
    }
}
