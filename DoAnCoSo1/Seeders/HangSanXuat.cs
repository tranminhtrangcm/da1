using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoAnCoSo1.Models;
using System.Data.Entity.Migrations;

namespace DoAnCoSo1.Seeders
{
    public partial class Seeder
    {
        public void SeedHangSanXuat()
        {
            context_.HangSanXuatContext.AddOrUpdate(new HangSanXuat() { HangSanXuatId = 1, TenHangSanXuat = "Apple", LogoUrl = "/images/apple-logo.png" });
            context_.HangSanXuatContext.AddOrUpdate(new HangSanXuat() { HangSanXuatId = 2, TenHangSanXuat = "Samsung", LogoUrl = "/images/samsung-logo.png" });
            context_.HangSanXuatContext.AddOrUpdate(new HangSanXuat() { HangSanXuatId = 3, TenHangSanXuat = "Oppo", LogoUrl = "/images/oppo-logo.png" });
            context_.HangSanXuatContext.AddOrUpdate(new HangSanXuat() { HangSanXuatId = 4, TenHangSanXuat = "Huawei", LogoUrl = "/images/huawei-logo.png" });
            context_.HangSanXuatContext.AddOrUpdate(new HangSanXuat() { HangSanXuatId = 5, TenHangSanXuat = "Acer" });
            context_.HangSanXuatContext.AddOrUpdate(new HangSanXuat() { HangSanXuatId = 6, TenHangSanXuat = "Asus" });
            context_.HangSanXuatContext.AddOrUpdate(new HangSanXuat() { HangSanXuatId = 7, TenHangSanXuat = "Dell" });
            context_.HangSanXuatContext.AddOrUpdate(new HangSanXuat() { HangSanXuatId = 8, TenHangSanXuat = "Microsoft" });

            context_.SaveChanges();
        }
    }
}