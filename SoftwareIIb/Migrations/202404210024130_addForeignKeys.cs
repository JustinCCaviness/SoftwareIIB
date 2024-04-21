namespace SoftwareIIb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addForeignKeys : DbMigration
    {
        public override void Up()
        {
            AddForeignKey("appointment", "customerId", "customer", "customerId");
            AddForeignKey("appointment", "userId", "user", "userId");
            AddForeignKey("customer", "addressId", "address", "addressId");
            AddForeignKey("address", "cityId", "city", "cityId");
            AddForeignKey("city", "countryId", "country", "countryId");
        }
        
        public override void Down()
        {
            DropForeignKey("appointment", "customerId", "customer");
            DropForeignKey("appointment", "userId", "user");
            DropForeignKey("customer", "addressId", "address");
            DropForeignKey("address", "cityId", "city");
            DropForeignKey("city", "countryId", "country");
        }
    }
}
