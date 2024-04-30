namespace SoftwareIIb.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;
    
    public partial class nullableForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder builder)
        {
            builder.AlterColumn("city", "countryId", c => c.Int(nullable: true));
            builder.AlterColumn("address", "cityId", c => c.Int(nullable: true));
            builder.AlterColumn("customer", "addressId", c => c.Int(nullable: true));
            builder.AlterColumn("appointment", "customerId", c=> c.Int(nullable: true));
            builder.AlterColumn("appointment", "userId", c => c.Int(nullable: true));
        }

        protected override void Down(MigrationBuilder builder)
        {
            builder.AlterColumn("city", "countryId", c => c.Int(nullable: false));
            builder.AlterColumn("address", "cityId", c => c.Int(nullable: false));
            builder.AlterColumn("customer", "addressId", c => c.Int(nullable: false));
            builder.AlterColumn("appointment", "customerId", c => c.Int(nullable: false));
            builder.AlterColumn("appointment", "userId", c => c.Int(nullable: false));
        }
    }
}
