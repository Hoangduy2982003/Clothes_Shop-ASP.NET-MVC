namespace BanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductCategory : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_ProductCategory", "Description", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.tb_ProductCategory", "SeoTitle", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_ProductCategory", "SeoDescription", c => c.String(maxLength: 500));
            AlterColumn("dbo.tb_ProductCategory", "SeoKeyword", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_ProductCategory", "SeoKeyword", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "Description", c => c.String());
        }
    }
}
