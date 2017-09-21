namespace MVCAddColumnToDbase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Motorcycles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Manufacturer = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Style = c.String(),
                        CC = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Motorcycles");
        }
    }
}
