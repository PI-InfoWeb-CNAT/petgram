namespace Aplicação.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pet",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Category = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        UserID = c.Int(nullable: false),
                        Owner_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuario", t => t.Owner_ID)
                .Index(t => t.Owner_ID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        User = c.String(nullable: false, maxLength: 50),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Data_Nascimento = c.DateTime(nullable: false),
                        Descricao = c.String(),
                        Email = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                        ConfirmaSenha = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Postagem",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Data = c.String(),
                        ImagemMimeType = c.String(),
                        Imagem = c.Binary(),
                        NomeArquivo = c.String(),
                        TamanhoArquivo = c.Long(nullable: false),
                        Descricao = c.String(),
                        Visibilidade = c.Int(nullable: false),
                        Filtro = c.Int(nullable: false),
                        Usuario_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuario", t => t.Usuario_ID)
                .Index(t => t.Usuario_ID);
            
            CreateTable(
                "dbo.Mensagem",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FK = c.Int(nullable: false),
                        Descricao = c.String(),
                        data = c.DateTime(nullable: false),
                        Postagem_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Postagem", t => t.Postagem_ID)
                .Index(t => t.Postagem_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Postagem", "Usuario_ID", "dbo.Usuario");
            DropForeignKey("dbo.Mensagem", "Postagem_ID", "dbo.Postagem");
            DropForeignKey("dbo.Pet", "Owner_ID", "dbo.Usuario");
            DropIndex("dbo.Mensagem", new[] { "Postagem_ID" });
            DropIndex("dbo.Postagem", new[] { "Usuario_ID" });
            DropIndex("dbo.Pet", new[] { "Owner_ID" });
            DropTable("dbo.Mensagem");
            DropTable("dbo.Postagem");
            DropTable("dbo.Usuario");
            DropTable("dbo.Pet");
        }
    }
}
