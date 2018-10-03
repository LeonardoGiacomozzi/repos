namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajustandoAtendimento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Atendimentoes", "DataAtendimento", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Atendimentoes", "DataAtendimento");
        }
    }
}
