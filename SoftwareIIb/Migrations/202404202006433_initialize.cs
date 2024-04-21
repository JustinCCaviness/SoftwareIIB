namespace SoftwareIIb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.address",
                c => new
                    {
                        addressId = c.Int(nullable: false, identity: true),
                        address = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        address2 = c.String(maxLength: 50, storeType: "nvarchar"),
                        cityId = c.Int(nullable: false),
                        postalCode = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        phone = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        createdBy = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        lastUpdate = c.DateTime(nullable: false, precision: 0),
                        lastUpdateBy = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        createDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.addressId)
                .ForeignKey("dbo.city", t => t.cityId)
                .Index(t => t.cityId);
            
            CreateTable(
                "dbo.city",
                c => new
                    {
                        cityId = c.Int(nullable: false, identity: true),
                        city = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        countryId = c.Int(nullable: false),
                        createdBy = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        lastUpdate = c.DateTime(nullable: false, precision: 0),
                        lastUpdateBy = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        createDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.cityId)
                .ForeignKey("dbo.country", t => t.countryId)
                .Index(t => t.countryId);
            
            CreateTable(
                "dbo.country",
                c => new
                    {
                        countryId = c.Int(nullable: false, identity: true),
                        country = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        createdBy = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        lastUpdate = c.DateTime(nullable: false, precision: 0),
                        lastUpdateBy = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        createDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.countryId);
            
            CreateTable(
                "dbo.customer",
                c => new
                    {
                        customerId = c.Int(nullable: false, identity: true),
                        customerName = c.String(nullable: false, maxLength: 45, storeType: "nvarchar"),
                        addressId = c.Int(nullable: false),
                        active = c.Boolean(nullable: false),
                        createdBy = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        lastUpdate = c.DateTime(nullable: false, precision: 0),
                        lastUpdateBy = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        createDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.customerId)
                .ForeignKey("dbo.address", t => t.addressId)
                .Index(t => t.addressId);
            
            CreateTable(
                "dbo.appointment",
                c => new
                    {
                        appointmentId = c.Int(nullable: false, identity: true),
                        customerId = c.Int(nullable: false),
                        userId = c.Int(nullable: false),
                        title = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        description = c.String(nullable: false, unicode: false),
                        location = c.String(nullable: false, unicode: false),
                        contact = c.String(nullable: false, unicode: false),
                        type = c.String(nullable: false, unicode: false),
                        url = c.String(maxLength: 255, storeType: "nvarchar"),
                        start = c.DateTime(nullable: false, precision: 0),
                        end = c.DateTime(nullable: false, precision: 0),
                        createDate = c.DateTime(nullable: false, precision: 0),
                        createdBy = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        lastUpdate = c.DateTime(nullable: false, precision: 0),
                        lastUpdateBy = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.appointmentId)
                .ForeignKey("dbo.user", t => t.userId)
                .ForeignKey("dbo.customer", t => t.customerId)
                .Index(t => t.customerId)
                .Index(t => t.userId);
            
            CreateTable(
                "dbo.user",
                c => new
                    {
                        userId = c.Int(nullable: false, identity: true),
                        userName = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        password = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        active = c.Boolean(nullable: false),
                        createdBy = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        lastUpdate = c.DateTime(nullable: false, precision: 0),
                        lastUpdateBy = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        createDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.userId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.customer", "addressId", "dbo.address");
            DropForeignKey("dbo.appointment", "customerId", "dbo.customer");
            DropForeignKey("dbo.appointment", "userId", "dbo.user");
            DropForeignKey("dbo.city", "countryId", "dbo.country");
            DropForeignKey("dbo.address", "cityId", "dbo.city");
            DropIndex("dbo.appointment", new[] { "userId" });
            DropIndex("dbo.appointment", new[] { "customerId" });
            DropIndex("dbo.customer", new[] { "addressId" });
            DropIndex("dbo.city", new[] { "countryId" });
            DropIndex("dbo.address", new[] { "cityId" });
            DropTable("dbo.user");
            DropTable("dbo.appointment");
            DropTable("dbo.customer");
            DropTable("dbo.country");
            DropTable("dbo.city");
            DropTable("dbo.address");
        }
    }
}
