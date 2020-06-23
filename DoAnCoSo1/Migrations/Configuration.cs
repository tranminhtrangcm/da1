namespace DoAnCoSo1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DoAnCoSo1.Models;
    using DoAnCoSo1.Seeders;

    internal sealed class Configuration : DbMigrationsConfiguration<DoAnCoSo1.Models.DoAnCoSo1DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DoAnCoSo1DBContext context)
        {
            Seeder seeder = new Seeder(context);

            seeder.SeedLoaiSanPham();
            seeder.SeedHangSanXuat();
            seeder.SeedSanPham();
            seeder.SeedCauHinhSanPham();
            seeder.SeedHinhAnhSanPham();
            seeder.SeedKhuyenMai();
            seeder.SeedTaiKhoan();
            seeder.SeedDonHang();
        }
    }
}
