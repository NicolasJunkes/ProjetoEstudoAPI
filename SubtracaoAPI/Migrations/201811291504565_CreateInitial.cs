namespace SubtracaoAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subtracaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor1 = c.Double(nullable: false),
                        Valor2 = c.Double(nullable: false),
                        Resultado = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subtracaos");
        }
    }
}
