namespace CloudyShop.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class updateorder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Order", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Order", "CreatedBy", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.tb_Order", "CreatedBy");
            DropColumn("dbo.tb_Order", "CreatedDate");
        }
    }
}
