namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteracoes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Valors", "Comissao", c => c.Double(nullable: false));
            DropColumn("dbo.Pessoas", "DataNascimento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pessoas", "DataNascimento", c => c.DateTime(nullable: false));
            DropColumn("dbo.Valors", "Comissao");
        }
    }
}
