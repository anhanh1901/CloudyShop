namespace CloudyShop.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class updateGiaGoc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Product", "OriginalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }

        public override void Down()
        {
            AlterColumn("dbo.tb_Product", "OriginalPrice", c => c.String());
        }
    }
}
