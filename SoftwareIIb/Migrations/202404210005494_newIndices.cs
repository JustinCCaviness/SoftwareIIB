namespace SoftwareIIb.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;
    
    public partial class newIndices : Migration
    {
        protected override void Up(MigrationBuilder builder)
        {
            builder.CreateIndex(table: "appointment", column: "customerId", name: "IDX_customerId");
            builder.CreateIndex(table: "appointment", column: "userId", name: "IDX_userId");
            builder.CreateIndex(table: "customer", column: "addressId", name: "IDX_addressId");
            builder.CreateIndex(table: "address", column: "cityId", name: "IDX_cityId");
            builder.CreateIndex(table: "city", column: "countryId", name: "IDX_countryId");
        }

        protected override void Down(MigrationBuilder builder)
        {
            builder.DropIndex(table: "appointment", name: "IDX_userId");
            builder.DropIndex(table: "appointment", name: "IDX_customerId");
            builder.DropIndex(table: "customer", name: "IDX_addressId");
            builder.DropIndex(table: "address", name: "IDX_cityId");
            builder.DropIndex(table: "city", name: "IDX_countryId");
        }
    }
}
