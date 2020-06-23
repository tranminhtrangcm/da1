namespace DoAnCoSo1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrongLuong : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CauHinhSanPham", "TrongLuong", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CauHinhSanPham", "TrongLuong");
        }
    }
}
