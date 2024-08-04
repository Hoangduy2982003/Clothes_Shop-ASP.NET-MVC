namespace BanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateData1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Product", "Alias", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Product", "Alias");
        }
    }
}
