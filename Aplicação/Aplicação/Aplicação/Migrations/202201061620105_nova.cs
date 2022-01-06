namespace Aplicação.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nova : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuario", "ImagemMimeType", c => c.String());
            AddColumn("dbo.Usuario", "Imagem", c => c.Binary());
            AddColumn("dbo.Usuario", "NomeArquivo", c => c.String());
            AddColumn("dbo.Usuario", "TamanhoArquivo", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuario", "TamanhoArquivo");
            DropColumn("dbo.Usuario", "NomeArquivo");
            DropColumn("dbo.Usuario", "Imagem");
            DropColumn("dbo.Usuario", "ImagemMimeType");
        }
    }
}
