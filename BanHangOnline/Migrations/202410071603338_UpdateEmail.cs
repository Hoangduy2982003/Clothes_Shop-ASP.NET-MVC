namespace BanHangOnline.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class UpdateEmail : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ThongKes", newName: "ThongKe");
            AddColumn("dbo.tb_Order", "Email", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.tb_Order", "Email");
            RenameTable(name: "dbo.ThongKe", newName: "ThongKes");
        }
    }
}
