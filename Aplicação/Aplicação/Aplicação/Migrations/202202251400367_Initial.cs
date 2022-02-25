namespace Aplicação.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
           
            DropForeignKey("dbo.Pet", "Owner_ID", "dbo.Usuario");
            DropIndex("dbo.Pet", new[] { "Owner_ID" });
            DropTable("dbo.Pet");
            DropTable("dbo.Usuario");

            CreateTable(
                "dbo.Mensagem",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        PostID = c.Int(nullable: false),
                        Descricao = c.String(),
                        Data = c.DateTime(nullable: false),
                        Postagem_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuario", t => t.UserID, cascadeDelete: true)
                .ForeignKey("dbo.Postagem", t => t.Postagem_ID)
                .Index(t => t.UserID)
                .Index(t => t.Postagem_ID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        User = c.String(),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Data_Nascimento = c.DateTime(nullable: false),
                        Descricao = c.String(),
                        Email = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                        ConfirmaSenha = c.String(nullable: false),
                        ImagemMimeType = c.String(),
                        Imagem = c.Binary(),
                        NomeArquivo = c.String(),
                        TamanhoArquivo = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
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
                        Likes = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuario", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Postagem", "UserID", "dbo.Usuario");
            DropForeignKey("dbo.Mensagem", "Postagem_ID", "dbo.Postagem");
            DropForeignKey("dbo.Pet", "Owner_ID", "dbo.Usuario");
            DropForeignKey("dbo.Mensagem", "UserID", "dbo.Usuario");
            DropIndex("dbo.Postagem", new[] { "UserID" });
            DropIndex("dbo.Pet", new[] { "Owner_ID" });
            DropIndex("dbo.Mensagem", new[] { "Postagem_ID" });
            DropIndex("dbo.Mensagem", new[] { "UserID" });
            DropTable("dbo.Postagem");
            DropTable("dbo.Pet");
            DropTable("dbo.Usuario");
            DropTable("dbo.Mensagem");
        }
    }
}
