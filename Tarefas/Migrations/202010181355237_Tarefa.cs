namespace Tarefas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tarefa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tarefas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Concluido = c.Boolean(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdUsuario, cascadeDelete: true)
                .Index(t => t.IdUsuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tarefas", "IdUsuario", "dbo.Usuarios");
            DropIndex("dbo.Tarefas", new[] { "IdUsuario" });
            DropTable("dbo.Tarefas");
        }
    }
}
