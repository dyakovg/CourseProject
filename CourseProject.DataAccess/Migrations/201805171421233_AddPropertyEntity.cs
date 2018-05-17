namespace CourseProject.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertyEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 20),
                        Bedrooms = c.Int(nullable: false),
                        Rooms = c.Int(nullable: false),
                        Area = c.Int(nullable: false),
                        Floor = c.Int(nullable: false),
                        ResidentialDistrict = c.String(nullable: false, maxLength: 20),
                        City = c.String(nullable: false, maxLength: 20),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Year = c.Int(nullable: false),
                        Extras = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Properties");
        }
    }
}
