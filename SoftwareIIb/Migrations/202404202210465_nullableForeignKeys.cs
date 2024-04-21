namespace SoftwareIIb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullableForeignKeys : DbMigration
    {
        public override void Up()
        {
            AlterColumn("city", "countryId", c => c.Int(nullable: true));
            AlterColumn("address", "cityId", c => c.Int(nullable: true));
            AlterColumn("customer", "addressId", c => c.Int(nullable: true));
            AlterColumn("appointment", "customerId", c=> c.Int(nullable: true));
            AlterColumn("appointment", "userId", c => c.Int(nullable: true));
        }

        public override void Down()
        {
            AlterColumn("city", "countryId", c => c.Int(nullable: false));
            AlterColumn("address", "cityId", c => c.Int(nullable: false));
            AlterColumn("customer", "addressId", c => c.Int(nullable: false));
            AlterColumn("appointment", "customerId", c => c.Int(nullable: false));
            AlterColumn("appointment", "userId", c => c.Int(nullable: false));
        }
    }
}
