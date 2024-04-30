namespace SoftwareIIb.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SoftwareIIb.SchedulingSoftware>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ScheduleIIb.SchedulingSoftware";
        }

        protected override void Seed(SoftwareIIb.SchedulingSoftware context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
