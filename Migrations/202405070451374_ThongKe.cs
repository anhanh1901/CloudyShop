namespace CloudyShop.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class ThongKe : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.tb_ThongKe", newName: "ThongKes");
            AddColumn("dbo.tb_Product", "OriginalPrice", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.tb_Product", "OriginalPrice");
            RenameTable(name: "dbo.ThongKes", newName: "tb_ThongKe");
        }
    }
}
