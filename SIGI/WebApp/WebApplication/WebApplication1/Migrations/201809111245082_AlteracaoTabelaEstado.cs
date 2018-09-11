namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoTabelaEstado : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Estadoes", "Pais_Id", "dbo.Pais");
            DropIndex("dbo.Estadoes", new[] { "Pais_Id" });
            RenameColumn(table: "dbo.Estadoes", name: "Pais_Id", newName: "PaisID");
            AlterColumn("dbo.Estadoes", "PaisID", c => c.Int(nullable: false));
            CreateIndex("dbo.Estadoes", "PaisID");
            AddForeignKey("dbo.Estadoes", "PaisID", "dbo.Pais", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estadoes", "PaisID", "dbo.Pais");
            DropIndex("dbo.Estadoes", new[] { "PaisID" });
            AlterColumn("dbo.Estadoes", "PaisID", c => c.Int());
            RenameColumn(table: "dbo.Estadoes", name: "PaisID", newName: "Pais_Id");
            CreateIndex("dbo.Estadoes", "Pais_Id");
            AddForeignKey("dbo.Estadoes", "Pais_Id", "dbo.Pais", "Id");
        }
    }
}
