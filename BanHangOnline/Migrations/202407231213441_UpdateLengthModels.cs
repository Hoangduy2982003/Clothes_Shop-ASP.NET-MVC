﻿namespace BanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLengthModels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Post", "Alias", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_Post", "Image", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Post", "SeoTitle", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_Post", "SeoDescription", c => c.String(maxLength: 500));
            AlterColumn("dbo.tb_Post", "SeoKeyword", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "Alias", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "ProductCode", c => c.String(maxLength: 50));
            AlterColumn("dbo.tb_Product", "Image", c => c.String(maxLength: 50));
            AlterColumn("dbo.tb_Product", "SeoTitle", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "SeoDescription", c => c.String(maxLength: 500));
            AlterColumn("dbo.tb_Product", "SeoKeyword", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Product", "SeoKeyword", c => c.String());
            AlterColumn("dbo.tb_Product", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_Product", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_Product", "Image", c => c.String());
            AlterColumn("dbo.tb_Product", "ProductCode", c => c.String());
            AlterColumn("dbo.tb_Product", "Alias", c => c.String());
            AlterColumn("dbo.tb_Post", "SeoKeyword", c => c.String());
            AlterColumn("dbo.tb_Post", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_Post", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_Post", "Image", c => c.String());
            AlterColumn("dbo.tb_Post", "Alias", c => c.String());
        }
    }
}
