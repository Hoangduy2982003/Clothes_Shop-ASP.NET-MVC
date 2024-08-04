namespace BanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateProductCategory2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_ProductCategory", "Alias", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.tb_ProductCategory", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_ProductCategory", "Description", c => c.String(nullable: false, maxLength: 150));
            DropColumn("dbo.tb_ProductCategory", "Alias");
        }
    }
}
