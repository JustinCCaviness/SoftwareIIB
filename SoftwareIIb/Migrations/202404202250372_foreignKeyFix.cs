namespace SoftwareIIb.Migrations
{
    using System;
    using System.Data;
    using System.Data.Entity.Migrations;
    
    public partial class foreignKeyFix : DbMigration
    {
        public override void Up()
        {
            CreateIndex("appointment", "customerId", name:"apptCustIdIdx");
            CreateIndex("appointment", "userId", name:"apptUserIdIdx");
            CreateIndex("customer", "addressId", name:"custAddrIdIdx");
            CreateIndex("address", "cityId", name:"addCityIdIdx");
            CreateIndex("city", "countryId", name:"cityCtryIdIdx");
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
            DropIndex("appointment", "apptCustIdIdx");
            DropIndex("appointment", "apptUserIdIdx");
            DropIndex("customer", "custAddrIdIdx");
            DropIndex("address", "addCityIdIdx");
            DropIndex("city", "cityCtryIdIdx");
        }
    }
}
