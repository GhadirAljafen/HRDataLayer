namespace HRDataLayer.Migrations
{
    using HRDataLayer.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HRDataLayer.HRContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        } 
        public class HRDBInitializer : CreateDatabaseIfNotExists<HRContext>
        {
            protected override void Seed(HRDataLayer.HRContext context)

            {

                IList<User> predefindeManagers = new List<User>();
                predefindeManagers.Add(new User()
                {
                    Name = "Abdulkarim",
                    LastName = "Zrik",
                    Username = "karim123",
                    Email = "a.zrik@t2.sa",
                    Password = "123456",
                    Mobile = "+966539447446",
                    JobTitle = "Manager",
                    Role = 0
                });
                base.Seed(context);
                context.Users.AddRange(predefindeManagers);
                context.SaveChanges();


            }
        }
    }
}
