﻿namespace CloudyShop.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class database : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Product", "Quantity", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.tb_Product", "Quantity");
        }
    }
}
