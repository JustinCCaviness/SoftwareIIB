namespace SoftwareIIb.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;
    using MySql.EntityFrameworkCore.Metadata;

    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder builder)
        {
            builder.CreateTable<address>(
                "dbo.address",
                c => new
                    {
                        addressId = c.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                        address = c.Column<string>(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        address2 = c.Column<string>(maxLength: 50, storeType: "nvarchar"),
                        cityId = c.Column<int>(nullable: false),
                        postalCode = c.Column<string>(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        phone = c.Column<string>(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        createdBy = c.Column<string>(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        lastUpdate = c.Column<DateTime>(nullable: false, precision: 0),
                        lastUpdateBy = c.Column<string>(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        createDate = c.Column<DateTime>(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.addressId)
                .ForeignKey("dbo.city", t => t.cityId)
                .Index(t => t.cityId);
            
            builder.CreateTable(
                "dbo.city",
                c => new
                    {
                        cityId = c.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                        city = c.Column<string>(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        countryId = c.Column<int>(nullable: false),
                        createdBy = c.Column<string>(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        lastUpdate = c.Column<DateTime>(nullable: false, precision: 0),
                        lastUpdateBy = c.Column<string>(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        createDate = c.Column<DateTime>(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.cityId)
                .ForeignKey("dbo.country", t => t.countryId)
                .Index(t => t.countryId);

            builder.CreateTable(
                "dbo.country",
                c => new
                    {
                        countryId = c.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                        country = c.Column<string>(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        createdBy = c.Column<string>(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        lastUpdate = c.Column<DateTime>(nullable: false, precision: 0),
                        lastUpdateBy = c.Column<string>(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        createDate = c.Column<DateTime>(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.countryId);

            builder.CreateTable(
                "dbo.customer",
                c => new
                    {
                        customerId = c.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                        customerName = c.Column<string>(nullable: false, maxLength: 45, storeType: "nvarchar"),
                        addressId = c.Column<int>(nullable: false),
                        active = c.Boolean(nullable: false),
                        createdBy = c.Column<string>(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        lastUpdate = c.Column<DateTime>(nullable: false, precision: 0),
                        lastUpdateBy = c.Column<string>(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        createDate = c.Column<DateTime>(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.customerId)
                .ForeignKey("dbo.address", t => t.addressId)
                .Index(t => t.addressId);

            builder.CreateTable(
                "dbo.appointment",
                c => new
                    {
                        appointmentId = c.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                        customerId = c.Column<int>(nullable: false),
                        userId = c.Column<int>(nullable: false),
                        title = c.Column<string>(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        description = c.Column<string>(nullable: false, unicode: false),
                        location = c.Column<string>(nullable: false, unicode: false),
                        contact = c.Column<string>(nullable: false, unicode: false),
                        type = c.Column<string>(nullable: false, unicode: false),
                        url = c.Column<string>(maxLength: 255, storeType: "nvarchar"),
                        start = c.Column<DateTime>(nullable: false, precision: 0),
                        end = c.Column<DateTime>(nullable: false, precision: 0),
                        createDate = c.Column<DateTime>(nullable: false, precision: 0),
                        createdBy = c.Column<string>(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        lastUpdate = c.Column<DateTime>(nullable: false, precision: 0),
                        lastUpdateBy = c.Column<string>(nullable: false, maxLength: 40, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.appointmentId)
                .ForeignKey("dbo.user", t => t.userId)
                .ForeignKey("dbo.customer", t => t.customerId)
                .Index(t => t.customerId)
                .Index(t => t.userId);

            builder.CreateTable(
                "dbo.user",
                c => new
                    {
                        userId = c.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                        userName = c.Column<string>(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        password = c.Column<string>(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        active = c.Boolean(nullable: false),
                        createdBy = c.Column<string>(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        lastUpdate = c.Column<DateTime>(nullable: false, precision: 0),
                        lastUpdateBy = c.Column<string>(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        createDate = c.Column<DateTime>(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.userId);
            
        }
        
        protected override void Down(MigrationBuilder builder)
        {
            builder.DropForeignKey("dbo.customer", "addressId", "dbo.address");
            builder.DropForeignKey("dbo.appointment", "customerId", "dbo.customer");
            builder.DropForeignKey("dbo.appointment", "userId", "dbo.user");
            builder.DropForeignKey("dbo.city", "countryId", "dbo.country");
            builder.DropForeignKey("dbo.address", "cityId", "dbo.city");
            builder.DropIndex("dbo.appointment", new[] { "userId" });
            builder.DropIndex("dbo.appointment", new[] { "customerId" });
            builder.DropIndex("dbo.customer", new[] { "addressId" });
            builder.DropIndex("dbo.city", new[] { "countryId" });
            builder.DropIndex("dbo.address", new[] { "cityId" });
            builder.DropTable("dbo.user");
            builder.DropTable("dbo.appointment");
            builder.DropTable("dbo.customer");
            builder.DropTable("dbo.country");
            builder.DropTable("dbo.city");
            builder.DropTable("dbo.address");
        }
    }
}
