namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Satis",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        urunId = c.String(),
                        musteriId = c.Int(nullable: false),
                        tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Uruns",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Fiyat = c.Double(nullable: false),
                        Resim = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Uruns");
            DropTable("dbo.Satis");
            DropTable("dbo.Musteris");
        }
    }
}
