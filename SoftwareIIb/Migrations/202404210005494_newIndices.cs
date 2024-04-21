namespace SoftwareIIb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newIndices : DbMigration
    {
        public override void Up()
        {
            CreateIndex(table: "appointment", column: "customerId", name: "IDX_customerId");
            CreateIndex(table: "appointment", column: "userId", name: "IDX_userId");
            CreateIndex(table: "customer", column: "addressId", name: "IDX_addressId");
            CreateIndex(table: "address", column: "cityId", name: "IDX_cityId");
            CreateIndex(table: "city", column: "countryId", name: "IDX_countryId");
        }

        public override void Down()
        {
            DropIndex(table: "appointment", name: "IDX_userId");
            DropIndex(table: "appointment", name: "IDX_customerId");
            DropIndex(table: "customer", name: "IDX_addressId");
            DropIndex(table: "address", name: "IDX_cityId");
            DropIndex(table: "city", name: "IDX_countryId");
        }
    }
}
