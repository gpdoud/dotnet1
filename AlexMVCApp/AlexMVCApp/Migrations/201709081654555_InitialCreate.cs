namespace AlexMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carriers",
                c => new
                    {
                        CarrierID = c.Int(nullable: false, identity: true),
                        MCNumber = c.String(maxLength: 50),
                        DOTNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CarrierID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carriers");
        }
    }
}
