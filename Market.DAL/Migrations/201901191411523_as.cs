namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _as : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Urunler", "UrunBarkod", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Urunler", "UrunBarkod", c => c.Int(nullable: false));
        }
    }
}
