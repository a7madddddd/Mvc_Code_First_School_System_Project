namespace finalTaskCodeFirstSchool.Migrations
{
    using finalTaskCodeFirstSchool.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<finalTaskCodeFirstSchool.Models.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(finalTaskCodeFirstSchool.Models.SchoolContext context)
        {

            context.Subjects.AddOrUpdate(
                  s => s.SubjectName,
                  new Subject { SubjectName = "Mathematics" },
                  new Subject { SubjectName = "Science" },
                  new Subject { SubjectName = "History" }
             );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
