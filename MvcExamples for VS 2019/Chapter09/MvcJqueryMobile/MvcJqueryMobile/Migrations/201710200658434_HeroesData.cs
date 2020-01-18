namespace MvcJqueryMobile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HeroesData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Heroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PageId = c.String(),
                        Header = c.String(),
                        Footer = c.String(),
                        Introduction = c.String(),
                        ImageUrl = c.String(),
                        ImageAlt = c.String(),
                        VideoUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Heroes");
        }
    }
}
