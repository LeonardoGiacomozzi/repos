namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajustandoImovel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Imovels", "Caracteristicas", c => c.String());
            DropColumn("dbo.Imovels", "CdgIntegracaoID");
            DropColumn("dbo.Imovels", "CaracteristicasPrincipais");
            DropColumn("dbo.Imovels", "CaracteristicasGerais");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Imovels", "CaracteristicasGerais", c => c.String());
            AddColumn("dbo.Imovels", "CaracteristicasPrincipais", c => c.String());
            AddColumn("dbo.Imovels", "CdgIntegracaoID", c => c.Int(nullable: false));
            DropColumn("dbo.Imovels", "Caracteristicas");
        }
    }
}
