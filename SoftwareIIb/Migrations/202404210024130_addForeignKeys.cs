namespace SoftwareIIb.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;
    
    public partial class addForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder builder)
        {
            builder.AddForeignKey("appointment", "customerId", "customer", "customerId");
            builder.AddForeignKey("appointment", "userId", "user", "userId");
            builder.AddForeignKey("customer", "addressId", "address", "addressId");
            builder.AddForeignKey("address", "cityId", "city", "cityId");
            builder.AddForeignKey("city", "countryId", "country", "countryId");
        }
        
        protected override void Down(MigrationBuilder builder)
        {
            builder.DropForeignKey("appointment", "customerId", "customer");
            builder.DropForeignKey("appointment", "userId", "user");
            builder.DropForeignKey("customer", "addressId", "address");
            builder.DropForeignKey("address", "cityId", "city");
            builder.DropForeignKey("city", "countryId", "country");
        }
    }
}
