namespace Cooperchip.aulaChagas.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TelEtpTel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Telefones",
                c => new
                    {
                        TelefoneId = c.Int(nullable: false, identity: true),
                        DDD = c.String(),
                        Numero = c.String(),
                        TipoTelefone_TipoTelefoneId = c.Int(),
                    })
                .PrimaryKey(t => t.TelefoneId)
                .ForeignKey("dbo.TipoTelefones", t => t.TipoTelefone_TipoTelefoneId)
                .Index(t => t.TipoTelefone_TipoTelefoneId);
            
            CreateTable(
                "dbo.TipoTelefones",
                c => new
                    {
                        TipoTelefoneId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 12),
                        Data = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TipoTelefoneId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telefones", "TipoTelefone_TipoTelefoneId", "dbo.TipoTelefones");
            DropIndex("dbo.Telefones", new[] { "TipoTelefone_TipoTelefoneId" });
            DropTable("dbo.TipoTelefones");
            DropTable("dbo.Telefones");
        }
    }
}
