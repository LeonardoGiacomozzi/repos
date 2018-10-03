namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tituloAtendimento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Atendimentoes", "Nome", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Atendimentoes", "Nome");
        }
    }
}
