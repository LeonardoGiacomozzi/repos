namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajusteImovel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Imovels", "Codigo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Imovels", "Codigo");
        }
    }
}
