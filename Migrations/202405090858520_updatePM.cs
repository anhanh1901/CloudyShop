namespace CloudyShop.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class updatePM : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Order", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.tb_Order", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Order", "ModifiedBy", c => c.String());
            AddColumn("dbo.tb_Order", "ModifiedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.tb_Order", "CreatedDate");
        }

        public override void Down()
        {
            AddColumn("dbo.tb_Order", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.tb_Order", "ModifiedDate");
            DropColumn("dbo.tb_Order", "ModifiedBy");
            DropColumn("dbo.tb_Order", "CreateDate");
            DropColumn("dbo.tb_Order", "Status");
        }
    }
}
