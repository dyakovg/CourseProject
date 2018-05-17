namespace CourseProject.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePersonalNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "FirstName", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Clients", "LastName", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Clients", "Address", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Clients", "PersonalNO", c => c.Int(nullable: false));
            AlterColumn("dbo.Clients", "Phone", c => c.String(nullable: false, maxLength: 20));
            CreateIndex("dbo.Clients", "PersonalNO", unique: true);
            DropColumn("dbo.Clients", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "Name", c => c.String());
            DropIndex("dbo.Clients", new[] { "PersonalNO" });
            AlterColumn("dbo.Clients", "Phone", c => c.String());
            DropColumn("dbo.Clients", "PersonalNO");
            DropColumn("dbo.Clients", "Address");
            DropColumn("dbo.Clients", "LastName");
            DropColumn("dbo.Clients", "FirstName");
        }
    }
}
