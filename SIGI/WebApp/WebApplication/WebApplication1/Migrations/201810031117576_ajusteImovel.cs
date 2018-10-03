namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajusteImovel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Anexoes", "Imovel_ID", "dbo.Imovels");
            DropForeignKey("dbo.Documentos", "Imovel_ID", "dbo.Imovels");
            DropIndex("dbo.Anexoes", new[] { "Imovel_ID" });
            DropIndex("dbo.Documentos", new[] { "Imovel_ID" });
            DropTable("dbo.Anexoes");
            DropTable("dbo.Documentos");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Documentos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Tipo = c.String(),
                        DataDeAlteração = c.DateTime(nullable: false),
                        Imovel_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Anexoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Imovel_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.Documentos", "Imovel_ID");
            CreateIndex("dbo.Anexoes", "Imovel_ID");
            AddForeignKey("dbo.Documentos", "Imovel_ID", "dbo.Imovels", "ID");
            AddForeignKey("dbo.Anexoes", "Imovel_ID", "dbo.Imovels", "ID");
        }
    }
}
